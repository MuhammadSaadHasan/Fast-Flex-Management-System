using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transcript : System.Web.UI.Page
{
    string username;
    protected void Page_Load(object sender, EventArgs e){
        if (!IsPostBack){
            if (Session["username"] != null){
                username = Session["username"].ToString();
                if (!string.IsNullOrEmpty(username)){
                    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString)){
                        connection.Open();
                        string sql = "SELECT PersonalInfo.Name FROM PersonalInfo INNER JOIN StudentInfo ON PersonalInfo.RollNo = StudentInfo.RollNo WHERE StudentInfo.Username = @username";
                        using (SqlCommand command = new SqlCommand(sql, connection)){
                            command.Parameters.AddWithValue("@username", username);
                            using (SqlDataReader reader = command.ExecuteReader()){
                                while (reader.Read()){
                                    NameLabel.Text = reader.GetString(0);
                                }
                            }
                        }
                        sql = "SELECT StudentInfo.RollNo FROM StudentInfo WHERE StudentInfo.Username = @username";
                        using (SqlCommand command = new SqlCommand(sql, connection)){
                            command.Parameters.AddWithValue("@username", username);
                            using (SqlDataReader reader = command.ExecuteReader()){
                                while (reader.Read()){
                                    RollNoLabel.Text = reader.GetString(0);
                                }
                            }
                        }
                        sql = "SELECT StudentInfo.Batch FROM StudentInfo WHERE StudentInfo.Username = @username";
                        using (SqlCommand command = new SqlCommand(sql, connection)){
                            command.Parameters.AddWithValue("@username", username);
                            using (SqlDataReader reader = command.ExecuteReader()){
                                while (reader.Read()){
                                    BatchLabel.Text = reader.GetInt32(0).ToString();
                                }
                            }
                        }
                    }
                }
            }
        }
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

}