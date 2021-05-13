using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullStudentData.Models
{
    class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public string created_at { get; set; }
        public string sortable_name { get; set; }
        public string short_name { get; set; }
        public string sis_user_id { get; set; }
        public string integration_id { get; set; }
        public string login_id { get; set; }
        public string email { get; set; }
    }
}
