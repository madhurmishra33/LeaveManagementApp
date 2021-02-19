using Data_Factory;
using DataReadWrite.Interface;
using Logger.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.Service;
using ValidatorFactory;

namespace LeavePlanForm
{
    public class UIDisplayHelper
    {
        IDataReadWrite DataReadWrite = Data.GetDataRepository();
        ILogger logger = Logger_Factory.Logger.GetLoggerRepository();
        IValidator validator = Validator.GetValidatorRepository();
        SprintValidator sprintValidator = new SprintValidator();
        dataFormatter dataFormatter = new dataFormatter();
        public List<string> GetDisplayList()
        {
            IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();

            return (dataFormatter.getFormatedDropDownList(deserializeJson));

        }

        public string GetDisplaySprintData(int sprintNo)
        {
            IEnumerable<LeavePlanTemplate> deserializeJson = DataReadWrite.ReadData();

            return (dataFormatter.getFormattedSprintDetail(deserializeJson, sprintNo));
        }

        public string GetDisplayMemberData(int sprintNo, string memberName)
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
