using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RestuarantManager : IRestuarantService
    {
        private readonly IRestuarantDal _restuarantDal;

        public RestuarantManager(IRestuarantDal restuarantDal)
        {
            _restuarantDal = restuarantDal;
        }

        public void TAdd(Restuarant t)
        {
            _restuarantDal.Add(t);
        }

        public void TDelete(Restuarant t)
        {
            _restuarantDal.Delete(t);
        }

        public List<Restuarant> TGetAll()
        {
           return _restuarantDal.GetList();
        }

        public Restuarant TGetById(int id)
        {
            return _restuarantDal.GetByID(id);
        }

        public void TUpdate(Restuarant t)
        {
            _restuarantDal.Update(t);
        }
    }
}
