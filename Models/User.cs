using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        
        public string? Name { get; set; }
       
        public int Age { get; set; }
        public ICollection<Storages>? Storage { get; set; }
    }
}
