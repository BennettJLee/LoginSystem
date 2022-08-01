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
    public partial class Manager : Form
    {
        public Manager(string name)
        {
            InitializeComponent();
            LabelWelcome.Text = "Welcome " + name;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginScreen LoginPage = new LoginScreen();
            LoginPage.ShowDialog();
            Close();
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            Create_Task CreateTaskPage = new Create_Task();
            CreateTaskPage.ShowDialog();
        }

        private void buttonAssignPro_Click(object sender, EventArgs e)
        {
            AssignProgrammer AssignProgrammerPage = new AssignProgrammer();
            AssignProgrammerPage.ShowDialog();
        }

        private void buttonViewTask_Click(object sender, EventArgs e)
        {
            View_Task ViewTaskPage = new View_Task();
            ViewTaskPage.ShowDialog();
        }

        private void buttonRecordTask_Click(object sender, EventArgs e)
        {
            RecordTask RecordTaskPage = new RecordTask();
            RecordTaskPage.ShowDialog();
        }

        private void buttonViewProjectIssues_Click(object sender, EventArgs e)
        {
            ViewIssues ViewIssuesPage = new ViewIssues();
            ViewIssuesPage.ShowDialog();
        }

        private void buttonCreateProjectIssues_Click(object sender, EventArgs e)
        {
            CreateIssue CreateIssuePage = new CreateIssue();
            CreateIssuePage.ShowDialog();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            CreateReport CreateReportPage = new CreateReport();
            CreateReportPage.ShowDialog();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            Statistics statisticsPage = new Statistics();
            statisticsPage.ShowDialog();
        }
    }
}
