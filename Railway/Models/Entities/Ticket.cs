using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Railway.Models.Interfaces;

namespace Railway.Models.Entities
{
    public class Ticket : ICommonEntity
    {
        [Key] public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastUpdated { get; set; }

        public decimal Price { get; set; }

        public int PlaceNumber { get; set; }

        public int CarriageId { get; set; }
        [ForeignKey("CarriageId")] public Carriage Carriage { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")] public User User { get; set; }

        public int StartStationId { get; set; }
        [ForeignKey("StartStationId")] public Station StartStation { get; set; }

        public int FinishStationId { get; set; }
        [ForeignKey("FinishStationId")] public Station FinishStation { get; set; }

    }
}
