using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfFaqsDal : GenericRepository<FAQS>, IFaqsDal
    {
    }
}
