namespace LeavePlanForm
{
    partial class sprintPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sprintNoLabel = new System.Windows.Forms.Label();
            this.sprintComboList = new System.Windows.Forms.ComboBox();
            this.displayLeavePlanBox = new System.Windows.Forms.RichTextBox();
            this.sprintDetailsButton = new System.Windows.Forms.Button();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.memberNameTextbox = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.grpLeave = new System.Windows.Forms.GroupBox();
            this.removeLeaveButton = new System.Windows.Forms.Button();
            this.addLeaveButton = new System.Windows.Forms.Button();
            this.leaveDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.leaveNameTextbox = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.enteredNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.displayMemberLeaveButton = new System.Windows.Forms.Button();
            this.memberLeaveNameTextbox = new System.Windows.Forms.TextBox();
            this.grpMember.SuspendLayout();
            this.grpLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enteredNameError)).BeginInit();
            this.SuspendLayout();
            // 
            // sprintNoLabel
            // 
            this.sprintNoLabel.AutoSize = true;
            this.sprintNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintNoLabel.Location = new System.Drawing.Point(42, 26);
            this.sprintNoLabel.Name = "sprintNoLabel";
            this.sprintNoLabel.Size = new System.Drawing.Size(63, 25);
            this.sprintNoLabel.TabIndex = 1;
            this.sprintNoLabel.Text = "Sprint";
            // 
            // sprintComboList
            // 
            this.sprintComboList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sprintComboList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sprintComboList.FormattingEnabled = true;
            this.sprintComboList.Items.AddRange(new object[] {
            "Madhur",
            "Mishra"});
            this.sprintComboList.Location = new System.Drawing.Point(170, 27);
            this.sprintComboList.Name = "sprintComboList";
            this.sprintComboList.Size = new System.Drawing.Size(258, 24);
            this.sprintComboList.TabIndex = 2;
            // 
            // displayLeavePlanBox
            // 
            this.displayLeavePlanBox.Location = new System.Drawing.Point(47, 75);
            this.displayLeavePlanBox.Name = "displayLeavePlanBox";
            this.displayLeavePlanBox.ReadOnly = true;
            this.displayLeavePlanBox.Size = new System.Drawing.Size(381, 263);
            this.displayLeavePlanBox.TabIndex = 3;
            this.displayLeavePlanBox.Text = "";
            this.displayLeavePlanBox.WordWrap = false;
            // 
            // sprintDetailsButton
            // 
            this.sprintDetailsButton.Location = new System.Drawing.Point(282, 400);
            this.sprintDetailsButton.Name = "sprintDetailsButton";
            this.sprintDetailsButton.Size = new System.Drawing.Size(146, 29);
            this.sprintDetailsButton.TabIndex = 4;
            this.sprintDetailsButton.Text = "Sprint Details";
            this.sprintDetailsButton.UseVisualStyleBackColor = true;
            this.sprintDetailsButton.Click += new System.EventHandler(this.sprintDetailsButton_Click);
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.removeMemberButton);
            this.grpMember.Controls.Add(this.addMemberButton);
            this.grpMember.Controls.Add(this.memberNameTextbox);
            this.grpMember.Controls.Add(this.lblMemberName);
            this.grpMember.Location = new System.Drawing.Point(484, 109);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(272, 107);
            this.grpMember.TabIndex = 5;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Member";
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.Location = new System.Drawing.Point(174, 78);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(75, 23);
            this.removeMemberButton.TabIndex = 3;
            this.removeMemberButton.Text = "Remove";
            this.removeMemberButton.UseVisualStyleBackColor = true;
            this.removeMemberButton.Click += new System.EventHandler(this.removeMemberButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(83, 78);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(75, 23);
            this.addMemberButton.TabIndex = 2;
            this.addMemberButton.Text = "Add";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // memberNameTextbox
            // 
            this.memberNameTextbox.Location = new System.Drawing.Point(83, 34);
            this.memberNameTextbox.Name = "memberNameTextbox";
            this.memberNameTextbox.Size = new System.Drawing.Size(166, 22);
            this.memberNameTextbox.TabIndex = 1;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(17, 37);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(45, 17);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Name";
            // 
            // grpLeave
            // 
            this.grpLeave.Controls.Add(this.removeLeaveButton);
            this.grpLeave.Controls.Add(this.addLeaveButton);
            this.grpLeave.Controls.Add(this.leaveDate);
            this.grpLeave.Controls.Add(this.lblDate);
            this.grpLeave.Controls.Add(this.leaveNameTextbox);
            this.grpLeave.Controls.Add(this.lblName);
            this.grpLeave.Location = new System.Drawing.Point(484, 232);
            this.grpLeave.Name = "grpLeave";
            this.grpLeave.Size = new System.Drawing.Size(272, 140);
            this.grpLeave.TabIndex = 6;
            this.grpLeave.TabStop = false;
            this.grpLeave.Text = "Leave";
            // 
            // removeLeaveButton
            // 
            this.removeLeaveButton.Location = new System.Drawing.Point(174, 111);
            this.removeLeaveButton.Name = "removeLeaveButton";
            this.removeLeaveButton.Size = new System.Drawing.Size(75, 23);
            this.removeLeaveButton.TabIndex = 6;
            this.removeLeaveButton.Text = "Remove";
            this.removeLeaveButton.UseVisualStyleBackColor = true;
            this.removeLeaveButton.Click += new System.EventHandler(this.removeLeaveButton_Click);
            // 
            // addLeaveButton
            // 
            this.addLeaveButton.Location = new System.Drawing.Point(83, 111);
            this.addLeaveButton.Name = "addLeaveButton";
            this.addLeaveButton.Size = new System.Drawing.Size(75, 23);
            this.addLeaveButton.TabIndex = 5;
            this.addLeaveButton.Text = "Add";
            this.addLeaveButton.UseVisualStyleBackColor = true;
            this.addLeaveButton.Click += new System.EventHandler(this.addLeaveButton_Click);
            // 
            // leaveDate
            // 
            this.leaveDate.Location = new System.Drawing.Point(83, 62);
            this.leaveDate.Name = "leaveDate";
            this.leaveDate.Size = new System.Drawing.Size(166, 22);
            this.leaveDate.TabIndex = 4;
            this.leaveDate.Value = new System.DateTime(2020, 10, 26, 15, 54, 45, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(24, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // leaveNameTextbox
            // 
            this.leaveNameTextbox.Location = new System.Drawing.Point(83, 25);
            this.leaveNameTextbox.Name = "leaveNameTextbox";
            this.leaveNameTextbox.Size = new System.Drawing.Size(166, 22);
            this.leaveNameTextbox.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // enteredNameError
            // 
            this.enteredNameError.ContainerControl = this;
            // 
            // displayMemberLeaveButton
            // 
            this.displayMemberLeaveButton.Location = new System.Drawing.Point(282, 353);
            this.displayMemberLeaveButton.Name = "displayMemberLeaveButton";
            this.displayMemberLeaveButton.Size = new System.Drawing.Size(146, 29);
            this.displayMemberLeaveButton.TabIndex = 7;
            this.displayMemberLeaveButton.Text = "Member Leave Plan";
            this.displayMemberLeaveButton.UseVisualStyleBackColor = true;
            this.displayMemberLeaveButton.Click += new System.EventHandler(this.displayMemberLeaveButton_Click);
            // 
            // memberLeaveNameTextbox
            // 
            this.memberLeaveNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLeaveNameTextbox.Location = new System.Drawing.Point(47, 356);
            this.memberLeaveNameTextbox.Name = "memberLeaveNameTextbox";
            this.memberLeaveNameTextbox.Size = new System.Drawing.Size(171, 27);
            this.memberLeaveNameTextbox.TabIndex = 8;
            // 
            // sprintPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberLeaveNameTextbox);
            this.Controls.Add(this.displayMemberLeaveButton);
            this.Controls.Add(this.grpLeave);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.sprintDetailsButton);
            this.Controls.Add(this.displayLeavePlanBox);
            this.Controls.Add(this.sprintComboList);
            this.Controls.Add(this.sprintNoLabel);
            this.Name = "sprintPage";
            this.Text = "sprintPage";
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.grpLeave.ResumeLayout(false);
            this.grpLeave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enteredNameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sprintNoLabel;
        private System.Windows.Forms.ComboBox sprintComboList;
        private System.Windows.Forms.RichTextBox displayLeavePlanBox;
        private System.Windows.Forms.Button sprintDetailsButton;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.TextBox memberNameTextbox;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.GroupBox grpLeave;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox leaveNameTextbox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button removeLeaveButton;
        private System.Windows.Forms.Button addLeaveButton;
        private System.Windows.Forms.DateTimePicker leaveDate;
        private System.Windows.Forms.ErrorProvider enteredNameError;
        private System.Windows.Forms.Button displayMemberLeaveButton;
        private System.Windows.Forms.TextBox memberLeaveNameTextbox;
    }
}