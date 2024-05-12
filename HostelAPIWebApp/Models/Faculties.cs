using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class Faculty
{
    public int FacultyID { get; set; }
    public string Name { get; set; }
    public string DeanName { get; set; }
    public virtual ICollection<Department> Departments { get; set; }

    public Faculty()
    {
        Departments = new HashSet<Department>();
    }
}

