using System;
using System.Data.SqlClient;
using System.Xml;

public partial class ManageStudents : System.Web.UI.Page
{
    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";


    string username = "user1";
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }

    private string GetRollNo(string username)
    {
        string rollNo = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT s.RollNo FROM StudentInfo s INNER JOIN Users u ON s.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rollNo = reader.GetString(0);
                    }
                }
            }
        }

        return rollNo;
    }


    

    private string GetDegree(string username)
    {
        string degree = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT s.Degree FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        degree = reader.GetString(0);
                    }
                }
            }
        }

        return degree;
    }
    private int GetBatch(string username)
    {
        int batch = 0;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT s.Batch FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        batch = reader.GetInt32(0);
                    }
                }
            }
        }

        return batch;
    }
    private string GetSection(string username)
    {
        string section = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT s.Section FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        section = reader.GetString(0);
                    }
                }
            }
        }

        return section;
    }
    private string GetCampus(string username)
    {
        string campus = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT s.campus FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        campus = reader.GetString(0);
                    }
                }
            }
        }

        return campus;
    }
    private string GetStatus(string username)
    {
        string status = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT s.status FROM StudentInfo s INNER JOIN users u ON s.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        status = reader.GetString(0);
                    }
                }
            }
        }

        return status;
    }
    private string GetName(string username)
    {
        string name = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT p.Name FROM PersonalInfo p INNER JOIN Users u ON p.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = reader.GetString(0);
                    }
                }
            }
        }

        return name;
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
        string blood = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT p.BloodGroup FROM PersonalInfo p INNER JOIN Users u ON p.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        blood = reader.GetString(0);
                    }
                }
            }
        }

        return blood;
    }
    private string GetGender(string username)
    {
        string gender = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT p.Gender FROM PersonalInfo p INNER JOIN Users u ON p.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        gender = reader.GetString(0);
                    }
                }
            }
        }

        return gender;
    }
    private string GetCNIC(string username)
    {
        string cnic = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT p.CNIC FROM PersonalInfo p INNER JOIN Users u ON p.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cnic = reader.GetString(0);
                    }
                }
            }
        }

        return cnic;
    }
    private string GetNationality(string username)
    {
        string nationality = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT p.Nationality FROM PersonalInfo p INNER JOIN Users u ON p.Username = u.Username WHERE u.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nationality = reader.GetString(0);
                    }
                }
            }
        }

        return nationality;
    }
    private string GetEmail(string username)
    {
        string email = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT p.Email FROM PersonalInfo p WHERE p.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        email = reader.GetString(0);
                    }
                }
            }
        }

        return email;
    }
    private string GetMobile(string username)
    {
        string mobile = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT p.Mobile FROM PersonalInfo p WHERE p.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        mobile = reader.GetString(0);
                    }
                }
            }
        }

        return mobile;
    }
    private string GetPermanentAddress(string username)
    {
        string permAddress = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.PermanentAddress FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        permAddress = reader.GetString(0);
                    }
                }
            }
        }

        return permAddress;
    }
    private string GetCurrentAddress(string username)
    {
        string currAddress = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.CurrentAddress FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        currAddress = reader.GetString(0);
                    }
                }
            }
        }

        return currAddress;
    }
    private string GetPermanentPhone(string username)
    {
        string permPhone = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.PermanentPhone FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        permPhone = reader.GetString(0);
                    }
                }
            }
        }

        return permPhone;
    }
    private string GetCurrentPhone(string username)
    {
        string currPhone = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.CurrentPhone FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        currPhone = reader.GetString(0);
                    }
                }
            }
        }

        return currPhone;
    }
    private string GetPermanentPostalCode(string username)
    {
        string permPostalCode = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.PermanentPostalCode FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        permPostalCode = reader.GetString(0);
                    }
                }
            }
        }

        return permPostalCode;
    }
    private string GetCurrentPostalCode(string username)
    {
        string currPostalCode = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.CurrentPostalCode FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        currPostalCode = reader.GetString(0);
                    }
                }
            }
        }

        return currPostalCode;
    }
    private string GetPermanentCity(string username)
    {
        string permCity = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.PermanentCity FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        permCity = reader.GetString(0);
                    }
                }
            }
        }

        return permCity;
    }
    private string GetCurrentCity(string username)
    {
        string currCity = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.CurrentCity FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        currCity = reader.GetString(0);
                    }
                }
            }
        }

        return currCity;
    }
    private string GetPermanentCountry(string username)
    {
        string permCountry = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.PermanentCountry FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        permCountry = reader.GetString(0);
                    }
                }
            }
        }

        return permCountry;
    }
    private string GetCurrentCountry(string username)
    {
        string currCountry = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT c.CurrentCountry FROM ContactInfo c WHERE c.Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        currCountry = reader.GetString(0);
                    }
                }
            }
        }

        return currCountry;
    }

    private string GetFatherCNIC(string username)
    {
        string fatherCNIC = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT FatherCNIC FROM FamilyInfo WHERE Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fatherCNIC = reader.GetString(0);
                    }
                }
            }
        }

        return fatherCNIC;
    }

    private string GetMotherCNIC(string username)
    {
        string motherCNIC = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT MotherCNIC FROM FamilyInfo WHERE Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        motherCNIC = reader.GetString(0);
                    }
                }
            }
        }

        return motherCNIC;
    }


    private string GetMotherName(string username)
    {
        string motherName = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT MotherName FROM FamilyInfo WHERE Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        motherName = reader.GetString(0);
                    }
                }
            }
        }

        return motherName;
    }


    private string GetFatherName(string username)
    {
        string fatherName = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT FatherName FROM FamilyInfo WHERE Username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fatherName = reader.GetString(0);
                    }
                }
            }
        }

        return fatherName;
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



    protected void TextBox29_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        username = TextBox29.Text;

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
        PerCityLabel.Text = GetPermanentCity(username);
        CurrCityLabel.Text = GetCurrentCity(username);
        PerCountryLabel.Text = GetPermanentCountry(username);
        CurrCountryLabel.Text = GetCurrentCountry(username);
        FatherCNIClabel.Text = GetFatherCNIC(username);
        MotherCNIClabel.Text = GetMotherCNIC(username);
        FatherNameLabel.Text = GetFatherName(username);
        MotherNameLabel.Text = GetMotherName(username);

 
    }

    protected void Changes_Click(object sender, EventArgs e)
    {
        string rollno = String.IsNullOrWhiteSpace(TextBox1.Text) ? null : TextBox1.Text;
        string degree = String.IsNullOrWhiteSpace(TextBox2.Text) ? null : TextBox2.Text;
        string batch = String.IsNullOrWhiteSpace(TextBox3.Text) ? null : TextBox3.Text;
        string section = String.IsNullOrWhiteSpace(TextBox4.Text) ? null : TextBox4.Text;
        string campus = String.IsNullOrWhiteSpace(TextBox5.Text) ? null : TextBox5.Text;
        string status = String.IsNullOrWhiteSpace(TextBox6.Text) ? null : TextBox6.Text;
        string name = String.IsNullOrWhiteSpace(TextBox7.Text) ? null : TextBox7.Text;
        string dob = String.IsNullOrWhiteSpace(TextBox8.Text) ? null : TextBox8.Text;
        string bloodGroup = String.IsNullOrWhiteSpace(TextBox9.Text) ? null : TextBox9.Text;
        string gender = String.IsNullOrWhiteSpace(TextBox10.Text) ? null : TextBox10.Text;
        string cnic = String.IsNullOrWhiteSpace(TextBox11.Text) ? null : TextBox11.Text;
        string nationality = String.IsNullOrWhiteSpace(TextBox12.Text) ? null : TextBox12.Text;
        string email = String.IsNullOrWhiteSpace(TextBox13.Text) ? null : TextBox13.Text;
        string mobileNo = String.IsNullOrWhiteSpace(TextBox14.Text) ? null : TextBox14.Text;
        string perAddress = String.IsNullOrWhiteSpace(TextBox15.Text) ? null : TextBox15.Text;
        string perHomePhone = String.IsNullOrWhiteSpace(TextBox16.Text) ? null : TextBox16.Text;
        string perPostalCode = String.IsNullOrWhiteSpace(TextBox17.Text) ? null : TextBox17.Text;
        string perCity = String.IsNullOrWhiteSpace(TextBox18.Text) ? null : TextBox18.Text;
        string perCountry = String.IsNullOrWhiteSpace(TextBox19.Text) ? null : TextBox19.Text;
        string currAddress = String.IsNullOrWhiteSpace(TextBox20.Text) ? null : TextBox20.Text;
        string currHomePhone = String.IsNullOrWhiteSpace(TextBox21.Text) ? null : TextBox21.Text;
        string currPostalCode = String.IsNullOrWhiteSpace(TextBox22.Text) ? null : TextBox22.Text;
        string currCity = String.IsNullOrWhiteSpace(TextBox23.Text) ? null : TextBox23.Text;
        string currCountry = String.IsNullOrWhiteSpace(TextBox24.Text) ? null : TextBox24.Text;
        string fatherName = String.IsNullOrWhiteSpace(TextBox25.Text) ? null : TextBox25.Text;
        string fatherCnic = String.IsNullOrWhiteSpace(TextBox26.Text) ? null : TextBox26.Text;
        string fatherMobileNo = String.IsNullOrWhiteSpace(TextBox27.Text) ? null : TextBox27.Text;
        string fatherEmail = String.IsNullOrWhiteSpace(TextBox28.Text) ? null : TextBox28.Text;


        if (rollno == null || rollno == "") 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE StudentInfo SET RollNo = @rollNo WHERE Username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@rollNo", rollno);

                    command.ExecuteNonQuery();
                }
            }
        }

        if (!string.IsNullOrEmpty(rollno))
        {
            UpdateValueInDB(connectionString, "UPDATE StudentInfo SET RollNo = @value WHERE Username = @username", username, rollno);
        }

        if (!string.IsNullOrEmpty(degree))
        {
            UpdateValueInDB(connectionString, "UPDATE StudentInfo SET Degree = @value WHERE Username = @username", username, degree);
        }

        if (batch != null || batch != "")
        {
            UpdateValueInDB(connectionString, "UPDATE StudentInfo SET Batch = @value WHERE Username = @username", username, batch.ToString());
        }

        if (!string.IsNullOrEmpty(section))
        {
            UpdateValueInDB(connectionString, "UPDATE StudentInfo SET Section = @value WHERE Username = @username", username, section);
        }

        if (!string.IsNullOrEmpty(campus))
        {
            UpdateValueInDB(connectionString, "UPDATE StudentInfo SET Campus = @value WHERE Username = @username", username, campus);
        }

        if (!string.IsNullOrEmpty(status))
        {
            UpdateValueInDB(connectionString, "UPDATE StudentInfo SET Status = @value WHERE Username = @username", username, status);
        }

        if (!string.IsNullOrEmpty(name))
        {
            UpdateValueInDB(connectionString, "UPDATE PersonalInfo SET Name = @value WHERE Username = @username", username, name);
        }

        if (dob != null || dob != "")
        {
            UpdateValueInDB(connectionString, "UPDATE PersonalInfo SET DateOfBirth = @value WHERE Username = @username", username, dob.ToString());
        }

        if (!string.IsNullOrEmpty(bloodGroup))
        {
            UpdateValueInDB(connectionString, "UPDATE PersonalInfo SET BloodGroup = @value WHERE Username = @username", username, bloodGroup);
        }

        if (!string.IsNullOrEmpty(gender))
        {
            UpdateValueInDB(connectionString, "UPDATE PersonalInfo SET Gender = @value WHERE Username = @username", username, gender);
        }

        if (!string.IsNullOrEmpty(cnic))
        {
            UpdateValueInDB(connectionString, "UPDATE PersonalInfo SET CNIC = @value WHERE Username = @username", username, cnic);
        }

        if (!string.IsNullOrEmpty(nationality))
        {
            UpdateValueInDB(connectionString, "UPDATE PersonalInfo SET Nationality = @value WHERE Username = @username", username, nationality);
        }

        if (!string.IsNullOrEmpty(email))
        {
            UpdateValueInDB(connectionString, "UPDATE PersonalInfo SET Email = @value WHERE Username = @username", username, email);
        }

        if (!string.IsNullOrEmpty(mobileNo))
        {
            UpdateValueInDB(connectionString, "UPDATE PersonalInfo SET Mobile = @value WHERE Username = @username", username, mobileNo);
        }

        if (!string.IsNullOrEmpty(perAddress))
        {
            UpdateValueInDB(connectionString, "UPDATE ContactInfo SET PermanentAddress = @value WHERE Username = @username", username, perAddress);
        }

        if (!string.IsNullOrEmpty(perHomePhone))
        {
            UpdateValueInDB(connectionString, "UPDATE ContactInfo SET PermanentPhone = @value WHERE Username = @username", username, perHomePhone);
        }


        // ContactInfo table continued...
        if (!string.IsNullOrEmpty(perPostalCode))
        {
            UpdateValueInDB(connectionString, "UPDATE ContactInfo SET PermanentPostalCode = @value WHERE Username = @username", username, perPostalCode);
        }

        if (!string.IsNullOrEmpty(perCity))
        {
            UpdateValueInDB(connectionString, "UPDATE ContactInfo SET PermanentCity = @value WHERE Username = @username", username, perCity);
        }

        if (!string.IsNullOrEmpty(perCountry))
        {
            UpdateValueInDB(connectionString, "UPDATE ContactInfo SET PermanentCountry = @value WHERE Username = @username", username, perCountry);
        }

        if (!string.IsNullOrEmpty(currAddress))
        {
            UpdateValueInDB(connectionString, "UPDATE ContactInfo SET CurrentAddress = @value WHERE Username = @username", username, currAddress);
        }

        if (!string.IsNullOrEmpty(currHomePhone))
        {
            UpdateValueInDB(connectionString, "UPDATE ContactInfo SET CurrentPhone = @value WHERE Username = @username", username, currHomePhone);
        }

        // FamilyInfo table
        if (!string.IsNullOrEmpty(fatherName))
        {
            UpdateValueInDB(connectionString, "UPDATE FamilyInfo SET FatherName = @value WHERE Username = @username", username, fatherName);
        }

        if (!string.IsNullOrEmpty(fatherCnic))
        {
            UpdateValueInDB(connectionString, "UPDATE FamilyInfo SET FatherCNIC = @value WHERE Username = @username", username, fatherCnic);
        }

        if (!string.IsNullOrEmpty(fatherMobileNo))
        {
            UpdateValueInDB(connectionString, "UPDATE FamilyInfo SET FatherMobileNo = @value WHERE Username = @username", username, fatherMobileNo);
        }

        if (!string.IsNullOrEmpty(fatherEmail))
        {
            UpdateValueInDB(connectionString, "UPDATE FamilyInfo SET FatherEmail = @value WHERE Username = @username", username, fatherEmail);
        }


    }

    public void UpdateValueInDB(string connectionString, string commandText, string username, string value)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@value", value);

                command.ExecuteNonQuery();
            }
        }
    }
}

