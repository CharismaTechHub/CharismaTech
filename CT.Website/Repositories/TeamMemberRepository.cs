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
				Name = "Anca Gicoveanu",
				Positions = string.Join(", ", new List<string> {Positions.CoFounder, Positions.NetDeveloper }),
				Description = "Anca is a Developer with an experience of 5 years working with .NET technologies. " + 
							"She possesses remarkable learning skills, being able to adapt quickly to challenges and to accumulate knowledge fast when she has to work with new technologies and tools. " +
                            "In the last 2 years, Anca specialized in building websites using the .NET based Sitecore CMS. " +
                            "For the last 3 years, she spent a lot of her time communicating with the clients, consulting them on the technical side and working on-site for a few months. She enjoys working as a consultant, being closer to the client and understanding the business behavior in depth.",
				Email = "ancuta.anisiei@gmail.com",
				ImageUrl = "/../Images/anca.jpg",
                Linkedin = "https://www.linkedin.com/in/ancutagicoveanu/"
            });

			teamMemberList.Add(new TeamMember
			{
				Name = "Cristina Dragos",
				Positions = string.Join(", ", new List<string> { Positions.CoFounder, Positions.NetDeveloper }),
				Description = "Cristina has been working in IT for over 11 years. " + 
							"She started as a tester for 2 years, and then became a developer working with Progress technologies and briefly with Python. " + 
							"For the last 6 years, her focus was on working with .NET technologies. " + 
							"During this period, Cristina worked also with .NET based CMS's, such as EpiServer and Sitecore. " + 
							"Her experience with Sitecore spans over the last 4 years, becoming a Sitecore 8 Certified Developer in 2015. " + 
                            "Cristina is our best asset when comes to organisational needs and the execution of SCRUM workflow in our projects - she is the person with the notebook and the pen around all the time, taking notes and remembering every detail.",
				Email = "cristina.prodan87@gmail.com",
				ImageUrl = "/../Images/cristina.jpg",
                Linkedin = "https://www.linkedin.com/in/cristina-drago%C5%9F-80500a79/"
            });

			teamMemberList.Add(new TeamMember
			{
				Name = "Cosmin Popa",
				Positions = string.Join(", ", new List<string> { Positions.CoFounder, Positions.NetDeveloper }),
				Description = "Cosmin is a Senior Developer with an experience of 12 years working with .NET technologies and more than 14 years of hands on experience as a developer. " + 
						"During this time, he also worked at a great extent with C++, cloud services, XCode, devops experience. " +
                        "In the last 2 years, Cosmin specialized in building websites using the .NET based Sitecore CMS. " +
                        "He is our technical Guru, being able to come up with strategies and solutions to any technical difficulty. He likes to be informed about the new technologies, reading, researching and experimenting all the time new tools and technologies. ",
				Email = "cosmin.c.popa@gmail.com",
				ImageUrl = "/../Images/cosmin.jpg",
                Linkedin = "https://www.linkedin.com/in/cosmincpopa/"
            });

			return teamMemberList;
		}
	}
}