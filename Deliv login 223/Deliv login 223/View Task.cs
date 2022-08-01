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
    public partial class View_Task : Form
    {
        public View_Task()
        {
            InitializeComponent();

			SQL.selectQuery("Select * from Progress");

			//Check	that	there	is	something	to	write	into	list	box
			if (SQL.read.HasRows)
			{
				int ProgressID, TaskID;
				string description, reportDate;
				//loop	through	each	table	row	from	the	database
				while (SQL.read.Read())
				{
					//get	the	data	values	and	store	them	in	variables
					ProgressID = int.Parse(SQL.read[0].ToString());
					description = SQL.read[1].ToString();
					reportDate = SQL.read[2].ToString();
					TaskID = int.Parse(SQL.read[3].ToString());
					//display	each	of	the	rows	in	a	nice	way
					listBoxProgress.Items.Add("Progress ID: " + ProgressID + ", Description: " + description + ", Report Date: " + reportDate + ", Task ID: " + TaskID);
				}
			}
			else //where	it	doesnt	have	any	successful	searches
			{
				listBoxProgress.Items.Add("There is no Progress updates so far");
			}
		}
    }
}
