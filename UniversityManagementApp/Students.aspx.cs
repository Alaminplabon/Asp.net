using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityManagementApp
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=PLABON\SQLEXPRESS;Database = UniversityDB;Integrated Security = true";
            string query = "Select * from Students";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Student> Studentlist = new List<Student>();

            while (reader.Read())
            {
                Student astudent = new Student();
                astudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                astudent.RegNo = reader["RegNo"].ToString();
                astudent.Name = reader["Name"].ToString();
                astudent.Email = reader["Email"].ToString();
                astudent.Phone = reader["Phone"].ToString();

                Studentlist.Add(astudent);
            }
            reader.Close();
            connection.Close();

            gridstudent.DataSource = Studentlist;
            gridstudent.DataBind();

        }

        protected void gridstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}