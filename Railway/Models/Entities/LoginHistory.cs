using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Railway.Models.Interfaces;

namespace Railway.Models.Entities
{
    public class LoginHistory : IIteaModel
    {
        [Key] public int Id { get; set; }
        public string IPAddress { get; set; }
        public DateTime LoginTime { get; set; }
        public string UserDevice { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")] public User User { get; set; }
    }
}
