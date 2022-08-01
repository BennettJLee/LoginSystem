
namespace Deliv_login_223
{
    partial class AssignProgrammer
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
            this.LabelCreateTask = new System.Windows.Forms.Label();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTaskID = new System.Windows.Forms.ComboBox();
            this.comboBoxProgrammer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelCreateTask
            // 
            this.LabelCreateTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreateTask.Location = new System.Drawing.Point(0, 0);
            this.LabelCreateTask.Name = "LabelCreateTask";
            this.LabelCreateTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelCreateTask.Size = new System.Drawing.Size(567, 55);
            this.LabelCreateTask.TabIndex = 3;
            this.LabelCreateTask.Text = "Assign Programmers";
            this.LabelCreateTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAssign
            // 
            this.buttonAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssign.Location = new System.Drawing.Point(222, 408);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(118, 38);
            this.buttonAssign.TabIndex = 17;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Task ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Programmer:";
            // 
            // comboBoxTaskID
            // 
            this.comboBoxTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTaskID.FormattingEnabled = true;
            this.comboBoxTaskID.Location = new System.Drawing.Point(222, 113);
            this.comboBoxTaskID.Name = "comboBoxTaskID";
            this.comboBoxTaskID.Size = new System.Drawing.Size(257, 39);
            this.comboBoxTaskID.TabIndex = 22;
            // 
            // comboBoxProgrammer
            // 
            this.comboBoxProgrammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProgrammer.FormattingEnabled = true;
            this.comboBoxProgrammer.Location = new System.Drawing.Point(222, 157);
            this.comboBoxProgrammer.Name = "comboBoxProgrammer";
            this.comboBoxProgrammer.Size = new System.Drawing.Size(257, 39);
            this.comboBoxProgrammer.TabIndex = 23;
            // 
            // AssignProgrammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 480);
            this.Controls.Add(this.comboBoxProgrammer);
            this.Controls.Add(this.comboBoxTaskID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.LabelCreateTask);
            this.Name = "AssignProgrammer";
            this.Text = "AssignProgrammer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCreateTask;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTaskID;
        private System.Windows.Forms.ComboBox comboBoxProgrammer;
    }
}