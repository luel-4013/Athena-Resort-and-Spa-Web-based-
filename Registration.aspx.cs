﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        String queryStr;

        protected void Page_Load(object sender, EventArgs e)
        {
            vvcvghbnjmknbvcvbhjnm
        }
        protected void registerEventMethod(object sender, EventArgs e)
        {
            registerUser();
        }
        private void registerUser()
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebConnString"].ToString();
             conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "INSERT INTO misge.reserve(Fname,Lname, Email,Number,NumP,arrTime )" + "VALUES('" + firstnameTextBox.Text + "','" + lastnameTextBox.Text + "','" + emailTextBox.Text + "','" + numberTextBox.Text + "','" + numTextBox1.Text + "','" + arrTextBox.Text + "')";
           
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

            cmd.ExecuteReader();nnnnnnnnnnnnnnnn
            conn.Close();
        }
    }
}  