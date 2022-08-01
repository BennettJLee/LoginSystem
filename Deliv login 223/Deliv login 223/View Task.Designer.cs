
namespace Deliv_login_223
{
    partial class View_Task
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
            this.listBoxProgress = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcome.Location = new System.Drawing.Point(0, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelWelcome.Size = new System.Drawing.Size(817, 55);
            this.LabelWelcome.TabIndex = 2;
            this.LabelWelcome.Text = "Progress";
            this.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxProgress
            // 
            this.listBoxProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProgress.FormattingEnabled = true;
            this.listBoxProgress.ItemHeight = 18;
            this.listBoxProgress.Location = new System.Drawing.Point(62, 76);
            this.listBoxProgress.Name = "listBoxProgress";
            this.listBoxProgress.Size = new System.Drawing.Size(692, 346);
            this.listBoxProgress.TabIndex = 3;
            // 
            // View_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 480);
            this.Controls.Add(this.listBoxProgress);
            this.Controls.Add(this.LabelWelcome);
            this.Name = "View_Task";
            this.Text = "View_Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelWelcome;
        private System.Windows.Forms.ListBox listBoxProgress;
    }
}