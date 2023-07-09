using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Footballer
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public int Number { get; set; }

        //[ForeignKey("Client")]
        //public Guid ClientId { get; set; }
        //public User Client { get; set; }
    }
}
