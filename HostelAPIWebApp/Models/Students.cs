using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class Student
{
    [Key]
    public int StudentID { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    // Внешний ключ для Department
    [ForeignKey("Department")]
    public int DepartmentID { get; set; }
    public virtual Department Department { get; set; }

    // Связь один к одному с Accommodation
    public virtual Accommodation Accommodation { get; set; }
}
