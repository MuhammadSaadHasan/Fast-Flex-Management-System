using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddFaculty : System.Web.UI.Page
{
    string username;
    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["username"] != null)
            {
                username = Session["username"].ToString();

                if (!string.IsNullOrEmpty(username))
                {
                }

            }

        }
    }

 
    private void LogTeacherAddition(string username)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO TeacherAdditionsLog (Username, AdditionTime) VALUES (@username, GETDATE())";

            using (SqlCommand cm = new SqlCommand(query, conn))
            {
                cm.Parameters.AddWithValue("@username", username);

                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();
            }
        }

    }
    protected void ManageFaculty_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("ManageFaculty.aspx");
            }
        }
    }

    protected void ManageStudents_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("ManageStudents.aspx");
            }
        }
    }

    protected void CourseAllocation_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("CourseAllocation.aspx");
            }
        }
    }

    protected void Section_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("Section.aspx");
            }
        }
    }

    protected void CoursesOffered_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("CourseOffered.aspx");
            }
        }
    }

    protected void SignOut_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("Login.aspx");
            }
        }
    }

    protected void AddFaculty_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
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












    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        string sql;
        string username = TextBoxUserName.Text;
        string teacherId = TextBoxTeacherId.Text;
        string subject = TextBoxSubject.Text; 
        string email = TextBoxEmail.Text;

        string currentAddress = TextBoxCurrentAddress.Text;
        string currentPhone = TextBoxCurrentPhone.Text;
        string currentPostalCode = TextBoxCurrentPostalCode.Text;
        string currentCity = TextBoxCurrentCity.Text;
        string currentCountry = TextBoxCurrentCountry.Text;
        string permanentAddress = TextBoxPermanentAddress.Text;
        string permanentPhone = TextBoxPermanentPhone.Text;
        string permanentPostalCode = TextBoxPermanentPostalCode.Text;
        string permanentCity = TextBoxPermanentCity.Text;
        string permanentCountry = TextBoxPermanentCountry.Text;

        string password = TextBoxPassword.Text; 

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            sql = "INSERT INTO Users (Username, pass, TypeOfUser) VALUES (@username, @password, 'Teacher')";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); 

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            sql = "INSERT INTO TeachersInfo (Username, TeacherId, Email, Specialization) VALUES (@username, @teacherId, @email, @specialization)";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@teacherId", teacherId);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@specialization", subject);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            sql = "INSERT INTO ContactInfo (Username, CurrentAddress, CurrentPhone, CurrentPostalCode, CurrentCity, CurrentCountry, PermanentAddress, PermanentPhone, PermanentPostalCode, PermanentCity, PermanentCountry) VALUES (@username, @currentAddress, @currentPhone, @currentPostalCode, @currentCity, @currentCountry, @permanentAddress, @permanentPhone, @permanentPostalCode, @permanentCity, @permanentCountry)";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@currentAddress", currentAddress);
                command.Parameters.AddWithValue("@currentPhone", currentPhone);
                command.Parameters.AddWithValue("@currentPostalCode", currentPostalCode);
                command.Parameters.AddWithValue("@currentCity", currentCity);
                command.Parameters.AddWithValue("@currentCountry", currentCountry);
                command.Parameters.AddWithValue("@permanentAddress", permanentAddress);
                command.Parameters.AddWithValue("@permanentPhone", permanentPhone);
                command.Parameters.AddWithValue("@permanentPostalCode", permanentPostalCode);
                command.Parameters.AddWithValue("@permanentCity", permanentCity);
                command.Parameters.AddWithValue("@permanentCountry", permanentCountry);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LogTeacherAddition(username);
        }
    }
}






