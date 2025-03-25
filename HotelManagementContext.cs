using Microsoft.EntityFrameworkCore;
using HotelManagementAPI.Models;

namespace HotelManagementAPI.Data
{
    public class HotelManagementContext : DbContext
    {
        public HotelManagementContext(DbContextOptions<HotelManagementContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
