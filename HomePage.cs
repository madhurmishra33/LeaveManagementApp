using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeavePlanForm
{
    public partial class HomePIPage : Form
    {
        public HomePIPage()
        {
            InitializeComponent();
        }

        // Button Click , create and write PI to JSON and then navigate to spintPage form.
        private void createPIButton_Click(object sender, EventArgs e)
        {
            UIPIHelper piHelper = new UIPIHelper();
            if(piHelper.CheckAndCreatePI(sprintSizeTextbox.Text, piStartDate.Value, piEndDate.Value))
            {
                sprintPage sp = new sprintPage();
                sp.ShowDialog();
            }
        }

    }
}
