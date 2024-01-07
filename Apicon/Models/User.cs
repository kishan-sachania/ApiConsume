using System.ComponentModel.DataAnnotations;

namespace Apicon.Models
{
    public class User
    {
        
        public int personID { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? contact { get; set; }
    }
}
