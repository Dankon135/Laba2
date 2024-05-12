using Microsoft.EntityFrameworkCore;
using HostelAPIWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelAPIWebApp.Models
{
    public class HostelAPIContext : DbContext
    {
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Accommodation> Accommodations { get; set; }
        public virtual DbSet<RoomMaintenance> RoomMaintenances { get; set; }

        public HostelAPIContext(DbContextOptions<HostelAPIContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
