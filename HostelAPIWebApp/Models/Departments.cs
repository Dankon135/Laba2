using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;

public class Department
{
    [Key]
    public int DepartmentID { get; set; }
    [Required]
    public string Name { get; set; }

    
    [ForeignKey("Faculty")]
    public int FacultyID { get; set; }
    public virtual Faculty Faculty { get; set; }

    
    public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
}


