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
    public partial class AssignProgrammer : Form
    {
        public AssignProgrammer()
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

            SQL.selectQuery("select distinct p_username from Programmer");

            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    comboBoxProgrammer.Items.Add(SQL.read[0].ToString());
                }
            }
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            string TaskID, Programmer;

            TaskID = comboBoxTaskID.SelectedItem.ToString();
            Programmer = comboBoxProgrammer.SelectedItem.ToString();

            if (comboBoxTaskID.SelectedItem != null)
            {
                if (comboBoxProgrammer.SelectedItem != null)
                {
                    SQL.executeQuery("insert into WorksOn values(" + TaskID + ", " + Programmer + ")");
                    MessageBox.Show("Data has been inserted");
                }
            }
            else
            {
                MessageBox.Show("Data was not entered properly");
            }
            
        }
    }
}
