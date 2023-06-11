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
using System.Text.RegularExpressions;

public partial class Marks : System.Web.UI.Page
{
    string username;
   protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack){
            if (Session["username"] != null) {
            username = Session["username"].ToString();
            if (!string.IsNullOrEmpty(username)){
                string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";
                string sql = "SELECT E.CourseID FROM Enrollments E JOIN Users U ON E.Username = U.Username WHERE U.Username = @username";
                using (SqlConnection connection = new SqlConnection(connectionString)){
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection)){
                        command.Parameters.AddWithValue("@username", username);
                        using (SqlDataReader reader = command.ExecuteReader()){
                            int labelCounter = 1;
                            while (reader.Read()){
                                string CourseID = reader.GetString(0);
                                if      (labelCounter == 1) {Course1Label.Text = CourseID;}
                                else if (labelCounter == 2) {Course2Label.Text = CourseID;}
                                else if (labelCounter == 3) {Course3Label.Text = CourseID;}
                                else if (labelCounter == 4) {Course4Label.Text = CourseID;}
                                else if (labelCounter == 5) {Course5Label.Text = CourseID;}
                                else if (labelCounter == 6) {Course6Label.Text = CourseID;}
                                labelCounter++;
                            }
                        }
                    }
                }
            }
        }
    }
}

    protected decimal Avg { get; set; }
    protected decimal Min { get; set; }
    protected decimal Max { get; set; }

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
            if (Session["username"] != null)
            {
                string username = Session["username"].ToString();
                if (!string.IsNullOrEmpty(username))
                {

                    sql = "SELECT AVG(FM.ObtainedMarks) AS 'AverageMarks', MAX(FM.ObtainedMarks) AS 'MaxMarks', MIN(FM.ObtainedMarks) AS 'MinMarks' FROM FinalMarks FM WHERE FM.CourseID = @Course";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Course", Course);
                        command.Parameters.AddWithValue("@Username", username);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Avg = reader["AverageMarks"] != DBNull.Value ? Convert.ToDecimal(reader["AverageMarks"]) : 0;
                                Max = reader["MaxMarks"] != DBNull.Value ? Convert.ToDecimal(reader["MaxMarks"]) : 0;
                                Min = reader["MinMarks"] != DBNull.Value ? Convert.ToDecimal(reader["MinMarks"]) : 0;
                            }
                        }
                    }

                    sql = "SELECT FC.Weightage, FM.ObtainedMarks, FC.TotalMarks FROM FinalMarks FM JOIN Finals FC ON FM.CourseID = FC.CourseID WHERE FM.CourseID = @Course AND FM.Username = @Username";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Course", Course);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            FinalRepeater.DataSource = dataTable;
                            FinalRepeater.DataBind();
                        }
                    }


                    sql = "SELECT AVG(MM.ObtainedMarks) AS 'AverageMarks', MAX(MM.ObtainedMarks) AS 'MaxMarks', MIN(MM.ObtainedMarks) AS 'MinMarks' FROM MidtermMarks MM JOIN Midterm M ON MM.MidtermID = M.MidtermID WHERE M.CourseID = @Course";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Course", Course);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Avg = reader["AverageMarks"] != DBNull.Value ? Convert.ToDecimal(reader["AverageMarks"]) : 0;
                                Max = reader["MaxMarks"] != DBNull.Value ? Convert.ToDecimal(reader["MaxMarks"]) : 0;
                                Min = reader["MinMarks"] != DBNull.Value ? Convert.ToDecimal(reader["MinMarks"]) : 0;
                            }
                        }
                    }

                    sql = "SELECT MC.Weightage, MM.ObtainedMarks, MC.TotalMarks FROM MidtermMarks MM JOIN Midterm MC ON MM.MidtermID = MC.MidtermID JOIN Enrollments E ON MC.CourseID = E.CourseID AND MM.Username = E.Username WHERE E.CourseID = @Course AND E.Username = @Username";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Course", Course);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            MidtermRepeater.DataSource = dataTable;
                            MidtermRepeater.DataBind();
                        }
                    }


                    sql = "SELECT AVG(AM.ObtainedMarks) AS 'AverageMarks', MAX(AM.ObtainedMarks) AS 'MaxMarks', MIN(AM.ObtainedMarks) AS 'MinMarks' FROM AssignmentMarks AM JOIN Assignment A ON AM.AssignmentID = A.AssignmentID WHERE A.CourseID = @Course";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Course", Course);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Avg = reader["AverageMarks"] != DBNull.Value ? Convert.ToDecimal(reader["AverageMarks"]) : 0;
                                Max = reader["MaxMarks"] != DBNull.Value ? Convert.ToDecimal(reader["MaxMarks"]) : 0;
                                Min = reader["MinMarks"] != DBNull.Value ? Convert.ToDecimal(reader["MinMarks"]) : 0;
                            }
                        }
                    }

                    sql = "SELECT A.Weightage, AM.ObtainedMarks, A.TotalMarks FROM AssignmentMarks AM JOIN Assignment A ON AM.AssignmentID = A.AssignmentID JOIN Enrollments E ON A.CourseID = E.CourseID AND AM.Username = E.Username WHERE E.CourseID = @Course AND E.Username = @Username";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Course", Course);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            AssignmentRepeater.DataSource = dataTable;
                            AssignmentRepeater.DataBind();
                        }
                    }

                    sql = "SELECT AVG(QM.ObtainedMarks) AS 'AverageMarks', MAX(QM.ObtainedMarks) AS 'MaxMarks', MIN(QM.ObtainedMarks) AS 'MinMarks' FROM QuizMarks QM JOIN Quizes Q ON QM.QuizID = Q.QuizID WHERE Q.CourseID = @Course";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Course", Course);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Avg = reader["AverageMarks"] != DBNull.Value ? Convert.ToDecimal(reader["AverageMarks"]) : 0;
                                Max = reader["MaxMarks"] != DBNull.Value ? Convert.ToDecimal(reader["MaxMarks"]) : 0;
                                Min = reader["MinMarks"] != DBNull.Value ? Convert.ToDecimal(reader["MinMarks"]) : 0;
                            }
                        }
                    }

                    sql = "SELECT Q.Weightage, QM.ObtainedMarks, Q.TotalMarks FROM QuizMarks QM JOIN Quizes Q ON QM.QuizID = Q.QuizID JOIN Enrollments E ON Q.CourseID = E.CourseID AND QM.Username = E.Username WHERE E.CourseID = @Course AND E.Username = @Username";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Course", Course);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            QuizRepeater.DataSource = dataTable;
                            QuizRepeater.DataBind();
                        }
                    }


                }
            }
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