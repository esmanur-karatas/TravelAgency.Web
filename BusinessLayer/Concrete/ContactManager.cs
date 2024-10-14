using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact t)
        {
            _contactDal.Add(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public List<Contact> TGetAll()
        {
           return _contactDal.GetList();
        }

        public Contact TGetById(int id)
        {
           return _contactDal.GetByID(id);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
