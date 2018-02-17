using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CT.Website.Models
{
	public class TeamMember
	{
		public string Name { get; set; }

		public string Positions { get; set; }

		public string Description { get; set; }

		public string Email { get; set; }

		public string ImageUrl { get; set; }
	}
}