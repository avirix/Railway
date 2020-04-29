using System;

namespace Railway.Models.Interfaces
{
    public interface ICommonEntity
    {
        int Id { get; set; }
        DateTime? Created { get; set; }
        DateTime? LastUpdated { get; set; }

    }
}
