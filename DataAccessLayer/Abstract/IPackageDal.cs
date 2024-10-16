using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPackageDal : IGenericDal<Package>
    {
        public List<Package> GetPackage();
    }
}
