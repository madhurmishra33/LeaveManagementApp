using System;
using Logger.Interface;
using Validation.Service;
using DataReadWrite.Interface;
using HolidayChecker;
using System.Collections.Generic;
using EmployeeRights.Service;
using EmployeeRights;
using Data_Factory;
using MemberFactory;
using ValidatorFactory;
using HolidayCheckerFactory;

namespace LeavePlanForm
{
    class UIMemberHelper
    {
        IDataReadWrite DataReadWrite = Data.GetDataRepository();
        ILogger logger = Logger_Factory.Logger.GetLoggerRepository();
        IValidator validator = Validator.GetValidatorRepository();
        SprintValidator sprintValidator = new SprintValidator();
        IHoliday holidayChecker = HolidayCheckerFactory.HolidayChecker.GetHolidayChecker();

        public bool CheckAndCreatePI(string sprintSize, DateTime PIStartDate, DateTime PIEndDate)
        {
            var createrRightMember = (ICreaterRight)Member.GetMemberRepository("Creater Rights");
            if(!validator.isValidNumericString(sprintSize))
            {
                logger.showMessage("Enter Valid Sprint Size");
                return false;
            }
            else if(!validator.isDateSmaller(PIStartDate,PIEndDate))
            {
                logger.showMessage("PI Start Date should be smaller");
                return false;
            }
            else
            {
                DataReadWrite.CreateFile();
                IEnumerable<LeavePlanTemplate> toWrite = createrRightMember.createPI(int.Parse(sprintSize), PIStartDate, PIEndDate);
                DataReadWrite.WriteData(toWrite);
                logger.showMessage("PI created !");
                return true;
            }
        }

        public void CheckAndRemoveMember(int sprintNum, string memberName)
        {
            var createrRightMember = (IAdminRights)Member.GetMemberRepository("Admin Rights");
            if (!validator.isNonEmptyString(memberName))
            {
                logger.showMessage("Enter Member Name");
            }
            else if(!sprintValidator.isMemberPartOfSprint(sprintNum,memberName))
            {
                logger.showMessage("Member not Present");
            }
            else
            {
                IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();
                IEnumerable<LeavePlanTemplate> dataToWrite = createrRightMember.RemoveMember(deserializeJson, sprintNum, memberName);

                DataReadWrite.WriteData(dataToWrite);
                logger.showMessage("Member Removed");
            }
        }

        public void CheckAndAddMemeber(int sprintNum, string memberName)
        {
            var createrRightMember = (IAdminRights)Member.GetMemberRepository("Admin Rights");
            if (!validator.isNonEmptyString(memberName))
            {
                logger.showMessage("Enter Member Name");
            }
            else if(sprintValidator.isMemberPartOfSprint(sprintNum,memberName))
            {
                logger.showMessage("Member Already Present");
            }
            else
            {
                IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();
                IEnumerable<LeavePlanTemplate> dataToWrite = createrRightMember.AddMember(deserializeJson, sprintNum, memberName);

                DataReadWrite.WriteData(dataToWrite);
                logger.showMessage("Member Added");

            }
        }

        public void CheckAndAddLeave(int sprintNum, string memberName, DateTime leaveDate)
        {
            var createrRightMember = (IFundamentalRights)Member.GetMemberRepository("Fundamental Rights");
            if (!validator.isNonEmptyString(memberName))
            {
                logger.showMessage("Enter Member Name");
            }
            else if(!sprintValidator.isDateInSprintRange(sprintNum, leaveDate))
            {
                logger.showMessage("Entered Date is out of Sprint Range");
            }
            else if(!sprintValidator.isMemberPartOfSprint(sprintNum, memberName))
            {
                logger.showMessage("Member Not present in Sprint");
            }
            else if(sprintValidator.isLeaveAlreadyPresent(sprintNum, memberName, leaveDate))
            {
                logger.showMessage("Leave Already Present");
            }
            else if(holidayChecker.isWeekend(leaveDate))
            {
                logger.showMessage("Is Holiday");
            }
            else
            {
                IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();
                IEnumerable<LeavePlanTemplate> dataToWrite = createrRightMember.addLeave(deserializeJson, sprintNum, memberName, leaveDate);

                DataReadWrite.WriteData(dataToWrite);
                logger.showMessage("Leave Added");

            }
        }

        public void CheckAndRemoveLeave(int sprintNum, string memberName, DateTime leaveDate)
        {
            var createrRightMember = (IFundamentalRights)Member.GetMemberRepository("Fundamental Rights");
            if (!validator.isNonEmptyString(memberName))
            {
                logger.showMessage("Enter Member Name");
            }
            else if (!sprintValidator.isDateInSprintRange(sprintNum, leaveDate))
            {
                logger.showMessage("Entered Date is out of Sprint Range");
            }
            else if (!sprintValidator.isMemberPartOfSprint(sprintNum, memberName))
            {
                logger.showMessage("Member Not present in Sprint");
            }
            else if (!sprintValidator.isLeaveAlreadyPresent(sprintNum, memberName, leaveDate))
            {
                logger.showMessage("Not a Leave Day");
            }
            else if (!sprintValidator.isDateChangeable(leaveDate))
            {
                logger.showMessage("Cannot Modify Leave on Date Already Passed");
            }
            else
            {
                IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();
                IEnumerable<LeavePlanTemplate> dataToWrite = createrRightMember.removeLeave(deserializeJson, sprintNum, memberName, leaveDate);

                DataReadWrite.WriteData(dataToWrite);
                logger.showMessage("Leave Removed");

            }
        }
    }
}
