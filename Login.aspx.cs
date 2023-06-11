using System;
using System.Activities.Expressions;
using System.Data.SqlClient;
using System.Web.UI;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        string username = TextBoxUsername.Text.Trim();
        string password = TextBoxPassword.Text.Trim();
        string TypeOfUser = DropDownListRole.SelectedValue;

        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True"))
        {
            conn.Open();
           string query = "SELECT* FROM Users WHERE Username = @username AND Pass = @password AND TypeOfUser = @TypeOfUser";

            using (SqlCommand cm = new SqlCommand(query, conn))
            {
                cm.Parameters.AddWithValue("@username", username);
                cm.Parameters.AddWithValue("@password", password);
                cm.Parameters.AddWithValue("@TypeOfUser", TypeOfUser);

                SqlDataReader res = cm.ExecuteReader();

                if (!res.HasRows)
                {
                    LabelMessage.Text = "No such username found or incorrect user type";
                    LogLoginAttempt(username, false, TypeOfUser);  
                }
                else
                {
                    LogLoginAttempt(username, true, TypeOfUser);  // Log unsuccessful login attempt
                    if (TypeOfUser == "Student")
                    {
                        Session["username"] = username; // Storing username in Session variable
                        res.Close();
                        cm.Dispose();
                        conn.Close();
                        Response.Redirect("StudentsHomePage.aspx");
                    }
                    else if (TypeOfUser == "Admin")
                    {
                        Session["username"] = username; 
                        res.Close();
                        cm.Dispose();
                        conn.Close();
                        Response.Redirect("AdminHomePage.aspx");
                    }
                    else
                    {
                        Session["username"] = username; 
                        res.Close();
                        cm.Dispose();
                        conn.Close();
                        Response.Redirect("TeachersHomePage.aspx");
                    }

                    return;
                }

                res.Close();
                cm.Dispose();
            }

            conn.Close();
        }
    }



    private void LogLoginAttempt(string username, bool successful, string userType)
    {
        string query = "INSERT INTO LoginAttempts(Username, AttemptTime, Successful, UserType) VALUES (@username, @attemptTime, @successful, @userType)";

        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True"))
        {
            conn.Open();

            using (SqlCommand cm = new SqlCommand(query, conn))
            {
                cm.Parameters.AddWithValue("@username", username);
                cm.Parameters.AddWithValue("@attemptTime", DateTime.Now);
                cm.Parameters.AddWithValue("@successful", successful);
                cm.Parameters.AddWithValue("@userType", userType);

                cm.ExecuteNonQuery();
            }

            conn.Close();
        }
    }




}
