using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataReadWrite.Interface;
using JSONService;
using System.Data;

namespace LeavePlanForm
{
    class dataFormatter
    {
        public dataFormatter()
        {
        }

        public string getFormattedSprintDetail(IEnumerable<LeavePlanTemplate> deserializedJSON, int sprintNo)
        {
            foreach(var JSONelement in deserializedJSON)
            {
                if (JSONelement.sprintNo == sprintNo)
                {

                    // return (JsonConvert.SerializeObject(JSONelement, Formatting.Indented));     ORIGINAL
                    string format = string.Format("Employee Name \t Leaves \n\n");

                    foreach(var member in JSONelement.sprintLeavePlan)
                    {
                        format += string.Format("{0}\t", member.employeeName);

                        foreach(var leaves in member.employeePlannedLeaves)
                        {
                            format += string.Format("\t{0}", leaves.ToShortDateString());
                        }
                        format += string.Format("\n");
                    }
                    return format;
                }
            }
            return "Error in fetching Details";
        }

        public string getFormattedMemberDetail(IEnumerable<LeavePlanTemplate> deserializedJSON, int sprintNo, string memberName)
        {
            foreach (var JSONelement in deserializedJSON)
            {
                if (JSONelement.sprintNo == sprintNo)
                {

                    // return (JsonConvert.SerializeObject(JSONelement, Formatting.Indented));     ORIGINAL
                    string format = string.Format("Employee Name \t Leaves \n\n");

                    foreach (var member in JSONelement.sprintLeavePlan)
                    {
                        if (member.employeeName == memberName)
                        {
                            format += string.Format("{0}\t", member.employeeName);

                            foreach (var leaves in member.employeePlannedLeaves)
                            {
                                format += string.Format("\t{0}", leaves.ToShortDateString());
                            }
                            format += string.Format("\n");
                        }
                    }
                    return format;
                }
            }
            return "Error in fetching Details";
        }

        public List<string> getFormatedDropDownList(IEnumerable<LeavePlanTemplate> deserializedData)
        {

            var displayList = new List<string>();

            foreach (var JSONelement in deserializedData)
            {
                string addSprintDetail = string.Format(@"Sprint {0} ({1} to {2})", JSONelement.sprintNo, JSONelement.sprintStartDate.ToShortDateString(), JSONelement.sprintEndDate.ToShortDateString());

                displayList.Add(addSprintDetail);
            }

            return displayList;
        }

    }
}
