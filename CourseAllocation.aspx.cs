using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CourseAllocation : System.Web.UI.Page
{
    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";

    string username;


    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "SELECT TI.Name AS Teacher_Name, C.Name AS Course_Nam FROM TeachersInfo TI JOIN CourseTeachers CT ON TI.TeacherID = CT.TeacherID JOIN Course C ON CT.CourseID = C.CourseID;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    CourseRepeater.DataSource = dt;
                    CourseRepeater.DataBind();
                }
            }
        }
    }


    protected void display(string Course)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "SELECT COUNT(*) FROM Enrollments e " +
                         "JOIN Courses c ON e.CourseId = c.CourseId " +
                         "WHERE c.CourseName = @courseName";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@CourseID", Course);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();
            }
        }




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









}