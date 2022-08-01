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
    public partial class ViewIssues : Form
    {
        public ViewIssues()
        {
            InitializeComponent();

			SQL.selectQuery("Select * from Issue");

			//Check	that	there	is	something	to	write	into	list	box
			if (SQL.read.HasRows)
			{
				int IssueID, TaskID;
				string description, reportDate, priority, status;
				//loop	through	each	table	row	from	the	database
				while (SQL.read.Read())
				{
					//get	the	data	values	and	store	them	in	variables
					IssueID = int.Parse(SQL.read[0].ToString());
					description = SQL.read[1].ToString();
					reportDate = SQL.read[2].ToString();
					priority = SQL.read[3].ToString();
					//display	each	of	the	rows	in a nice way
					status = SQL.read[4].ToString();
					listBoxIssues.Items.Add("Issue ID: " + IssueID + ", Description: " + description + ", Report Date: " + reportDate + ", Priority: " + priority + ", Status: " + status);
				}
			}
			else //where	it	doesnt	have	any	successful	searches
			{
				listBoxIssues.Items.Add("There are no Issues updates so far");
			}
		}
    }
}
