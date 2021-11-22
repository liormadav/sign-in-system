using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SignIn2
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {
                string errorMessage;
                string fileName = "Database.mdf";//משתנה עבור שם בסיס הנתונים
                string tableName = "UserTable";//משתנה עבור שם הטבלה

                message.Visible = false;

                string kita = kita1.SelectedItem.Value;

                //קליטת הנתונים השונים מהטופס לתוך משתנים
                string fName = Request.Form["fName"];
                string lName = Request.Form["lName"];
                string userName = Request.Form["userName"];
                string email = Request.Form["email"];
                string pass = Request.Form["password"];
                string phone = Request.Form["phone"];

                if (!email.EndsWith("@ronarad.org"))
                {
                    errorMessage = "you need to enter your school's email";
                    message.Text = errorMessage;
                    message.Visible = true;
                }
                else if(fName == null || lName == null || userName == null || email == null || pass == null || phone == null)
                {
                    errorMessage = "you need to fill all the details !";
                    message.Text = errorMessage;
                    message.Visible = true;
                }
                else
                {
                    //הכנסת הנתונים לתוך בסיס הנתונים
                    //חשוב מאוד לוודא ששם הטבלה + המשתנים הכתובים תואם את השם המצוי
                    string sqlInsert = "insert into UserTable (fName,lName,userName,email,password,phone,kita)" + " values(N'" + fName + "', N'" + lName + "', N'" + userName + "', '" + email + "', N'"
                        + pass + "' , '" + phone + "'," + "N'" + kita + "') ";
                    Helper.DoQuery(fileName, sqlInsert);
                    Response.Redirect("SignIn.aspx");// open the page when data stored
                    Response.End();

                }





            }
        }
    }
}