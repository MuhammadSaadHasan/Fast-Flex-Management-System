using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AttendenceMarking : System.Web.UI.Page
{
    string connectionString = "Data Source=DESKTOP-B58V6V8\\SQLEXPRESS;Initial Catalog=DBP;Integrated Security=True";

    string username;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["username"] != null)
            {
                username = Session["username"].ToString();

                

            }

        }
    }


    protected void display(string Course)
    {
        DateTime selectedDate;
        if (DateTime.TryParse(dateTextBox.Text, out selectedDate))
        {
            string courseName = Course; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT p.name FROM personalinfo p INNER JOIN attendance a ON a.username = p.username INNER JOIN enrollments e ON e.username = p.username INNER JOIN course c ON c.courseid = e.courseid WHERE c.name = @courseName";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate);
                    cmd.Parameters.AddWithValue("@courseName", courseName);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    studentRepeater.DataSource = dt;
                    studentRepeater.DataBind();
                }
            }
        }
        else
        {
            outputLabel.Text = "Invalid date selected.";
        }


    }



    protected void Course1_Click(object sender, EventArgs e)
    {
        display(LinkButton1.Text);
    }

    protected void Course2_Click(object sender, EventArgs e)
    {
        display(LinkButton2.Text);

    }

    protected void Course3_Click(object sender, EventArgs e)
    {
        display(LinkButton3.Text);

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        
    }

}