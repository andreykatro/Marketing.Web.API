using Marketing.Web.API.Interfaces;
using Marketing.Web.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Marketing.Web.API.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly MarketingWebContext _context;

        public ContactRepository(MarketingWebContext context)
        {
            _context = context;
        }

        public IEnumerable<Contact> GetAll()
        {
            return _context.Contacts;
        }

        public bool Insert(Contact contact)
        {
            if (contact != null)
            {
                _context.Contacts.Add(contact);
                return (_context.SaveChanges() > 0) ? true : false;
            }
            return false;
        }

        public bool Update(Contact contact)
        {
            if (contact != null)
            {
                _context.Contacts.Update(contact);
                return (_context.SaveChanges() > 0) ? true : false;
            }
            return false;
        }
        public bool Delete(int id)
        {
            if (_context.Contacts.Any(c => c.Id == id))
            {
                var item = _context.Contacts.FirstOrDefault(c => c.Id == id);

                if (_context.SaveChanges() > 0)
                {
                    _context.Contacts.Remove(item);
                    return (_context.SaveChanges() > 0) ? true : false;
                }
            }

            return false;
        }

    }
}
