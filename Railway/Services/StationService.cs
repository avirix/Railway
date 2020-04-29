using System.Collections.Generic;
using System.Linq;

using Railway.Models.Abstract;
using Railway.Models.Database;
using Railway.Models.Entities;
using Railway.Models.Interfaces;

namespace Railway.Services
{
    public class StationService : IService<Station>
    {
        public BaseRepository<Station> Repository { get; set; }

        public StationService(IteaDbContext dbContext)
        {
            Repository = new BaseRepository<Station>(dbContext);
        }

        public void Create(Station item)
        {
            Repository.Create(item);
        }

        public void Delete(int item)
        {
            Repository.Remove(item);
        }

        public List<Station> GetAll()
        {
            return Repository.GetAll().ToList();
        }

        public Station Update(int id, Station updatedItem)
        {
            Repository.Update(updatedItem);
            return updatedItem;
        }

        public Station FindById(int id)
        {
            return Repository.FindById(id);
        }

        public IQueryable<Station> GetQuery()
        {
            return Repository.GetAll();
        }
    }
}
