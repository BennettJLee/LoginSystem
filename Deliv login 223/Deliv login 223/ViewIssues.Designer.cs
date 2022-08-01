
namespace Deliv_login_223
{
    partial class ViewIssues
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
            this.listBoxIssues = new System.Windows.Forms.ListBox();
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxIssues
            // 
            this.listBoxIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIssues.FormattingEnabled = true;
            this.listBoxIssues.ItemHeight = 18;
            this.listBoxIssues.Location = new System.Drawing.Point(46, 67);
            this.listBoxIssues.Name = "listBoxIssues";
            this.listBoxIssues.Size = new System.Drawing.Size(739, 346);
            this.listBoxIssues.TabIndex = 4;
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcome.Location = new System.Drawing.Point(0, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelWelcome.Size = new System.Drawing.Size(836, 55);
            this.LabelWelcome.TabIndex = 5;
            this.LabelWelcome.Text = "Issues";
            this.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 480);
            this.Controls.Add(this.LabelWelcome);
            this.Controls.Add(this.listBoxIssues);
            this.Name = "ViewIssues";
            this.Text = "ViewIssues";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIssues;
        private System.Windows.Forms.Label LabelWelcome;
    }
}