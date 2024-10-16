using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IPackageService : IGenericService<Package>
    {
        public List<Package> TGetPackage();
    }
}
