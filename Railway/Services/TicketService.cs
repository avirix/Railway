using System.Collections.Generic;
using System.Linq;

using Railway.Models.Abstract;
using Railway.Models.Database;
using Railway.Models.Entities;
using Railway.Models.Interfaces;

namespace Railway.Services
{
    public class TicketService : IService<Ticket>
    {
        public BaseRepository<Ticket> Repository { get; set; }

        public TicketService(IteaDbContext dbContext)
        {
            Repository = new BaseRepository<Ticket>(dbContext);
        }

        public void Create(Ticket item)
        {
            Repository.Create(item);
        }

        public void Delete(int item)
        {
            Repository.Remove(item);
        }

        public List<Ticket> GetAll()
        {
            return Repository.GetAll().ToList();
        }

        public Ticket Update(int id, Ticket updatedItem)
        {
            Repository.Update(updatedItem);
            return updatedItem;
        }

        public Ticket FindById(int id)
        {
            return Repository.FindById(id);
        }

        public IQueryable<Ticket> GetQuery()
        {
            return Repository.GetAll();
        }
    }
}
