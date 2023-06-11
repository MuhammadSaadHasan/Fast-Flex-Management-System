using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddStudent : System.Web.UI.Page
{
    string username;
    string section= "";
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



    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        
        string username = TextBoxUserName.Text;
        string password = TextBoxPassword.Text;
        string firstName = TextBoxFirstName.Text;
        string lastName = TextBoxLastName.Text;
        string cnic = TextBoxCNIC.Text;
        string phoneNo = TextBoxPhoneNo.Text;
        string email = TextBoxEmail.Text;
        string address = TextBoxAddress.Text;
        string city = TextBoxCity.Text;
        string country = TextBoxCountry.Text;
        string bloodGroup = TextBoxBloodGroup.Text;
        string dob = TextBoxDOB.Text;
        string arn = TextBoxARN.Text;
        string rollNo = TextBoxRollNo.Text;

        string degree = DropDownListDegree.SelectedValue;
        string campus = DropDownListCampus.SelectedValue;
        string gender = DropDownListGender.SelectedValue;
        string fatherFirstName = TextBoxFatherFirstName.Text;
        string fatherLastName = TextBoxFatherLastName.Text;
        string fatherCNIC = TextBoxFatherCNIC.Text;
        string homePhoneNo = TextBoxHomePhoneNo.Text;



        string sql;
          
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            sql = "INSERT INTO Users (Username, pass, TypeOfUser) VALUES (@username, @password, 'Student')";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            sql = "INSERT INTO StudentInfo (Username, ROLLNO, Degree, Campus) VALUES (@username, @rollNo, @degree, @campus)";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@rollNo", rollNo);
                command.Parameters.AddWithValue("@degree", degree);
                command.Parameters.AddWithValue("@campus", campus);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            sql = "INSERT INTO PersonalInfo (Username, Name, DateOfBirth, BloodGroup, Gender, CNIC, Email, Mobile) VALUES (@username, @name, @dob, @bloodGroup, @gender, @cnic, @email, @mobile)";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@name", firstName + " " + lastName);
                command.Parameters.AddWithValue("@dob", dob);
                command.Parameters.AddWithValue("@bloodGroup", bloodGroup);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@cnic", cnic);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobile", phoneNo);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            sql = "INSERT INTO ContactInfo (Username, CurrentAddress, CurrentPhone, CurrentCity, CurrentCountry) VALUES (@username, @address, @phoneNo, @city, @country)";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@phoneNo", phoneNo);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@country", country);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            //IN LOG TABLE
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@phoneNo", phoneNo);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@country", country);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LogStudentAddition(username);

        }




    }








    private void LogStudentAddition(string username)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO StudentAdditionsLog (Username, AdditionTime) VALUES (@username, GETDATE())";

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
        if (Session["username"] != null) // Check if the Session variable is set
        {
            username = Session["username"].ToString(); // Retrieve the username from the Session variable

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username; // Storing username in Session variable
                Response.Redirect("AddStudent.aspx");
            }
        }
    }

}