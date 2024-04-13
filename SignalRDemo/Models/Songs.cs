using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalRDemo.Models
{
    public class Song
    {
        public int SongId { get; set; }

        [Required]
        public string SongName { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
