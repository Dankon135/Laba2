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

    // Внешний ключ для Faculty
    [ForeignKey("Faculty")]
    public int FacultyID { get; set; }
    public virtual Faculty Faculty { get; set; }

    // Связь один ко многим с Students
    public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
}


