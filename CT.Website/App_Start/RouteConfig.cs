using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CT.Website
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "AboutUs",
				url: "about-us",
				defaults: new { controller = "Home", action = "About" }
			);

			routes.MapRoute(
				name: "Contact",
				url: "contact",
				defaults: new { controller = "ContactUs", action = "SendEmail" }
			);

			routes.MapRoute(
				name: "OurTeam",
				url: "our-team",
				defaults: new { controller = "Home", action = "OurTeam" }
			);

			routes.MapRoute(
				name: "Default",
				url: "{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
