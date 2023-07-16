using DataAccessLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Footballer : BaseEntity
    {
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
