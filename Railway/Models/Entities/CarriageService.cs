using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Railway.Models.Interfaces;

namespace Railway.Models.Entities
{
    public class CarriageService : ICommonEntity
    {
        [Key] public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastUpdated { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CarriageId { get; set; }
        [ForeignKey("CarriageId")] public Carriage Carriage { get; set; }
    }
}
