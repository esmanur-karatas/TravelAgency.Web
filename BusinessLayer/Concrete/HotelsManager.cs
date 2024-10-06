using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class HotelsManager : IHotelsService
    {
        IHotelsDal _hotelsDal;
        public HotelsManager(IHotelsDal hotelsDal)
        {
            _hotelsDal = hotelsDal;
        }

        public void TAdd(Hotels t)
        {
            _hotelsDal.Add(t);
        }

        public void TDelete(Hotels t)
        {
            _hotelsDal.Delete(t);
        }

        public List<Hotels> TGetAll()
        {
           return _hotelsDal.GetList();
        }

        public Hotels TGetById(int id)
        {
            return _hotelsDal.GetByID(id);
        }

        public void TUpdate(Hotels t)
        {
            _hotelsDal.Update(t);
        }
    }
}
