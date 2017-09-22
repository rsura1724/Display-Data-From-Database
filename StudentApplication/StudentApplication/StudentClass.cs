using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplication
{
    public class StudentClass
    {
        public int studentId { get; set; }
        public string studentFirstName { get; set; }
        public string studentLastName { get; set; }
        public string studentDepartment { get; set; }
        public int studentDegree { get; set; }
        public AdvisorClass advisor { get; set; }
    }
}