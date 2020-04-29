using System;
using System.ComponentModel.DataAnnotations;

using Railway.Models.Interfaces;

namespace Railway.Models.Entities
{
    public enum StationType
    {
        Small,
        Middle,
        Big
    }

    public class Station : ICommonEntity
    {
        [Key] public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastUpdated { get; set; }

        public string StationName { get; set; }
        public string CityName { get; set; }

        public StationType StationType { get; set; }
    }
}
