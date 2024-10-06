using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Add(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public List<Destination> TGetAll()
        {
            return _destinationDal.GetList();
        }

        public Destination TGetById(int id)
        {
            return  _destinationDal.GetByID(id);
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
