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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();

            SQL.selectQuery("select distinct PID from Project");

            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    comboBoxProjectID.Items.Add(SQL.read[0].ToString());
                }
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            int TaskID;
            string ProjectID, startDate, endDate, reportDate, completion, StartDate, EndDate;

            ProjectID = comboBoxProjectID.SelectedItem.ToString();
            completion = comboBoxCompletion.SelectedItem.ToString();
            startDate = textBoxStartDate.Text.Trim();
            EndDate = textBoxEndDate.Text.Trim();

            if (startDate == "" && EndDate == "")
            {
                if (ProjectID == "No specification")
                {
                    if ((completion == "Complete") || (completion == "Incomplete"))
                    {
                        SQL.selectQuery("select distinct p.PID, p.startdate, p.enddate, t.TaskID, pr.reportDate, t.completion from Project p, Task t, Progress pr where t.PID = p.PID and t.TaskID = pr.TaskID and t.completion = '" + completion + "'");

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                ProjectID = SQL.read[0].ToString();
                                startDate = SQL.read[1].ToString();
                                endDate = SQL.read[2].ToString();
                                TaskID = Convert.ToInt32(SQL.read[3].ToString());
                                reportDate = SQL.read[4].ToString();
                                completion = SQL.read[5].ToString();

                                listBoxReport.Items.Add("Project ID: " + ProjectID + ", Project start date: " + startDate + ", Project end date: " + endDate + ", Task ID: " + TaskID + ", Report date: " + reportDate + ", Task Completion: " + completion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no data with these specifications");
                        }
                    }
                    else if (completion == "No specification")
                    {
                        SQL.selectQuery("select distinct p.PID, p.startdate, p.enddate, t.TaskID, pr.reportDate, t.completion from Project p, Task t, Progress pr where t.PID = p.PID and t.TaskID = pr.TaskID");

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                ProjectID = SQL.read[0].ToString();
                                startDate = SQL.read[1].ToString();
                                endDate = SQL.read[2].ToString();
                                TaskID = Convert.ToInt32(SQL.read[3].ToString());
                                reportDate = SQL.read[4].ToString();
                                completion = SQL.read[5].ToString();

                                listBoxReport.Items.Add("Project ID: " + ProjectID + ", Project start date: " + startDate + ", Project end date: " + endDate + ", Task ID: " + TaskID + ", Report date: " + reportDate + ", Task Completion: " + completion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no data with these specifications");
                        }
                    }
                }
                else
                {
                    if (completion == "Complete" || completion == "Incomplete")
                    {
                        SQL.selectQuery("select distinct p.PID, p.startdate, p.enddate, t.TaskID, pr.reportDate, t.completion from Project p, Task t, Progress pr where t.PID = p.PID and t.TaskID = pr.TaskID and p.PID = " + ProjectID + " and t.completion = '" + completion + "'");

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                ProjectID = SQL.read[0].ToString();
                                startDate = SQL.read[1].ToString();
                                endDate = SQL.read[2].ToString();
                                TaskID = Convert.ToInt32(SQL.read[3].ToString());
                                reportDate = SQL.read[4].ToString();
                                completion = SQL.read[5].ToString();

                                listBoxReport.Items.Add("Project ID: " + ProjectID + ", Project start date: " + startDate + ", Project end date: " + endDate + ", Task ID: " + TaskID + ", Report date: " + reportDate + ", Task Completion: " + completion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no data with these specifications");
                        }
                    }
                    else if (completion == "No specification")
                    {
                        SQL.selectQuery("select distinct p.PID, p.startdate, p.enddate, t.TaskID, pr.reportDate, t.completion from Project p, Task t, Progress pr where t.PID = p.PID and t.TaskID = pr.TaskID and p.PID = " + ProjectID);

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                ProjectID = SQL.read[0].ToString();
                                startDate = SQL.read[1].ToString();
                                endDate = SQL.read[2].ToString();
                                TaskID = Convert.ToInt32(SQL.read[3].ToString());
                                reportDate = SQL.read[4].ToString();
                                completion = SQL.read[5].ToString();

                                listBoxReport.Items.Add("Project ID: " + ProjectID + ", Project start date: " + startDate + ", Project end date: " + endDate + ", Task ID: " + TaskID + ", Report date: " + reportDate + ", Task Completion: " + completion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no data with these specifications");
                        }
                    }
                }
            }
            else
            {
                if (ProjectID == "No specification")
                {
                    if (completion == "Complete" || completion == "Incomplete")
                    {
                        SQL.selectQuery("select distinct p.PID, p.startdate, p.enddate, t.TaskID, pr.reportDate, t.completion from Project p, Task t, Progress pr where t.PID = p.PID and t.TaskID = pr.TaskID and t.completion = '" + completion + "' and pr.reportDate between '" + startDate + "' and '" + EndDate + "' order by p.PID");

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                ProjectID = SQL.read[0].ToString();
                                startDate = SQL.read[1].ToString();
                                endDate = SQL.read[2].ToString();
                                TaskID = Convert.ToInt32(SQL.read[3].ToString());
                                reportDate = SQL.read[4].ToString();
                                completion = SQL.read[5].ToString();

                                listBoxReport.Items.Add("Project ID: " + ProjectID + ", Project start date: " + startDate + ", Project end date: " + endDate + ", Task ID: " + TaskID + ", Report date: " + reportDate + ", Task Completion: " + completion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no data with these specifications");
                        }
                    }
                    else if (completion == "No specification")
                    {
                        SQL.selectQuery("select distinct p.PID, p.startdate, p.enddate, t.TaskID, pr.reportDate, t.completion from Project p, Task t, Progress pr where t.PID = p.PID and t.TaskID = pr.TaskID and pr.reportDate between '" + startDate + "' and '" + EndDate + "' order by p.PID");

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                ProjectID = SQL.read[0].ToString();
                                startDate = SQL.read[1].ToString();
                                endDate = SQL.read[2].ToString();
                                TaskID = Convert.ToInt32(SQL.read[3].ToString());
                                reportDate = SQL.read[4].ToString();
                                completion = SQL.read[5].ToString();

                                listBoxReport.Items.Add("Project ID: " + ProjectID + ", Project start date: " + startDate + ", Project end date: " + endDate + ", Task ID: " + TaskID + ", Report date: " + reportDate + ", Task Completion: " + completion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no data with these specifications");
                        }
                    }
                }
                else
                {
                    if (completion == "Complete" || completion == "Incomplete")
                    {
                        SQL.selectQuery("select distinct p.PID, p.startdate, p.enddate, t.TaskID, pr.reportDate, t.completion from Project p, Task t, Progress pr where t.PID = p.PID and t.TaskID = pr.TaskID and p.PID = " + ProjectID + " and t.completion = '" + completion + "' and pr.reportDate between '" + startDate + "' and '" + EndDate + "' order by p.PID");

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                ProjectID = SQL.read[0].ToString();
                                startDate = SQL.read[1].ToString();
                                endDate = SQL.read[2].ToString();
                                TaskID = Convert.ToInt32(SQL.read[3].ToString());
                                reportDate = SQL.read[4].ToString();
                                completion = SQL.read[5].ToString();

                                listBoxReport.Items.Add("Project ID: " + ProjectID + ", Project start date: " + startDate + ", Project end date: " + endDate + ", Task ID: " + TaskID + ", Report date: " + reportDate + ", Task Completion: " + completion );
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no data with these specifications");
                        }
                    }
                    else if (completion == "No specification")
                    {
                        SQL.selectQuery("select distinct p.PID, p.startdate, p.enddate, t.TaskID, pr.reportDate, t.completion from Project p, Task t, Progress pr where t.PID = p.PID and t.TaskID = pr.TaskID and p.PID = " + ProjectID + " and pr.reportDate between '" + startDate + "' and '" + EndDate + "' order by p.PID");

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                ProjectID = SQL.read[0].ToString();
                                startDate = SQL.read[1].ToString();
                                endDate = SQL.read[2].ToString();
                                TaskID = Convert.ToInt32(SQL.read[3].ToString());
                                reportDate = SQL.read[4].ToString();
                                completion = SQL.read[5].ToString();

                                listBoxReport.Items.Add("Project ID: " + ProjectID + ", Project start date: " + startDate + ", Project end date: " + endDate + ", Task ID: " + TaskID + ", Report date: " + reportDate + ", Task Completion: " + completion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no data with these specifications");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxReport.Items.Clear();
        }
    }
}
