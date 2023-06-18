using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public interface IContactRepository
    {
        List<Contacts> GetAll(); // database table name
        Contacts GetByID(int id);
        Contacts Insert(Contacts obj);
        void Update(Contacts obj);
        void Delete(Contacts obj);
    }
}
