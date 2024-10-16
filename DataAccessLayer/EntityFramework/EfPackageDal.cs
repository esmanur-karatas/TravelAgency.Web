using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfPackageDal : GenericRepository<Package>, IPackageDal
    {
        public List<Package> GetPackage()
        {
            using (var context = new Context())
            {
                var values = context.Packages.Take(4).OrderByDescending(x => x.PackageId).ToList();
                return values;
            }
        }
    }
}
