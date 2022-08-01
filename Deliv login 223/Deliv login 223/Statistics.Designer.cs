
namespace Deliv_login_223
{
    partial class Statistics
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProjectID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCompletion = new System.Windows.Forms.ComboBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.listBoxReport = new System.Windows.Forms.ListBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            LabelWelcome.Size = new System.Drawing.Size(1251, 55);
            LabelWelcome.TabIndex = 23;
            LabelWelcome.Text = "Statistics";
            LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Project ID:";
            // 
            // comboBoxProjectID
            // 
            this.comboBoxProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProjectID.FormattingEnabled = true;
            this.comboBoxProjectID.Items.AddRange(new object[] {
            "No specification"});
            this.comboBoxProjectID.Location = new System.Drawing.Point(554, 75);
            this.comboBoxProjectID.Name = "comboBoxProjectID";
            this.comboBoxProjectID.Size = new System.Drawing.Size(285, 39);
            this.comboBoxProjectID.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Completion:";
            // 
            // comboBoxCompletion
            // 
            this.comboBoxCompletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompletion.FormattingEnabled = true;
            this.comboBoxCompletion.Items.AddRange(new object[] {
            "No specification",
            "Complete",
            "Incomplete"});
            this.comboBoxCompletion.Location = new System.Drawing.Point(554, 120);
            this.comboBoxCompletion.Name = "comboBoxCompletion";
            this.comboBoxCompletion.Size = new System.Drawing.Size(285, 39);
            this.comboBoxCompletion.TabIndex = 26;
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(572, 555);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(114, 38);
            this.buttonView.TabIndex = 28;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // listBoxReport
            // 
            this.listBoxReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReport.FormattingEnabled = true;
            this.listBoxReport.ItemHeight = 18;
            this.listBoxReport.Location = new System.Drawing.Point(33, 259);
            this.listBoxReport.Name = "listBoxReport";
            this.listBoxReport.Size = new System.Drawing.Size(1186, 274);
            this.listBoxReport.TabIndex = 29;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartDate.Location = new System.Drawing.Point(394, 189);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(258, 38);
            this.textBoxStartDate.TabIndex = 37;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndDate.Location = new System.Drawing.Point(658, 189);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(258, 38);
            this.textBoxEndDate.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Report Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(746, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "To be inserted as: yyyy-mm-dd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "To be inserted as: yyyy-mm-dd";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(572, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 47;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.listBoxReport);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCompletion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxProjectID);
            this.Controls.Add(LabelWelcome);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProjectID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCompletion;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.ListBox listBoxReport;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}