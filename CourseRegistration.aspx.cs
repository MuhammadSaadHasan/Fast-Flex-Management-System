using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Activities.Statements;
using static System.Collections.Specialized.BitVector32;

public partial class CourseRegistration : System.Web.UI.Page
{
    string username;
    string Course = "";
    string section = "";
    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();
            if (!string.IsNullOrEmpty(username))
            {
                string sql = "SELECT CourseID, Name, CreditHours, TypeOfUser, Status FROM Course WHERE Status = 1";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    connection.Open();
                //    using (SqlCommand command = new SqlCommand(sql, connection))
                //    {
                //        using (SqlDataReader reader = command.ExecuteReader())
                //        {
                //            DataTable dataTable = new DataTable();
                //            dataTable.Load(reader);
                //            CoursesRepeater.DataSource = dataTable;
                //            CoursesRepeater.DataBind();
                //        }
                //    }
                //}
            }
        }
    }

    protected void CoursesRepeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e)
    {

        //CHECK STUDENTCOUNT
        //using (SqlConnection connection = new SqlConnection(connectionString))
        //{
        //    string sql = "SELECT COUNT(*) FROM Enrollments e " +
        //                  "JOIN Courses c ON e.CourseId = c.CourseId " +
        //                  "JOIN Sections s ON e.SectionId = s.SectionId " +
        //                  "WHERE c.CourseName = @courseName AND s.SectionName = @sectionName";

        //    using (SqlCommand command = new SqlCommand(sql, connection))
        //    {
        //        command.Parameters.AddWithValue("@courseName", Course);
        //        command.Parameters.AddWithValue("@sectionName", section);

        //        connection.Open();
        //        int count = (int)command.ExecuteScalar();
        //        connection.Close();
        //    }
        //}
    }


























    protected void Marks_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("Marks.aspx");
            }
        }
    }
    protected void Attendance_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("Attendance.aspx");
            }
        }

    }
    protected void CourseRegistration_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("CourseRegistration.aspx");
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
    protected void Transcript_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("Transcript.aspx");
            }
        }
    }
    protected void FeedBack_Click(object sender, EventArgs e)
    {

        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("Feedback.aspx");
            }
        }


    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        foreach (RepeaterItem item in CoursesRepeater.Items)
        {
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                CheckBox selectCheckbox = (CheckBox)item.FindControl("Select");
                DropDownList sectionDropdown = (DropDownList)item.FindControl("Section");
                if (selectCheckbox != null && selectCheckbox.Checked)
                {
                    string courseID = ((HiddenField)item.FindControl("CourseIDHidden")).Value;

                    string sectionValue = sectionDropdown.SelectedValue;
                }
            }
        }
    }

}
