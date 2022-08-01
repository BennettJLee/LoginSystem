
namespace Deliv_login_223
{
    partial class Manager
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
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.buttonAssignPro = new System.Windows.Forms.Button();
            this.buttonViewTask = new System.Windows.Forms.Button();
            this.buttonRecordTask = new System.Windows.Forms.Button();
            this.buttonCreateProjectIssues = new System.Windows.Forms.Button();
            this.buttonViewProjectIssues = new System.Windows.Forms.Button();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcome.Location = new System.Drawing.Point(0, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.Size = new System.Drawing.Size(698, 55);
            this.LabelWelcome.TabIndex = 0;
            this.LabelWelcome.Text = "Welcome";
            this.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(291, 470);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(114, 38);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTask.Location = new System.Drawing.Point(212, 93);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(276, 38);
            this.buttonCreateTask.TabIndex = 8;
            this.buttonCreateTask.Text = "Create Task";
            this.buttonCreateTask.UseVisualStyleBackColor = true;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
            // 
            // buttonAssignPro
            // 
            this.buttonAssignPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignPro.Location = new System.Drawing.Point(212, 137);
            this.buttonAssignPro.Name = "buttonAssignPro";
            this.buttonAssignPro.Size = new System.Drawing.Size(276, 38);
            this.buttonAssignPro.TabIndex = 9;
            this.buttonAssignPro.Text = "Assign Programmers";
            this.buttonAssignPro.UseVisualStyleBackColor = true;
            this.buttonAssignPro.Click += new System.EventHandler(this.buttonAssignPro_Click);
            // 
            // buttonViewTask
            // 
            this.buttonViewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewTask.Location = new System.Drawing.Point(212, 225);
            this.buttonViewTask.Name = "buttonViewTask";
            this.buttonViewTask.Size = new System.Drawing.Size(276, 38);
            this.buttonViewTask.TabIndex = 10;
            this.buttonViewTask.Text = "View Task Progress";
            this.buttonViewTask.UseVisualStyleBackColor = true;
            this.buttonViewTask.Click += new System.EventHandler(this.buttonViewTask_Click);
            // 
            // buttonRecordTask
            // 
            this.buttonRecordTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecordTask.Location = new System.Drawing.Point(212, 181);
            this.buttonRecordTask.Name = "buttonRecordTask";
            this.buttonRecordTask.Size = new System.Drawing.Size(276, 38);
            this.buttonRecordTask.TabIndex = 11;
            this.buttonRecordTask.Text = "Record Task Progress";
            this.buttonRecordTask.UseVisualStyleBackColor = true;
            this.buttonRecordTask.Click += new System.EventHandler(this.buttonRecordTask_Click);
            // 
            // buttonCreateProjectIssues
            // 
            this.buttonCreateProjectIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateProjectIssues.Location = new System.Drawing.Point(212, 269);
            this.buttonCreateProjectIssues.Name = "buttonCreateProjectIssues";
            this.buttonCreateProjectIssues.Size = new System.Drawing.Size(276, 38);
            this.buttonCreateProjectIssues.TabIndex = 12;
            this.buttonCreateProjectIssues.Text = "Create Project Issues";
            this.buttonCreateProjectIssues.UseVisualStyleBackColor = true;
            this.buttonCreateProjectIssues.Click += new System.EventHandler(this.buttonCreateProjectIssues_Click);
            // 
            // buttonViewProjectIssues
            // 
            this.buttonViewProjectIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProjectIssues.Location = new System.Drawing.Point(212, 313);
            this.buttonViewProjectIssues.Name = "buttonViewProjectIssues";
            this.buttonViewProjectIssues.Size = new System.Drawing.Size(276, 38);
            this.buttonViewProjectIssues.TabIndex = 13;
            this.buttonViewProjectIssues.Text = "View Project Issues";
            this.buttonViewProjectIssues.UseVisualStyleBackColor = true;
            this.buttonViewProjectIssues.Click += new System.EventHandler(this.buttonViewProjectIssues_Click);
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateReport.Location = new System.Drawing.Point(212, 357);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(276, 38);
            this.buttonCreateReport.TabIndex = 14;
            this.buttonCreateReport.Text = "Create Report";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistics.Location = new System.Drawing.Point(212, 401);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(276, 38);
            this.buttonStatistics.TabIndex = 17;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 520);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.buttonViewProjectIssues);
            this.Controls.Add(this.buttonCreateProjectIssues);
            this.Controls.Add(this.buttonRecordTask);
            this.Controls.Add(this.buttonViewTask);
            this.Controls.Add(this.buttonAssignPro);
            this.Controls.Add(this.buttonCreateTask);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.LabelWelcome);
            this.Name = "Manager";
            this.Text = "Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelWelcome;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Button buttonAssignPro;
        private System.Windows.Forms.Button buttonViewTask;
        private System.Windows.Forms.Button buttonRecordTask;
        private System.Windows.Forms.Button buttonCreateProjectIssues;
        private System.Windows.Forms.Button buttonViewProjectIssues;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Button buttonStatistics;
    }
}