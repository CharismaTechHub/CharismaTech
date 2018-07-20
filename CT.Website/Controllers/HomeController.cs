﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CT.Website.Repositories;

namespace CT.Website.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
        }

        public ActionResult Services()
		{
			return View();
        }

    public ActionResult About()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}

		public ActionResult OurTeam()
		{
			var teamMmberList = TeamMemberRepository.GetTeamMembers();

			return View(teamMmberList);
		}
	}
}