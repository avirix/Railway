using System;
using System.ComponentModel.DataAnnotations;

using Railway.Models.Interfaces;

namespace Railway.Models.Entities
{
    public class Carriage : ICommonEntity
    {
        [Key] public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
