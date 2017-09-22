using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace StudentApplication
{
    public class ConnectionUtility
    {

        SqlConnection conn = new SqlConnection("Server=./SQLEXPRESS;Database=CollegeDB");

       
    }

}