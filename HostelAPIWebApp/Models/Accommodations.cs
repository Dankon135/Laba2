using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class Accommodation
{
    public int AccommodationID { get; set; }
    public int StudentID { get; set; }
    public int RoomID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual Student Student { get; set; }
    public virtual Room Room { get; set; }
}
