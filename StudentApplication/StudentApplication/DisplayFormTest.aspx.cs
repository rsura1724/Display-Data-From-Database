using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentApplication
{
    public partial class DisplayFormTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string driver = @"data source=DESKTOP-0LCM8ID\SQLEXPRESS; database = CollegeDB; integrated security=SSPI";
            SqlConnection conn = new SqlConnection(driver);
            conn.Open();
            string query1 = "SELECT Student.studentFirstName, Student.studentLastName,Student.studentDepartment,Student.studentDegree, Advisor.advisorName FROM Student LEFT JOIN Advisor ON Student.advisorId = Advisor.advisorId ORDER BY Student.studentFirstName; ";
            SqlCommand cmd = new SqlCommand(query1,conn);
            
           GridViewDisplay.DataSource= cmd.ExecuteReader();
            GridViewDisplay.DataBind();
            conn.Close();

        }
    }
}