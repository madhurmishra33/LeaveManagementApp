using DataReadWrite.Interface;
using JSONService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeavePlanForm
{
    class SprintValidator
    {
        IDataReadWrite jsonDataObj = new JSONData();
        public IEnumerable<LeavePlanTemplate> deserializedJsonData { get; set; }
        public bool isMemberPartOfSprint(int sprintNum,string memberName)
        {
            deserializedJsonData = jsonDataObj.ReadData();

            foreach(var sprint in deserializedJsonData)
            {
                if(sprint.sprintNo == sprintNum)
                {
                    var sprintLeavePlans = sprint.sprintLeavePlan;
                    foreach(var member in sprintLeavePlans)
                    {
                        if(member.employeeName == memberName)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool isDateInSprintRange(int sprintNum, DateTime currentDate )
        {
            deserializedJsonData = jsonDataObj.ReadData();

            foreach (var sprint in deserializedJsonData)
            {
                if (sprint.sprintNo == sprintNum)
                {
                    if ((currentDate >= sprint.sprintStartDate) && (currentDate <= sprint.sprintEndDate.AddDays(1)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool isDateChangeable(DateTime currentDate)
        {
            if(currentDate < DateTime.Today)
            {
                return false;
            }
            return true;
        }

        public bool isLeaveAlreadyPresent(int sprintNum, string memberName,DateTime leaveDate)
        {
            deserializedJsonData = jsonDataObj.ReadData();

            foreach (var sprint in deserializedJsonData)
            {
                if (sprint.sprintNo == sprintNum)
                {
                    var sprintLeavePlans = sprint.sprintLeavePlan;
                    foreach (var member in sprintLeavePlans)
                    {
                        if (member.employeeName == memberName)
                        {
                            var memberPlannedLeaves = member.employeePlannedLeaves;
                            if(memberPlannedLeaves.BinarySearch(leaveDate)>=0)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;

        }
    }
}
