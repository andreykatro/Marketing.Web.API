using Marketing.Web.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketing.Web.API.Interfaces
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        bool Insert(Contact contact);
        bool Update(Contact contact);
        bool Delete(int id);
    }
}
