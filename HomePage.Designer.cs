using System;

namespace LeavePlanForm
{
    partial class HomePIPage
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
            this.grpPI = new System.Windows.Forms.GroupBox();
            this.piEndDate = new System.Windows.Forms.DateTimePicker();
            this.piStartDate = new System.Windows.Forms.DateTimePicker();
            this.sprintSizeTextbox = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblSprintSize = new System.Windows.Forms.Label();
            this.createPIButton = new System.Windows.Forms.Button();
            this.sprintSizeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.sprintDateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprintSizeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintDateError)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPI
            // 
            this.grpPI.Controls.Add(this.piEndDate);
            this.grpPI.Controls.Add(this.piStartDate);
            this.grpPI.Controls.Add(this.sprintSizeTextbox);
            this.grpPI.Controls.Add(this.lblEndDate);
            this.grpPI.Controls.Add(this.lblStartDate);
            this.grpPI.Controls.Add(this.lblSprintSize);
            this.grpPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPI.Location = new System.Drawing.Point(34, 59);
            this.grpPI.Name = "grpPI";
            this.grpPI.Size = new System.Drawing.Size(463, 237);
            this.grpPI.TabIndex = 0;
            this.grpPI.TabStop = false;
            this.grpPI.Text = "PI details";
            // 
            // piEndDate
            // 
            this.piEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piEndDate.Location = new System.Drawing.Point(278, 180);
            this.piEndDate.Name = "piEndDate";
            this.piEndDate.Size = new System.Drawing.Size(139, 34);
            this.piEndDate.TabIndex = 5;
            // 
            // piStartDate
            // 
            this.piStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piStartDate.Location = new System.Drawing.Point(278, 121);
            this.piStartDate.Name = "piStartDate";
            this.piStartDate.Size = new System.Drawing.Size(139, 34);
            this.piStartDate.TabIndex = 4;
            this.piStartDate.Value = new System.DateTime(2020, 10, 23, 0, 0, 0, 0);
            // 
            // sprintSizeTextbox
            // 
            this.sprintSizeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintSizeTextbox.Location = new System.Drawing.Point(278, 70);
            this.sprintSizeTextbox.Name = "sprintSizeTextbox";
            this.sprintSizeTextbox.Size = new System.Drawing.Size(139, 30);
            this.sprintSizeTextbox.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(112, 188);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 25);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(106, 129);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 25);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblSprintSize
            // 
            this.lblSprintSize.AutoSize = true;
            this.lblSprintSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintSize.Location = new System.Drawing.Point(42, 70);
            this.lblSprintSize.Name = "lblSprintSize";
            this.lblSprintSize.Size = new System.Drawing.Size(163, 25);
            this.lblSprintSize.TabIndex = 0;
            this.lblSprintSize.Text = "Sprint Size(days)";
            // 
            // createPIButton
            // 
            this.createPIButton.Location = new System.Drawing.Point(312, 328);
            this.createPIButton.Name = "createPIButton";
            this.createPIButton.Size = new System.Drawing.Size(139, 39);
            this.createPIButton.TabIndex = 1;
            this.createPIButton.Text = "Create";
            this.createPIButton.UseVisualStyleBackColor = true;
            this.createPIButton.Click += new System.EventHandler(this.createPIButton_Click);
            // 
            // sprintSizeError
            // 
            this.sprintSizeError.ContainerControl = this;
            // 
            // sprintDateError
            // 
            this.sprintDateError.ContainerControl = this;
            // 
            // HomePIPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createPIButton);
            this.Controls.Add(this.grpPI);
            this.Name = "HomePIPage";
            this.Text = "Leave Plan WinForm";
            this.grpPI.ResumeLayout(false);
            this.grpPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprintSizeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintDateError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPI;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblSprintSize;
        private System.Windows.Forms.DateTimePicker piEndDate;
        private System.Windows.Forms.DateTimePicker piStartDate;
        private System.Windows.Forms.TextBox sprintSizeTextbox;
        private System.Windows.Forms.Button createPIButton;
        private System.Windows.Forms.ErrorProvider sprintSizeError;
        private EventHandler txtSprintSize_TextChanged;
        private System.Windows.Forms.ErrorProvider sprintDateError;
    }
}

