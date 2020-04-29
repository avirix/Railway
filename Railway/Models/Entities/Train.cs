using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Railway.Models.Interfaces;

namespace Railway.Models.Entities
{
    public enum TrainType
    {
        Express,
        Common,
        Local
    }

    public class Train : ICommonEntity
    {
        [Key] public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastUpdated { get; set; }

        public int TrainNumber { get; set; }

        public TrainType Type { get; set; }

        public List<Carriage> Carriages { get; set; }

        public List<Station> Stations { get; set; }
    }
}
