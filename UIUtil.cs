using System;
using Logger.Interface;
using Validation.Service;
using DataReadWrite.Interface;
using JSONService;
using HolidayChecker;
using System.Collections.Generic;
using EmployeeRights;

namespace LeavePlanForm
{
    class UIUtil
    {
        IDataReadWrite DataReadWrite = new JSONData();
        ILogger logger = new LoggerService();
        IValidator validator = new ValidationService();
        SprintValidator sprintValidator = new SprintValidator();
        IHoliday holidayChecker = new Holiday();
        dataFormatter dataFormatter = new dataFormatter();
        Dev dev = new Dev();

        public bool checkAndCreatePI(string sprintSize, DateTime PIStartDate, DateTime PIEndDate)
        {
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
                DataReadWrite.createFile();
                IEnumerable<LeavePlanTemplate> toWrite = dev.createPI(int.Parse(sprintSize), PIStartDate, PIEndDate);
                DataReadWrite.WriteData(toWrite);

                logger.showMessage("PI created !");
                return true;
            }
        }

        public void checkAndRemoveMember(int sprintNum, string memberName)
        {
            if(!validator.isNonEmptyString(memberName))
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
                IEnumerable<LeavePlanTemplate> dataToWrite = dev.removeMember(deserializeJson, sprintNum, memberName);

                DataReadWrite.WriteData(dataToWrite);
                logger.showMessage("Member Removed");
            }
        }

        public void checkAndAddMemeber(int sprintNum, string memberName)
        {
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
                IEnumerable<LeavePlanTemplate> dataToWrite = dev.addMember(deserializeJson, sprintNum, memberName);

                DataReadWrite.WriteData(dataToWrite);
                logger.showMessage("Member Added");

            }
        }

        public void checkAndAddLeave(int sprintNum, string memberName, DateTime leaveDate)
        {
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
                IEnumerable<LeavePlanTemplate> dataToWrite = dev.addLeave(deserializeJson, sprintNum, memberName, leaveDate);

                DataReadWrite.WriteData(dataToWrite);
                logger.showMessage("Leave Added");

            }
        }

        public void checkAndRemoveLeave(int sprintNum, string memberName, DateTime leaveDate)
        {
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
                IEnumerable<LeavePlanTemplate> dataToWrite = dev.removeLeave(deserializeJson, sprintNum, memberName, leaveDate);

                DataReadWrite.WriteData(dataToWrite);
                logger.showMessage("Leave Removed");

            }
        }

        public List<string> getDisplayList()
        {
            IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();

            return(dataFormatter.getFormatedDropDownList(deserializeJson));

        }

        public string getDisplaySprintData(int sprintNo)
        {
            IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();

            return (dataFormatter.getFormattedSprintDetail(deserializeJson, sprintNo));
        }

        public string getDisplayMemberData(int sprintNo, string memberName)
        {
            if (!validator.isNonEmptyString(memberName))
            {
                logger.showMessage("Enter Member Name");
                return "";
            }
            else if (!sprintValidator.isMemberPartOfSprint(sprintNo, memberName))
            {
                logger.showMessage("Member Not present in Sprint");
                return "";
            }
            else
            {
                IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();

                return (dataFormatter.getFormattedMemberDetail(deserializeJson, sprintNo, memberName));
            }
        }
    }
}
