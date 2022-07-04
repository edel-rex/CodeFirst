using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Storages
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Data { get; set; }
        public Users? User { get; set; }
    }
}
