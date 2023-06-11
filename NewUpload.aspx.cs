using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewUpload : System.Web.UI.Page
{
    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";
    string username;
    string Course;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["username"] != null)
            {
                username = Session["username"].ToString();
                if (!string.IsNullOrEmpty(username))
                {
                    string sql = "SELECT Course.CourseID, Course.Name FROM Course JOIN CourseTeachers ON Course.CourseID = CourseTeachers.CourseID JOIN TeachersInfo ON CourseTeachers.TeacherID = TeachersInfo.TeacherID WHERE TeachersInfo.Username = @Username;";
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
                                    Course = reader.GetString(0);
                                    if (labelCounter == 1) { Course1Label.Text = Course; }
                                    else if (labelCounter == 2) { Course2Label.Text = Course; }
                                    else if (labelCounter == 3) { Course3Label.Text = Course; }
                                    labelCounter++;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!IsPostBack)
        {
            display("CourseID");  
        }
    }




    protected void display(string Course)
    {
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
            connection.Close();

        }
    }













    protected void Course1_Click(object sender, EventArgs e)
    {
        Course = Course1Label.Text;
        display(Course);
    }

    protected void Course2_Click(object sender, EventArgs e)
    {
        Course = Course2Label.Text;
        display(Course);
    }

    protected void Course3_Click(object sender, EventArgs e)
    {
        Course = Course3Label.Text;
        display(Course);
    }



    protected void Button1_Click(object sender, EventArgs e)
    {


    }

    protected void AssignmentUpoadButton1_Click(object sender, EventArgs e)
    {
        bool isTotalMarksValid = int.TryParse(TotalMarksTextBox2.Text, out int totalMarks);
        bool isWeightageValid = float.TryParse(WeightageTextBox1.Text, out float weightage);

        string sql = "INSERT INTO Assignment(CourseID, TotalMarks, Weightage) VALUES (@Course, @TotalMarks, @Weightage)";


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (string.IsNullOrWhiteSpace(Course))
                {
                    return;
                }

                command.Parameters.AddWithValue("@CourseID", Course);
                command.Parameters.Add("@TotalMarks", SqlDbType.Int).Value = totalMarks;
                command.Parameters.Add("@Weightage", SqlDbType.Float).Value = weightage;

                command.ExecuteNonQuery();
            }
        }
    }



    protected void QuizUploadButton_Click(object sender, EventArgs e)
    {
        bool isTotalMarksValid = int.TryParse(QuizTotalMarksTextBox.Text, out int totalMarks);
        bool isWeightageValid = float.TryParse(QuizWeightageTextBox.Text, out float weightage);

        string sql = "INSERT INTO Quizes(CourseID, TotalMarks, Weightage) VALUES (@Course, @TotalMarks, @Weightage)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (string.IsNullOrWhiteSpace(Course))
                {
                    return;
                }

                command.Parameters.AddWithValue("@CourseID", Course);
                command.Parameters.Add("@TotalMarks", SqlDbType.Int).Value = totalMarks;
                command.Parameters.Add("@Weightage", SqlDbType.Float).Value = weightage;

                command.ExecuteNonQuery();
            }
        }
    }

    protected void MidtermUploadButton_Click(object sender, EventArgs e)
    {
        bool isTotalMarksValid = int.TryParse(MidtermTotalMarksTextBox.Text, out int totalMarks);
        bool isWeightageValid = float.TryParse(MidtermWeightageTextBox.Text, out float weightage);

        string sql = "INSERT INTO Midterm(CourseID, TotalMarks, Weightage) VALUES (@Course, @TotalMarks, @Weightage)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (string.IsNullOrWhiteSpace(Course))
                {
                    return;
                }

                command.Parameters.AddWithValue("@CourseID", Course);
                command.Parameters.Add("@TotalMarks", SqlDbType.Int).Value = totalMarks;
                command.Parameters.Add("@Weightage", SqlDbType.Float).Value = weightage;

                command.ExecuteNonQuery();
            }
        }
    }

    protected void FinalUploadButton_Click(object sender, EventArgs e)
    {
        bool isTotalMarksValid = int.TryParse(FinalTotalMarksTextBox.Text, out int totalMarks);
        bool isWeightageValid = float.TryParse(FinalWeightageTextBox.Text, out float weightage);

        string sql = "INSERT INTO Finals(CourseID, TotalMarks, Weightage) VALUES (@Course, @TotalMarks, @Weightage)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (string.IsNullOrWhiteSpace(Course))
                {
                    return;
                }

                command.Parameters.AddWithValue("@CourseID", Course);
                command.Parameters.Add("@TotalMarks", SqlDbType.Int).Value = totalMarks;
                command.Parameters.Add("@Weightage", SqlDbType.Int).Value = weightage;

                command.ExecuteNonQuery();
            }
        }
    }

}
