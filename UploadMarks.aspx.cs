using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UploadMarks : System.Web.UI.Page
{
    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";
    string username;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack){
            if (Session["username"] != null) {
                username = Session["username"].ToString();
                if (!string.IsNullOrEmpty(username)) {
                    string sql = "SELECT Course.CourseID, Course.Name FROM Course JOIN CourseTeachers ON Course.CourseID = CourseTeachers.CourseID JOIN TeachersInfo ON CourseTeachers.TeacherID = TeachersInfo.TeacherID WHERE TeachersInfo.Username = @Username;";
                    using (SqlConnection connection = new SqlConnection(connectionString)) {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection)) {
                            command.Parameters.AddWithValue("@username", username);
                            using (SqlDataReader reader = command.ExecuteReader()) {
                                int labelCounter = 1;
                                while (reader.Read()) {
                                    string CourseID = reader.GetString(0);
                                    if (labelCounter == 1) { Course1Label.Text = CourseID; }
                                    else if (labelCounter == 2) { Course2Label.Text = CourseID; }
                                    else if (labelCounter == 3) { Course3Label.Text = CourseID; }
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
            display("CourseID");  // Replace "CourseID" with the appropriate course ID
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

            sql = "SELECT DISTINCT CT.section FROM CourseTeachers CT INNER JOIN TeachersInfo TI ON CT.TeacherID = TI.TeacherID WHERE TI.Username = @Username AND CT.CourseID = @Course";

            if (!string.IsNullOrEmpty(username))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Course", Course);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        SectionDropDownList1.DataSource = reader;
                        SectionDropDownList1.DataTextField = "section"; 
                        SectionDropDownList1.DataValueField = "section";
                        SectionDropDownList1.DataBind();
                    }
                }
            }
            connection.Close();

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


    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
