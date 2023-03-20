using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityManagementApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string regNo = txtReg.Text;
            string name =  txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            Student aStudent = new Student();
            aStudent.RegNo = regNo;
            aStudent.Name = name;
            aStudent.Email = email;
            aStudent.Phone = phone;

            string connectionString = @"Server=PLABON\SQLEXPRESS;Database = UniversityDB;Integrated Security = true";
            string query = "INSERT INTO Students Values('"+aStudent.RegNo+"','"+aStudent.Name+"','"+aStudent.Email+"','"+aStudent.Phone+"')";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            if (rowAffected > 0 ) 
            {
                lvlShow.Text = "Save the information";
            }
            else
            {
                lvlShow.Text = "Error";
            }

        }

        protected void btnshow_Click(object sender, EventArgs e)
        {
            Response.Redirect("Students.aspx");
        }
    }
}