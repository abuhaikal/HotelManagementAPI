using System;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementAPI.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        [MaxLength(100)]
        public string GuestName { get; set; }

        [Required]
        [MaxLength(20)]
        public string GuestContact { get; set; }

        [Required]
        public int RoomID { get; set; }

        [Required]
        public DateTime CheckIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
    }
}
