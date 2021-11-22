using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class SignIn : System.Web.UI.Page
    {
        public string errorMessage;
        public string checkIfFirstNameExist;
        public string checkIfFirstAndLastNameExistTogether;

        public string checkIfPasswordExist;
        public string checkIfFirstNameLastNameAndPaswwordExistTogether;
        string checkAll;
        string checkuserNameAndPassword;
        protected void Page_Load(object sender, EventArgs e)
        {
            message.Visible = false;
            if (Request.Form["Submit"] != null)
            {

                if (Request.Form["userName"] != "")
                {
                    Session["userName"] = Request.Form["userName"];
                }

                string dataBaseName = "Database1.mdf";
                string tableName = "UserTable";

                string userName = Request.Form["userName"];
                string fName = Request.Form["fName"];
                string lName = Request.Form["lName"];
                string password = Request.Form["password"];
                string email = Request.Form["email"];

                checkIfFirstNameExist = "SELECT * FROM " + tableName + " WHERE fName = N'" + fName + "'";
                checkIfPasswordExist = "SELECT * FROM " + tableName + " WHERE password = N'" + password + "'";
                checkIfFirstAndLastNameExistTogether = "SELECT * FROM " + tableName + " WHERE fName = N'" + fName + "' AND lName = N'" + lName + "'";
                checkIfFirstNameLastNameAndPaswwordExistTogether = "SELECT * FROM " + tableName + " WHERE fName = N'" + fName + "' AND lName = N'" + lName + " AND password = N'" + password + "'"; 
                checkAll = "SELECT * FROM " + tableName + " WHERE fName = N'" + fName + "' AND lName = N'" + lName + "' AND email = N'" + email + "' AND password = N'" + password + "'";
                checkuserNameAndPassword = "SELECT * FROM " + tableName + " WHERE userName = N'" + userName + "' AND password = N'" + password + "'";

                // if i want i could check what the wrong details are and delete only them, if password is wrong
                // then the input (userName) = userName; the code says clear the password's input and save the username value
                // and so as the other (if the userName are wrong)
                // I can do that by create 2 varibales one to check the password and the other to check the username and i think i'll know how to take it from there
                if (!Helper.IsExist(dataBaseName, checkuserNameAndPassword))
                {
                    errorMessage = "No match with the details";
                    message.Text = errorMessage;
                    message.Visible = true;
                }

                //if (!Helper.IsExist(dataBaseName, checkIfFirstNameExist))
                //{
                //    errorMessage = "first name " + fName + " not exist";
                //    message.Text = errorMessage;
                //    message.Visible = true;
                //}
                //else if (!Helper.IsExist(dataBaseName, checkAll))
                //{
                //    errorMessage = "no match with the details";
                //    message.Text = errorMessage;
                //    message.Visible = true;
                //}
                else
                {
                    Response.Redirect("welcome.aspx");// open the page when log in succesful
                    Response.End();
                }
            }
        }
    }
}
