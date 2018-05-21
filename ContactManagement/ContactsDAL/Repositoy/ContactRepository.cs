using ContactsDAL.Context;
using ContactsDAL.IRepository;
using DataContracts;
using System.Collections.Generic;
using System.Linq;

namespace ContactsDAL.Repositoy
{
    public class ContactRepository : IContactRepository
    {
        private DatabaseContext context = new DatabaseContext();

        public IEnumerable<Contact> GetAll()
        {
            return context.Set<Contact>();
        }
        public Contact GetByID(int id)
        {
            return context.Set<Contact>().Find(id);
        }
        public int Insert(Contact entity)
        {
            context.Set<Contact>().Add(entity);
            var ctx = context.SaveChanges();

            return entity.ContactId;
        }
        public void Update(Contact entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public Contact Delete(Contact entity)
        {
            if (entity != null)
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
            return entity;
        }
    }
}
