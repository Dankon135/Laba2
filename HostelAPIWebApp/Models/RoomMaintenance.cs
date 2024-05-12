using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class RoomMaintenance
{
    public int MaintenanceID { get; set; }
    public int RoomID { get; set; }
    public DateTime DateScheduled { get; set; }
    public string Description { get; set; }
    public virtual Room Room { get; set; }
}
