using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminHomePage : System.Web.UI.Page
{

    string username;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }


































    protected void ManageFaculty_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("ManageFaculty.aspx");
            }
        }
    }

    protected void ManageStudents_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("ManageStudents.aspx");
            }
        }
    }

    protected void CourseAllocation_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("CourseAllocation.aspx");
            }
        }
    }

    protected void Section_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("Section.aspx");
            }
        }
    }

    protected void CoursesOffered_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("CourseOffered.aspx");
            }
        }
    }

    protected void SignOut_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("Login.aspx");
            }
        }
    }

    protected void AddFaculty_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("AddFcaulty.aspx");
            }
        }
    }

    protected void AddStudent_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) 
        {
            username = Session["username"].ToString(); 

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; 
                Response.Redirect("AddStudent.aspx");
            }
        }
    }

    protected void SearchButton_Click(object sender, EventArgs e)
    {
        string rollNo = TextBoxPassword.Text.Trim();

        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True"))
        {
            conn.Open();
            string query = "SELECT Username from StudentInfo where RollNo = @rollNo";

            using (SqlCommand cm = new SqlCommand(query, conn))
            {
                cm.Parameters.AddWithValue("@rollNo", rollNo);

                SqlDataReader res = cm.ExecuteReader();

                if (!res.HasRows)
                {
                    LabelMessage.Text = "No such username found or incorrect user type";
                }
                else
                {
                    //if (TypeOfUser == "Student")
                    //{
                    while (res.Read())
                    {
                        Session["username"] = res["Username"].ToString(); // Storing username in Session variable
                            res.Close();
                            cm.Dispose();
                            conn.Close();
                            Response.Redirect("ManageStudents.aspx");
             

                    }
                    return;
                }

                res.Close();
                cm.Dispose();
            }

            conn.Close();
        }
    }
}