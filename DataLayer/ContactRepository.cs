using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class ContactRepository : IContactRepository
    {
        public void Delete(Contacts obj)
        {
            using (ContactEntities db = new ContactEntities())
            {
                db.Contacts.Attach(obj);
                db.Contacts.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Contacts> GetAll()
        {
            using (ContactEntities db = new ContactEntities())
            {
                return db.Contacts.ToList();
            }
        }

        public Contacts GetByID(int id)
        {
            using (ContactEntities db = new ContactEntities())
            {
                return db.Contacts.Find(id);
            }
        }

        public Contacts Insert(Contacts obj)
        {
            using (ContactEntities db = new ContactEntities())
            {
                db.Contacts.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Contacts obj)
        {
            using (ContactEntities db = new ContactEntities())
            {
                db.Contacts.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
