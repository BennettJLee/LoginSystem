
namespace Deliv_login_223
{
    partial class CreateReport
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
            System.Windows.Forms.Label LabelWelcome;
            this.listBoxReport = new System.Windows.Forms.ListBox();
            this.comboBoxTaskID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            LabelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelWelcome
            // 
            LabelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            LabelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelWelcome.Location = new System.Drawing.Point(0, 0);
            LabelWelcome.Name = "LabelWelcome";
            LabelWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            LabelWelcome.Size = new System.Drawing.Size(485, 55);
            LabelWelcome.TabIndex = 6;
            LabelWelcome.Text = "Report";
            LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxReport
            // 
            this.listBoxReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReport.FormattingEnabled = true;
            this.listBoxReport.ItemHeight = 18;
            this.listBoxReport.Location = new System.Drawing.Point(37, 159);
            this.listBoxReport.Name = "listBoxReport";
            this.listBoxReport.Size = new System.Drawing.Size(409, 346);
            this.listBoxReport.TabIndex = 5;
            // 
            // comboBoxTaskID
            // 
            this.comboBoxTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTaskID.FormattingEnabled = true;
            this.comboBoxTaskID.Location = new System.Drawing.Point(187, 103);
            this.comboBoxTaskID.Name = "comboBoxTaskID";
            this.comboBoxTaskID.Size = new System.Drawing.Size(145, 39);
            this.comboBoxTaskID.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Project ID:";
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTask.Location = new System.Drawing.Point(187, 522);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(118, 38);
            this.buttonCreateTask.TabIndex = 23;
            this.buttonCreateTask.Text = "Create";
            this.buttonCreateTask.UseVisualStyleBackColor = true;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCreateTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTaskID);
            this.Controls.Add(LabelWelcome);
            this.Controls.Add(this.listBoxReport);
            this.Name = "CreateReport";
            this.Text = "CreateReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxReport;
        private System.Windows.Forms.ComboBox comboBoxTaskID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Button button1;
    }
}