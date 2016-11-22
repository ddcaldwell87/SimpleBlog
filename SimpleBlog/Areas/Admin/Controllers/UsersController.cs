using System.Web.Mvc;
using System.Linq;
using NHibernate.Linq;
using SimpleBlog.Infrastructure;
using SimpleBlog.Models;
using SimpleBlog.Areas.Admin.ViewModels;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")] // Allows access to this controller only if  user role is admin.
    [SelectedTab("users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View(new UsersIndex
            {
                Users = Database.Session.Query<User>().ToList()
            });
        }
    }
}