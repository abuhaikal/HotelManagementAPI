using System.ComponentModel.DataAnnotations;

namespace HotelManagementAPI.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        [Required]
        [MaxLength(10)]
        public string RoomNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoomType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
    }
}