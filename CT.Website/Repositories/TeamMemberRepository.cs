using System.Collections.Generic;
using CT.Website.Models;
using CT.Website.Utils;

namespace CT.Website.Repositories
{
	public static class TeamMemberRepository
	{
		public static List<TeamMember> GetTeamMembers()
		{
			var teamMemberList = new List<TeamMember>();

			teamMemberList.Add(new TeamMember
			{
				Name = "Ancuta Gicoveanu",
				Positions = string.Join(", ", new List<string> {Positions.CoFounder, Positions.NetDeveloper }),
				Description = "Ancuta is a Developer with an experience of 5 years working with .NET technologies. " + 
							"In the last 2 years, she specialized in building websites using the .NET based Sitecore CMS.",
				Email = "ancuta.anisiei@gmail.com",
				ImageUrl = "/../Images/anca.jpg"
			});

			teamMemberList.Add(new TeamMember
			{
				Name = "Cristina Dragos",
				Positions = string.Join(", ", new List<string> { Positions.CoFounder, Positions.NetDeveloper }),
				Description = "Cristina has been working in IT for over 11 years. " + 
							"She started as a tester for 2 years, and then became a developer working with Progress technologies and briefly with Python. " + 
							"For the last 6 years, her focus was on working with .NET technologies. " + 
							"During this period, Cristina worked also with .NET based CMS's, such as EpiServer and Sitecore. " + 
							"Her experience with Sitecore spans over the last 4 years, becoming a Sitecore 8 Certified Developer in 2015.",
				Email = "cristina.prodan87@gmail.com",
				ImageUrl = "/../Images/cristina.jpg"
			});

			teamMemberList.Add(new TeamMember
			{
				Name = "Cosmin Popa",
				Positions = string.Join(", ", new List<string> { Positions.CoFounder, Positions.NetDeveloper }),
				Description = "Cosmin is a Senior Deveoper with an experience of 12 years working with .NET technologies. " + 
						"During this time, he also worked at a great extent with C++. " +
						"In the last 2 years, Cosmin specialized in building websites using the .NET based Sitecore CMS.",
				Email = "cosmin.c.popa@gmail.com",
				ImageUrl = "/../Images/cosmin.jpg"
			});

			return teamMemberList;
		}
	}
}