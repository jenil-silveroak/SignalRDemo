using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SignalRDemo.Models
{
    public class Singer
    {
        public int SingerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
