using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliv_login_223
{
    public partial class CreateIssue : Form
    {
        public CreateIssue()
        {
            InitializeComponent();

            SQL.selectQuery("select distinct TaskID from Task");

            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    comboBoxTaskID.Items.Add(SQL.read[0].ToString());
                }
            }
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            bool Created = false;
            int IssueID, TaskID;
            string Description, ReportDate, Priority, Status;

            IssueID = Convert.ToInt32(textBoxProgressID.Text);
            ReportDate = textBoxReportDate.Text.Trim();
            Description = textBoxDescription.Text.Trim();
            Priority = comboBoxPriority.SelectedItem.ToString();
            Status = comboBoxStatus.SelectedItem.ToString();
            TaskID = Convert.ToInt32(comboBoxTaskID.SelectedItem.ToString());

            if (IssueID != null && Description != "" && ReportDate != "" && Priority != "" && Status != "")
            {
                SQL.executeQuery("insert into Issue values(" + IssueID + ", '" + Description + "', '" + ReportDate + "', '" + Priority + "', '" + Status + "', " + TaskID + ")");
            }
            else
            {
                MessageBox.Show("Data was not entered properly");
            }
        }
    }
}
