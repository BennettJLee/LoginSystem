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
    public partial class RecordTask : Form
    {
        public RecordTask()
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
            int ProgressID, TaskID;
            string Description, ReportDate;

            ProgressID = Convert.ToInt32(textBoxProgressID.Text);
            Description = textBoxDescription.Text.Trim();
            ReportDate = textBoxReportDate.Text.Trim();
            TaskID = Convert.ToInt32(comboBoxTaskID.SelectedIndex.ToString());

            if (ProgressID != null && Description != "" && ReportDate != "" && TaskID != null)
            {
                SQL.executeQuery("insert into Progress values(" + ProgressID + ", '" + Description + "', '" + ReportDate + "', " + TaskID + ")");
            }
            else
            {
                MessageBox.Show("Data was not entered properly");
            }
        }
    }
}
