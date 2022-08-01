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
    public partial class LoginScreen : Form
    {
        /// <summary>
        /// This is the first method called when the program form loads.
        /// </summary>
        public LoginScreen()
        {
            InitializeComponent();
            //This line of code allows us to obscure the password visually and limit the max chars in textbox
            textBoxPassword.PasswordChar = '*';     //password character to hide password characters
            textBoxPassword.MaxLength = 20;         //max textbox character count
        }


        /// <summary>
        /// Clicked when user decides they are ready to log in, 
        /// Will get username and password, use that to query database and check that username and password are correct.
        /// A message box will be used to state whether or not we logged in successfully
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Variables to be used: 1x bool, 4x string
            bool loggedIn = false;
            string username = "", name = "", password = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUsername.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }

            //(1) GET the username and password from the text boxes, is good to put them in a try catch
            try
            {
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }

            //SELECT statement getting all data from manager
            //Select query from manager table
            SQL.selectQuery("select * from manager");

            //read table rows
            if (SQL.read.HasRows)
            {
                //cycle through all users checking if the username exists and if the password matches
                while (SQL.read.Read())
                {
                    //SQL.read[i]: i=0 is UserName ... i=4 is Password
                    if (username.Equals(SQL.read[0].ToString()) &&
                    password.Equals(SQL.read[1].ToString()))

                    {
                        //Username and Password correct, get fname, lname to display

                        loggedIn = true;
                        name = SQL.read[2].ToString();
                        //if logged in display a success message
                        if (loggedIn)
                        {
                            //message stating we logged in good
                            Hide();
                            Manager ManagerPage = new Manager(name);
                            ManagerPage.ShowDialog();
                            Close();

                            break; //stops the while loop since they have logged in
                        }
                        else
                        {
                            //message stating we couldn't log in
                            MessageBox.Show("Login attempt unsuccessful, Username or Password may be incorrect");
                            textBoxUsername.Focus();
                            return;
                        }

                    }
                    
                }
            }

            //SELECT statement getting all data from programmer
            //Select query from programmer table
            SQL.selectQuery("select * from programmer");

            //read table rows
            if (SQL.read.HasRows)
            {
                //cycle through all users checking if the username exists and if the password matches
                while (SQL.read.Read())
                {
                    //SQL.read[i]: i=0 is UserName ... i=4 is Password, this will break once all rows are read
                    if (username.Equals(SQL.read[0].ToString()) &&
                    password.Equals(SQL.read[1].ToString()))

                    {
                        //Username and Password correct, get fname, lname to display

                        loggedIn = true;
                        name = SQL.read[2].ToString();
                        //if logged in display a success message
                        
                        if (loggedIn)
                        {
                            //message stating we logged in good
                            Hide();
                            Programmer ProgrammerPage = new Programmer(name);
                            ProgrammerPage.ShowDialog();
                            Close();

                            break; //stops the while loop since they have logged in
                        }
                        else
                        {
                            //message stating we couldn't log in
                            MessageBox.Show("Login attempt unsuccessful, Username or Password may be incorrect");
                            textBoxUsername.Focus();
                            return;
                        }
                    }

                }
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful, Username or Password may be incorrect");
                textBoxUsername.Focus();
                return;
            }
        }

        /// <summary>
        /// Clears the text boxes on the page focuses on top one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            initialiseTextBoxes();
        }

        /// <summary>
        /// Initialises all textboxes to blank text
        /// Re focus to first text box
        /// </summary>
        public void initialiseTextBoxes()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            //makes next place user types the text box
            textBoxUsername.Focus();
        }
    }
}
