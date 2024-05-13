using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models;
public class RoomMaintenance
{
    [Key]
    public int MaintenanceID { get; set; }

   
    [ForeignKey("Room")]
    public int RoomID { get; set; }
    public virtual Room Room { get; set; }

    public DateTime DateScheduled { get; set; }
    [Required]
    public string Description { get; set; }
}
