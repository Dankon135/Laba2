using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class Room
{
    public int RoomID { get; set; }
    public string RoomNumber { get; set; }
    public int Capacity { get; set; }
    public virtual ICollection<Accommodation> Accommodations { get; set; }
    public virtual ICollection<RoomMaintenance> RoomMaintenances { get; set; }

    public Room()
    {
        Accommodations = new HashSet<Accommodation>();
        RoomMaintenances = new HashSet<RoomMaintenance>();
    }
}

