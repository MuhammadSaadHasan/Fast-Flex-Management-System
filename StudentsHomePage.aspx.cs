using System;
using System.Data.SqlClient;

public partial class StudentsHomePage : System.Web.UI.Page
{
    string username;
    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";

   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["username"] != null) // Check if the Session variable is set
            {
                username = Session["username"].ToString(); // Retrieve the username from the Session variable

                if (!string.IsNullOrEmpty(username))
                {
                    LabelMessage.Text = GetName(username);
                    RollNumberLabel.Text = GetRollNo(username);
                    DegreeLabel.Text = GetDegree(username);
                    BatchLabel.Text = GetBatch(username).ToString();
                    SectionLabel.Text = GetSection(username);
                    CampusLabel.Text = GetCampus(username);
                    StatusLabel.Text = GetStatus(username);
                    NameLabel.Text = GetName(username);
                    DateOfBirthLabel.Text = GetDateOfBirth(username).Value.ToString("dd-MM-yyyy");
                    BloodGroupLabel.Text = GetBlood(username);
                    GenderLabel.Text = GetGender(username);
                    CNIClabel.Text = GetCNIC(username);
                    NationalityLabel.Text = GetNationality(username);
                    EmailLabel.Text = GetEmail(username);
                    MobileNoLabel.Text = GetMobile(username);
                    PerAddressLabel.Text = GetPermanentAddress(username);
                    CurrAddressLabel.Text = GetPermanentAddress(username);
                    PerHomePhoneLabel.Text = GetPermanentPhone(username);
                    CurrHomePhoneLabel.Text = GetCurrentPhone(username);
                    PerPostalCodeLabel.Text = GetPermanentPostalCode(username);
                    CurrPostalCodeLabel.Text = GetCurrentPostalCode(username);
                    PerCityLabel.Text =  GetPermanentCity(username);
                    CurrCityLabel.Text = GetCurrentCity(username);
                    PerCountryLabel.Text = GetPermanentCountry(username);
                    CurrCountryLabel.Text = GetCurrentCountry(username);
                    FatherCNIClabel.Text = GetFatherCNIC(username);
                    MotherCNIClabel.Text = GetMotherCNIC(username);
                    FatherNameLabel.Text = GetFatherName(username);
                    MotherNameLabel.Text = GetMotherName(username);
                }
            }
        }
    }
    private string GetData(string commandText, string username)
    {
        string result = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader[0].ToString();
                    }
                }
            }
        }

        return result;
    }


    private string GetRollNo(string username)
    {
        return GetData("SELECT s.RollNo FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetDegree(string username)
    {
        return GetData("SELECT s.Degree FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetBatch(string username)
    {
        return GetData("SELECT s.Batch FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetSection(string username)
    {
        return GetData("SELECT s.Section FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetCampus(string username)
    {
        return GetData("SELECT s.Campus FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetStatus(string username)
    {
        return GetData("SELECT s.Status FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetName(string username)
    {
        return GetData("SELECT p.Name FROM PersonalInfo p INNER JOIN users u ON p.Username = u.Username WHERE u.Username = @username", username);
    }
    private DateTime? GetDateOfBirth(string username)
    {
        DateTime? dateOfBirth = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT p.DateOfBirth FROM PersonalInfo p INNER JOIN Users u ON p.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dateOfBirth = reader.GetDateTime(0);
                    }
                }
            }
        }

        return dateOfBirth;
    }
    private string GetBlood(string username)
    {
        return GetData("SELECT p.BloodGroup FROM PersonalInfo p INNER JOIN users u ON p.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetGender(string username)
    {
        return GetData("SELECT p.Gender FROM PersonalInfo p INNER JOIN users u ON p.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetCNIC(string username)
    {
        return GetData("SELECT p.CNIC FROM PersonalInfo p INNER JOIN users u ON p.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetNationality(string username)
    {
        return GetData("SELECT p.Nationality FROM PersonalInfo p INNER JOIN users u ON p.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetEmail(string username)
    {
        return GetData("SELECT p.Email FROM PersonalInfo p INNER JOIN users u ON p.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetMobile(string username)
    {
        return GetData("SELECT p.Mobile FROM PersonalInfo p INNER JOIN users u ON p.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetPermanentAddress(string username)
    {
        return GetData("SELECT c.PermanentAddress FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetCurrentAddress(string username)
    {
        return GetData("SELECT c.CurrentAddress FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetPermanentPhone(string username)
    {
        return GetData("SELECT c.PermanentPhone FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetCurrentPhone(string username)
    {
        return GetData("SELECT c.CurrentPhone FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetPermanentPostalCode(string username)
    {
        return GetData("SELECT c.PermanentPostalCode FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetCurrentPostalCode(string username)
    {
        return GetData("SELECT c.CurrentPostalCode FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetPermanentCity(string username)
    {
        return GetData("SELECT c.PermanentCity FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetCurrentCity(string username)
    {
        return GetData("SELECT c.CurrentCity FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetPermanentCountry(string username)
    {
        return GetData("SELECT c.PermanentCountry FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetCurrentCountry(string username)
    {
        return GetData("SELECT c.CurrentCountry FROM ContactInfo c INNER JOIN users u ON c.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetFatherCNIC(string username)
    {
        return GetData("SELECT f.FatherCNIC FROM FamilyInfo f INNER JOIN users u ON f.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetMotherCNIC(string username)
    {
        return GetData("SELECT f.MotherCNIC FROM FamilyInfo f INNER JOIN users u ON f.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetMotherName(string username)
    {
        return GetData("SELECT f.MotherName FROM FamilyInfo f INNER JOIN users u ON f.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetFatherName(string username)
    {
        return GetData("SELECT f.FatherName FROM FamilyInfo f INNER JOIN users u ON f.Username = u.Username WHERE u.Username = @username", username);
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
