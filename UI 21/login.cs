using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Security.Cryptography;
using Microsoft.Office.Interop.Excel;

namespace UI_21
{
    class Hashing//hash start
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }// hash end 
    class login
    {
        //created temporary text boxes
        System.Windows.Forms.TextBox txtRegisterPassword = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox txtRegisterUsername = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox txtLoginPassword = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox txtLoginUsername = new System.Windows.Forms.TextBox();


        private static OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_graphix_users.mdb"); //establishing connection
        private static OleDbCommand cmd = new OleDbCommand(); // command to execute later
        private static OleDbDataAdapter da = new OleDbDataAdapter(); //data adapter

        private void btnRegister_Click(object sender, EventArgs e)  //register part there 
        {
            string hashedPassword = Hashing.HashPassword(txtRegisterPassword.Text);//hash
            string regSQL = "INSERT INTO tbl_users ([username], [password]) VALUES ('" + txtRegisterUsername.Text + "', '" + hashedPassword + "')";//hash

            if (txtRegisterUsername.Text == "" && txtRegisterPassword.Text == "") //check if fields are empty
            {
                MessageBox.Show("Username and Password fields are empty.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtRegisterUsername.Text == "" || txtRegisterPassword.Text == "") //check if fields are empty
            {
                MessageBox.Show("Username or Password fields are empty.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open(); //open connection
                regSQL = "INSERT INTO tbl_users ([username], [password]) VALUES ('" + txtRegisterUsername.Text + "', '" + txtRegisterPassword.Text + "')"; //the sql command to insert username and password
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
                    txtRegisterUsername.Clear(); //clear the fields
                    txtRegisterPassword.Clear();
                    con.Close(); //closing the connection or else there is an error
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) //login part
        {

            string hashedPassword = Hashing.HashPassword(txtLoginPassword.Text);//hash
            string logSQL = "SELECT * FROM tbl_users WHERE username=  '" + txtLoginUsername.Text + "' and password= '" + hashedPassword + "'";//hash

            try
            {
                con.Open(); //connection open
                logSQL = "SELECT * FROM tbl_users WHERE username=  '" + txtLoginUsername.Text + "' and password= '" + txtLoginPassword.Text + "'"; //sql statement
                cmd = new OleDbCommand(logSQL, con); //execute the sql

                OleDbDataReader dr = cmd.ExecuteReader(); //use the reader to read through the usernames and passwords

                if (dr.Read() == true) //if the read is executed and the username and passwords match to one in the database
                {
                    //insert code here for anything after logging in

                }
                else //invalid login
                {
                    MessageBox.Show("Invalid username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoginPassword.Clear();
                    txtLoginUsername.Clear();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}

