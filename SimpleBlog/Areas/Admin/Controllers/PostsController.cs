using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")] // Allows access to this controller only if user role is admin.
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}