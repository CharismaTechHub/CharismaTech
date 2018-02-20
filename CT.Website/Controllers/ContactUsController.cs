using System.Web.Mvc;
using System.Web.UI.WebControls;
using CT.Website.Models;
using CT.Website.Repositories;

namespace CT.Website.Controllers
{
    public class ContactUsController : Controller
    {
        [HttpGet]
        public PartialViewResult SendEmail()
        {
            User currentUser = new User();
            ViewBag.Subtitle = "Get in touch and start unlocking the power of your data today.";
            return PartialView(currentUser);
        }

        [HttpPost]
        public PartialViewResult SendEmail(User currentUser)
        {
            bool result = EmailSenderRepository.SendNotification(currentUser);

            if (result)
            {
                ViewBag.Subtitle = "Thank you very much for contacting us. We will get back to you soon.";
                return PartialView("/Views/ContactUs/FormResult.cshtml");
            }
            else
            {
                ViewBag.Subtitle = "An error occured on the server. We are sorry for the inconvenience, please try again.";
                return PartialView("/Views/ContactUs/FormResult.cshtml");
            }
        }
    }
}