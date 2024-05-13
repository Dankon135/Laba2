using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class Accommodation
{
    [Key]
    public int AccommodationID { get; set; }

    // Внешний ключ для Student
    [ForeignKey("Student")]
    public int StudentID { get; set; }
    public virtual Student Student { get; set; }

    // Внешний ключ для Room
    [ForeignKey("Room")]
    public int RoomID { get; set; }
    public virtual Room Room { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
