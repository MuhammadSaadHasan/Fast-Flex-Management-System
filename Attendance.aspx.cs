using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Activities.Statements;
using System.Runtime.ConstrainedExecution;
using System.Activities.Expressions; 
using System.Web.UI.DataVisualization.Charting;


public partial class Attendance : System.Web.UI.Page
{
    string username;
    public int PresentNo { get; set; }
    public int AbsentNo { get; set; }
    public int TotalClasses { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["username"] != null)
            {
                username = Session["username"].ToString();
                if (!string.IsNullOrEmpty(username))
                {
                    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";
                    string sql = "SELECT E.CourseID FROM Enrollments E JOIN Users U ON E.Username = U.Username WHERE U.Username = @username";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                int labelCounter = 1;
                                while (reader.Read())
                                {
                                    string CourseID = reader.GetString(0);
                                    if (labelCounter == 1) { Course1Label.Text = CourseID; }
                                    else if (labelCounter == 2) { Course2Label.Text = CourseID; }
                                    else if (labelCounter == 3) { Course3Label.Text = CourseID; }
                                    else if (labelCounter == 4) { Course4Label.Text = CourseID; }
                                    else if (labelCounter == 5) { Course5Label.Text = CourseID; }
                                    else if (labelCounter == 6) { Course6Label.Text = CourseID; }
                                    labelCounter++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }



    protected void display(string Course)
    {
        string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";
        string sql = "SELECT Name FROM Course WHERE CourseID = @Course";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Course", Course);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CourseNameLabel.Text = reader.GetString(0);
                    }
                }
            }
        }

        if (Session["username"] != null)
        {
            username = Session["username"].ToString();
            if (!string.IsNullOrEmpty(username))
            {
                sql = "SELECT SI.RollNo, SI.Username, E.CourseID, A.Date, A.Duration, A.AttendanceID, A.Presence " +
                      "FROM StudentInfo SI " +
                      "INNER JOIN Enrollments E ON SI.Username = E.Username " +
                      "INNER JOIN Attendance A ON E.CourseID = A.CourseID " +
                      "WHERE SI.Username = @username AND E.CourseID = @Course";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@Course", Course);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            AttendanceRepeater.DataSource = dataTable;
                            AttendanceRepeater.DataBind();
                        }
                    }
                }
            }
        }

        connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";

        string sqlPresent = "SELECT COUNT(*) " +
                    "FROM Attendance A " +
                    "JOIN Enrollments E ON A.CourseID = E.CourseID " +
                    "JOIN StudentInfo SI ON E.Username = SI.Username " +
                    "WHERE SI.Username = @username AND E.CourseID = @course AND A.Presence = 1";

        string sqlAbsent = "SELECT COUNT(*) " +
                           "FROM Attendance A " +
                           "JOIN Enrollments E ON A.CourseID = E.CourseID " +
                           "JOIN StudentInfo SI ON E.Username = SI.Username " +
                           "WHERE SI.Username = @username AND E.CourseID = @course AND A.Presence = 0";

        string sqlTotalClasses = "SELECT COUNT(*) " +
                                 "FROM Attendance A " +
                                 "JOIN Enrollments E ON A.CourseID = E.CourseID " +
                                 "JOIN StudentInfo SI ON E.Username = SI.Username " +
                                 "WHERE SI.Username = @username AND E.CourseID = @course";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            int presentCount = 0;
            int absentCount = 0;
            int TotalNumberOfClasses = 0;

            using (SqlCommand command = new SqlCommand(sqlPresent, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@course", Course);
                presentCount = (int)command.ExecuteScalar();
            }

            using (SqlCommand command = new SqlCommand(sqlAbsent, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@course", Course);
                absentCount = (int)command.ExecuteScalar();
            }

            using (SqlCommand command = new SqlCommand(sqlTotalClasses, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@course", Course);
                TotalNumberOfClasses = (int)command.ExecuteScalar();
            }


            PresentNo = presentCount;
            AbsentNo = absentCount;
            TotalClasses = TotalNumberOfClasses;
        }
    }




    protected void Course1_Click(object sender, EventArgs e)
    {
        display(Course1Label.Text);
    }
    protected void Course2_Click(object sender, EventArgs e)
    {
        display(Course2Label.Text);
    }
    protected void Course3_Click(object sender, EventArgs e)
    {
        display(Course3Label.Text);
    }
    protected void Course4_Click(object sender, EventArgs e)
    {
        display(Course4Label.Text);
    } 
    protected void Course5_Click(object sender, EventArgs e)
    {
        display(Course5Label.Text);
    }
    protected void Course6_Click(object sender, EventArgs e)
    {
        display(Course6Label.Text);
    }






    [System.Web.Services.WebMethod]
    public static List<object> GetChartData()
    {
        string query = "SELECT Presence, COUNT(*) as Count FROM Attendance GROUP BY Presence";
        string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";
        List<object> chartData = new List<object>();
        chartData.Add(new object[]
        {
        "Presence", "Count"
        });
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        chartData.Add(new object[]
                        {
                        sdr["Presence"], sdr["Count"]
                        });
                    }
                }
                con.Close();
                return chartData;
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



