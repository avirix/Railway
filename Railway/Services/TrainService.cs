using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Railway.Models.Abstract;
using Railway.Models.Database;
using Railway.Models.Entities;
using Railway.Models.Interfaces;
namespace Railway.Services
{
    public class TrainService : IService<Train>
    {
        public BaseRepository<Train> Repository { get; set; }

        public TrainService(IteaDbContext dbContext)
        {
            Repository = new BaseRepository<Train>(dbContext);
        }

        public void Create(Train item)
        {
            Repository.Create(item);
        }

        public void Delete(int item)
        {
            Repository.Remove(item);
        }

        public List<Train> GetAll()
        {
            return Repository.GetAll().ToList();
        }

        public Train Update(int id, Train updatedItem)
        {
            Repository.Update(updatedItem);
            return updatedItem;
        }

        public Train FindById(int id)
        {
            return Repository.FindById(id);
        }

        public IQueryable<Train> GetQuery()
        {
            return Repository.GetAll();
        }

    }
}
