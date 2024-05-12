using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;

    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public int FacultyID { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Department()
        {
            Students = new HashSet<Student>();
        }
    }


