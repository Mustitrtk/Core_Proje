using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal) {
            _contactDal = contactDal;
        }

        public List<Contact> GetAll()
        {
            return _contactDal.Get();
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TAdd(Contact t)
        {
            _contactDal.Add(t);
        }

        public void TDelete(int id)
        {
            _contactDal.DeleteById(id);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
