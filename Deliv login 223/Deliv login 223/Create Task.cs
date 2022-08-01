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
    public partial class Create_Task : Form
    {
        public Create_Task()
        {
            InitializeComponent();

            SQL.selectQuery("select distinct PID from Project");
           
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    comboBoxProjects.Items.Add(SQL.read[0].ToString());
                }
            }


        }
        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            int TaskID;
            string Description, priority, startdate, completion, projectID;

            TaskID = Convert.ToInt32(textBoxTaskID.Text);
            Description = textBoxDescription.Text.Trim();
            priority = comboBox1.SelectedItem.ToString();
            startdate = textBoxStartDate.Text.Trim();
            completion = comboBoxCompletion.SelectedItem.ToString();
            projectID = comboBoxProjects.SelectedItem.ToString();

            if (TaskID != null && Description != "" && priority != "" && startdate != "" && completion != "" && projectID != null)
            {

                SQL.executeQuery("insert into Task values(" + TaskID + ", '" + Description + "', '" + priority + "', '" + startdate + "', '" + completion + "', " + projectID + ")");

            }
            else
            {
                MessageBox.Show("Data was not entered properly");
            }
        }
    }
}
