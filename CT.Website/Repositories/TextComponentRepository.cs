using CT.Website.Models;

namespace CT.Website.Repositories
{
    public static class TextComponentRepository
    {
        public static TextComponent AboutUsComponent()
        {
            TextComponent aboutUsComponent = new TextComponent();
            aboutUsComponent.Title = "Who We Are";
            aboutUsComponent.Description = @"<p>Our company started from the desire of three passionate developers who decided to take on the IT world.</p>                                       
                                        <p>Thus, CharismaTech was founded in January 2018.</p>";
            aboutUsComponent.LinkText = "Want to know more?";
            aboutUsComponent.LinkUrl = "/about-us";
            aboutUsComponent.ColorClass = "section-color-light-black";

            return aboutUsComponent;
        }

        public static TextComponent OurTeamComponent()
        {
            TextComponent ourTeamComponent = new TextComponent();
            ourTeamComponent.Title = "Our Team";
            ourTeamComponent.Description = @"<p>Our team is prepared to support you and your business decisions.</p>";
            ourTeamComponent.LinkText = "More About Us";
            ourTeamComponent.LinkUrl = "/our-team";
            ourTeamComponent.ColorClass = "section-color-light-white";

            return ourTeamComponent;
        }

        public static TextComponent OurServicesComponent()
        {
            TextComponent ourServicesComponent = new TextComponent();
            ourServicesComponent.Title = "Our Services";
            ourServicesComponent.Description = @"<p>Need help developing or improving your software service or application? Maybe we can help you!</p>";
            ourServicesComponent.LinkText = "Check out more";
            ourServicesComponent.LinkUrl = "/our--sevices";
            ourServicesComponent.ColorClass = "section-color-light-black";

            return ourServicesComponent;
        }
    }
}