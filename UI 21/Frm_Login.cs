using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Policy;
using System.Security.Cryptography;
using System.Collections;

namespace UI_21
{
    public partial class Frm_Login : Form
    {
        private static OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_graphix_users.mdb"); //establishing connection
        private static OleDbCommand cmd = new OleDbCommand(); // command to execute later
        private static OleDbDataAdapter da = new OleDbDataAdapter(); //data adapter


        public void Register_Click()  //register part there 
        {
            //You are going to have to find a hashing function. Its easy thats why i aint doing it
            // i dont fully understand what u r looking for. 
            // check login.cs
            string hashedPassword = Hashing.HashPassword(txtPassword.Text);//hash
            string regSQL = "INSERT INTO tbl_users ([username], [password]) VALUES ('" + txtUsername.Text + "', '" + hashedPassword + "')";//hash

            if (txtUsername.Text == "" && txtPassword.Text == "") //check if fields are empty
            {
                MessageBox.Show("Username and Password fields are empty.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "") //check if fields are empty
            {
                MessageBox.Show("Username or Password fields are empty.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open(); //open connection
                regSQL = "INSERT INTO tbl_users ([username], [password]) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')"; //the sql command to insert username and password
                cmd = new OleDbCommand(regSQL, con); //setting up the command and the connection
                try
                {
                    cmd.ExecuteNonQuery(); //execute the command
                    con.Close(); //close the connection 

                    //insert code for anything you want to do after registering an account

                    MessageBox.Show("Your account has been registered.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) //catch if cmd does not execute
                {
                    MessageBox.Show("Username has already been registered,", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear(); //clear the fields
                    txtPassword.Clear();
                    con.Close(); //closing the connection or else there is an error
                }
            }
        }

        private void Login_Click() //login part
        {

            string hashedPassword = Hashing.HashPassword(txtPassword.Text);//hash
            string logSQL = "SELECT * FROM tbl_users WHERE username=  '" + txtUsername.Text + "' and password= '" + hashedPassword + "'";//hash

            try
            {
                con.Open(); //connection open
                logSQL = "SELECT * FROM tbl_users WHERE username=  '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'"; //sql statement
                cmd = new OleDbCommand(logSQL, con); //execute the sql

                OleDbDataReader dr = cmd.ExecuteReader(); //use the reader to read through the usernames and passwords

                if (dr.Read() == true) //if the read is executed and the username and passwords match to one in the database
                {
                    //insert code here for anything after logging in

                }
                else //invalid login
                {
                    MessageBox.Show("Invalid username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Clear();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public Frm_Login()
        {
            InitializeComponent();
            bool Register = false;
        }

        private void txtLoginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            Register_Click();
        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            Login_Click();

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }
    }


}
