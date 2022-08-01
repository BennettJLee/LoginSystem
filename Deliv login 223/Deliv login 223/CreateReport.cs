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
    public partial class CreateReport : Form
    {
        public CreateReport()
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
            int ProjectID;
            string Programmer, Unresolved, Complete, Incomplete;

            ProjectID = Convert.ToInt32(comboBoxTaskID.SelectedItem.ToString());

            SQL.selectQuery("Select t.PID, wo.p_username From  WorksOn wo, Task t where wo.TaskID = t.TaskID Group by t.PID, wo.p_username having t.PID = " + ProjectID);

            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    ProjectID = Convert.ToInt32(SQL.read[0].ToString());
                    Programmer = SQL.read[1].ToString();



                    listBoxReport.Items.Add("Project ID: " + ProjectID + ", Assigned Programmer: " + Programmer);
                }
            }

            SQL.selectQuery("select count(status) as 'unresolved' from Issue where status = 'Unresolved'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    Unresolved = SQL.read[0].ToString();
                    listBoxReport.Items.Add("Unresolved Issues: " + Unresolved);
                }
            }

            SQL.selectQuery("select count(completion) as 'Incompleted' from Task where completion = 'Complete'");

            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    Complete = SQL.read[0].ToString();
                    listBoxReport.Items.Add("Completed Tasks: " + Complete);
                }
            }

            SQL.selectQuery("select count(completion) as 'Incompleted' from Task where completion = 'Incomplete'");

            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    Incomplete = SQL.read[0].ToString();
                    listBoxReport.Items.Add("Incomplete: " + Incomplete);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxReport.Items.Clear();
        }
    }
}
