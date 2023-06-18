using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Model;

namespace BusinessLayer
{
   public static class ContactServices
    {
        static IContactRepository repository;
        static ContactServices()
        {
            repository = new ContactRepository();
        }
        public static List<Contacts>  GetAll()
        {
            return repository.GetAll();
        }
        public static Contacts GetByID (int id)
        {
            return repository.GetByID(id);
        }
        public static Contacts Insert (Contacts obj)
        {
            return repository.Insert(obj);
        }
        public static void Update (Contacts obj)
        {
            repository.Update(obj);
        }
        public static void Delete (Contacts obj)
        {
            repository.Delete(obj);
        }
    }
}
