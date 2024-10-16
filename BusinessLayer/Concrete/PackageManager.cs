using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PackageManager : IPackageService
    {
        private readonly IPackageDal _packageDal;

        public PackageManager(IPackageDal packageDal)
        {
            _packageDal = packageDal;
        }

        public void TAdd(Package t)
        {
            _packageDal.Add(t);
        }

        public void TDelete(Package t)
        {
            _packageDal.Delete(t);
        }

        public List<Package> TGetAll()
        {
            return _packageDal.GetList();
        }

        public Package TGetById(int id)
        {
            return _packageDal.GetByID(id);
        }

        public List<Package> TGetPackage()
        {
            return _packageDal.GetPackage();
        }

        public void TUpdate(Package t)
        {
            _packageDal.Update(t);
        }
    }
}
