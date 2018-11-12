using LandonApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonApi.Data
{
    public class HotelApiDbContext : DbContext
    {
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }

        public HotelApiDbContext(DbContextOptions options) : base(options)
        {
            
        }

    }
}
