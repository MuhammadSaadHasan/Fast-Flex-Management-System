using System;
using System.Data.SqlClient;

public partial class TeachersHomePage : System.Web.UI.Page
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
                    TeacherIDLabel.Text = GetTeacherID(username);
                    TeacherNameLabel.Text = GetName(username);
                    TeacherEmailLabel.Text = GetEmail(username);
                    SpecializationLabel.Text = GetSpecialization(username);
                    NameLabel.Text = GetName(username);
                    //DOBLabel.Text = GetDateOfBirth(username).Value.ToString("dd-MM-yyyy");
                    BloodGroupLabel.Text = GetBlood(username);
                    GenderLabel.Text = GetGender(username);
                    CNICLabel.Text = GetCNIC(username);
                    NationalityLabel.Text = GetNationality(username);
                    EmailLabel.Text = GetEmail(username);
                    MobileLabel.Text = GetMobile(username);
                    CurrentAddressLabel.Text = GetCurrentAddress(username);
                    CurrentPhoneLabel.Text = GetCurrentPhone(username);
                    CurrentPostalCodeLabel.Text = GetCurrentPostalCode(username);
                    CurrentCityLabel.Text = GetCurrentCity(username);
                    CurrentCountryLabel.Text = GetCurrentCountry(username);
                    PermanentAddressLabel.Text = GetPermanentAddress(username);
                    PermanentPhoneLabel.Text = GetPermanentPhone(username);
                    PermanentPostalCodeLabel.Text = GetPermanentPostalCode(username);
                    PermanentCityLabel.Text = GetPermanentCity(username);
                    PermanentCountryLabel.Text = GetPermanentCountry(username);
                    MotherNameLabel.Text = GetMotherName(username);
                    MotherCNICLabel.Text = GetMotherCNIC(username);
                    FatherNameLabel.Text = GetFatherName(username);
                    FatherCNICLabel.Text = GetFatherCNIC(username);
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
    private string GetTeacherID(string username)
    {
        return GetData("SELECT t.TeacherID FROM TeachersInfo t INNER JOIN users u ON t.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetSpecialization(string username)
    {
        return GetData("SELECT t.Specialization FROM TeachersInfo t INNER JOIN users u ON t.Username = u.Username WHERE u.Username = @username", username);
    }
    private string GetName(string username)
    {
        return GetData("SELECT Name FROM PersonalInfo WHERE Username = @username", username);
    }
    private string GetBlood(string username)
    {
        return GetData("SELECT BloodGroup FROM PersonalInfo WHERE Username = @username", username);
    }
    private string GetGender(string username)
    {
        return GetData("SELECT Gender FROM PersonalInfo WHERE Username = @username", username);
    }
    private string GetCNIC(string username)
    {
        return GetData("SELECT CNIC FROM PersonalInfo WHERE Username = @username", username);
    }
    private string GetNationality(string username)
    {
        return GetData("SELECT Nationality FROM PersonalInfo WHERE Username = @username", username);
    }
    private string GetEmail(string username)
    {
        return GetData("SELECT Email FROM PersonalInfo WHERE Username = @username", username);
    }
    private string GetMobile(string username)
    {
        return GetData("SELECT Mobile FROM PersonalInfo WHERE Username = @username", username);
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
    private string GetCurrentAddress(string username)
    {
        return GetData("SELECT CurrentAddress FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetCurrentPhone(string username)
    {
        return GetData("SELECT CurrentPhone FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetCurrentPostalCode(string username)
    {
        return GetData("SELECT CurrentPostalCode FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetCurrentCity(string username)
    {
        return GetData("SELECT CurrentCity FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetCurrentCountry(string username)
    {
        return GetData("SELECT CurrentCountry FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetPermanentAddress(string username)
    {
        return GetData("SELECT PermanentAddress FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetPermanentPhone(string username)
    {
        return GetData("SELECT PermanentPhone FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetPermanentPostalCode(string username)
    {
        return GetData("SELECT PermanentPostalCode FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetPermanentCity(string username)
    {
        return GetData("SELECT PermanentCity FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetPermanentCountry(string username)
    {
        return GetData("SELECT PermanentCountry FROM ContactInfo WHERE Username = @username", username);
    }
    private string GetMotherName(string username)
    {
        return GetData("SELECT MotherName FROM FamilyInfo WHERE Username = @username", username);
    }
    private string GetMotherCNIC(string username)
    {
        return GetData("SELECT MotherCNIC FROM FamilyInfo WHERE Username = @username", username);
    }
    private string GetFatherName(string username)
    {
        return GetData("SELECT FatherName FROM FamilyInfo WHERE Username = @username", username);
    }
    private string GetFatherCNIC(string username)
    {
        return GetData("SELECT FatherCNIC FROM FamilyInfo WHERE Username = @username", username);
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

    protected void MarksDistribution_Click(object sender, EventArgs e)
    {

    }

    protected void Attendance_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("AttendenceMarking.aspx");
            }
        }
    }

    protected void UploadMarks_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("UploadMarks.aspx");
            }
        }
    }

    protected void GenerateGrades_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("GeneratGrades.aspx");
            }
        }
    }

    protected void GenerateReports_Click(object sender, EventArgs e)
    {

    }

    protected void TeacherProfile_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("TeachersHomePage.aspx");
            }
        }
    }

    protected void NewUpload_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                Session["username"] = username;
                Response.Redirect("NewUpload.aspx");
            }
        }
    }
}
