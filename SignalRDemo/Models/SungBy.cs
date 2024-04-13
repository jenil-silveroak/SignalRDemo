using System.ComponentModel.DataAnnotations;

namespace SignalRDemo.Models
{
    public class SungBy
    {
        public int SungById { get; set; }

        [Required]
        public int SingerId { get; set; }

        [Required]
        public int SongId { get; set; }
    }
}
