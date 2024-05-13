using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class Room
{
    [Key]
    public int RoomID { get; set; }
    [Required]
    public string RoomNumber { get; set; }
    public int Capacity { get; set; }

    
    public virtual ICollection<Accommodation> Accommodations { get; set; } = new HashSet<Accommodation>();
    public virtual ICollection<RoomMaintenance> RoomMaintenances { get; set; } = new HashSet<RoomMaintenance>();
}

