using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide t)
        {
            _guideDal.Add(t);
        }

        public void TChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public void TDelete(Guide t)
        {
           _guideDal.Delete(t);
        }

        public List<Guide> TGetAll()
        {
            return _guideDal.GetList();
        }

        public Guide TGetById(int id)
        {
           return _guideDal.GetByID(id);
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
