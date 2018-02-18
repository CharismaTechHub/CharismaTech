using System.Web.Mvc;
using System.Web.UI.WebControls;
using CT.Website.Models;

namespace CT.Website.Controllers
{
    public class ContactUsController : Controller
    {
        [HttpGet]
        public ActionResult SendEmail()
        {
            User currentUser = new User();
            return PartialView(currentUser);
        }

        [HttpPost]
        public ActionResult SendEmail(User currentUser)
        {
            return PartialView(currentUser);
        }
    }
}