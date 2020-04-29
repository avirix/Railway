using System.Collections.Generic;
using System.Linq;

using Railway.Models.Abstract;
using Railway.Models.Database;
using Railway.Models.Entities;
using Railway.Models.Interfaces;

namespace Railway.Services
{
    public class CarriageSService : IService<Carriage>
    {
        public BaseRepository<Carriage> Repository { get; set; }

        public CarriageSService(IteaDbContext dbContext)
        {
            Repository = new BaseRepository<Carriage>(dbContext);
        }

        public void Create(Carriage item)
        {
            Repository.Create(item);
        }

        public void Delete(int item)
        {
            Repository.Remove(item);
        }

        public List<Carriage> GetAll()
        {
            return Repository.GetAll().ToList();
        }

        public Carriage Update(int id, Carriage updatedItem)
        {
            Repository.Update(updatedItem);
            return updatedItem;
        }

        public Carriage FindById(int id)
        {
            return Repository.FindById(id);
        }

        public IQueryable<Carriage> GetQuery()
        {
            return Repository.GetAll();
        }
    }
}
