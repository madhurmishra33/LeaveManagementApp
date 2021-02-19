using DataReadWrite.Interface;
using JSONService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeavePlanForm
{
    
    public partial class sprintPage : Form
    {
        UIMemberHelper memberHelper = new UIMemberHelper();
        UIDisplayHelper displayHelper = new UIDisplayHelper();

        public sprintPage()
        {
            InitializeComponent();
            sprintComboList.DataSource = displayHelper.GetDisplayList();
        }


        // Displays formatted JSON Leave Plan
        private void sprintDetailsButton_Click(object sender, EventArgs e)
        { 
            int currentSprint = (sprintComboList.SelectedIndex) + 1;
            displayLeavePlanBox.Text = displayHelper.GetDisplaySprintData(currentSprint);
        }


        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            memberHelper.CheckAndRemoveMember((sprintComboList.SelectedIndex) + 1, memberNameTextbox.Text);
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            memberHelper.CheckAndAddMemeber((sprintComboList.SelectedIndex) + 1, memberNameTextbox.Text);
        }

        private void addLeaveButton_Click(object sender, EventArgs e)
        {
            memberHelper.CheckAndAddLeave(sprintComboList.SelectedIndex + 1, leaveNameTextbox.Text, leaveDate.Value);
        }

        private void removeLeaveButton_Click(object sender, EventArgs e)
        {
            memberHelper.CheckAndRemoveLeave(sprintComboList.SelectedIndex + 1, leaveNameTextbox.Text, leaveDate.Value);
        }

        private void displayMemberLeaveButton_Click(object sender, EventArgs e)
        {
            int currentSprint = (sprintComboList.SelectedIndex) + 1;
            string toDisplay = displayHelper.GetDisplayMemberData(currentSprint, memberLeaveNameTextbox.Text);
            if(toDisplay != "")
            {
                displayLeavePlanBox.Text = toDisplay;
            }
        }
    }

}
