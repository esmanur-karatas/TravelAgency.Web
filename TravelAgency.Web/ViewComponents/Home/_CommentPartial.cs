using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.Home
{
    public class _CommentPartial : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke()
        {
            var value = commentManager.TGetAll();
            return View(value);
        }
    }
}
