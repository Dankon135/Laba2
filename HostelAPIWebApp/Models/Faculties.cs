using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class Faculty
{
    [Key]
    public int FacultyID { get; set; }
    [Required]
    public string Name { get; set; }
    public string DeanName { get; set; }

    
    public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();
}


