using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod2.Models
{
    [Table("Subscribers")]
    public class Subscriber
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public Subscriber(string email)
        {
            Email = email;
        }

        public Subscriber()
        {
        }
    }
}
