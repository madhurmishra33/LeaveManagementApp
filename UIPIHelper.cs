using Data_Factory;
using DataReadWrite.Interface;
using EmployeeRights.Service;
using Logger.Interface;
using MemberFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.Service;
using ValidatorFactory;

namespace LeavePlanForm
{

    public class UIPIHelper
    {
        IDataReadWrite DataReadWrite = Data.GetDataRepository();
        ILogger logger = Logger_Factory.Logger.GetLoggerRepository();
        IValidator validator = Validator.GetValidatorRepository();
        public bool CheckAndCreatePI(string sprintSize, DateTime PIStartDate, DateTime PIEndDate)
        {
            var createrRightMember = (ICreaterRight)Member.GetMemberRepository("Creater Rights");
            if (!validator.isValidNumericString(sprintSize))
            {
                logger.showMessage("Enter Valid Sprint Size");
                return false;
            }
            else if (!validator.isDateSmaller(PIStartDate, PIEndDate))
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
    }
}
