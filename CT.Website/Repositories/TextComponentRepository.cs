﻿using CT.Website.Models;

namespace CT.Website.Repositories
{
    public static class TextComponentRepository
    {
        public static TextComponent AboutUsComponent()
        {
            TextComponent aboutUsComponent = new TextComponent();
            aboutUsComponent.Title = "Who We Are";
            aboutUsComponent.Description = @"<p>We are three passionate developers who decided to take on the IT world, offering quality software solutions to our clients.</p>
                                        <p></p>
                                        <p>
                                        Aenean vitae sodales lacus. Ut lectus quam, dapibus ac rhoncus ut, mollis at urna. Cras nec pretium est. Ut ultricies quis nisl in imperdiet. 
                                        Donec varius ac ex eget malesuada. Nunc rutrum nunc nec cursus fringilla. Praesent sollicitudin metus quam, a commodo neque ullamcorper vel.</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                                        Aenean fermentum neque sit amet dolor ornare, eget pellentesque justo sollicitudin. Morbi tincidunt ligula elementum metus sodales porta.</p>
                                        <p></p>
                                        <p>
                                        Aenean vitae sodales lacus. Ut lectus quam, dapibus ac rhoncus ut, mollis at urna. Cras nec pretium est. Ut ultricies quis nisl in imperdiet. 
                                        Donec varius ac ex eget malesuada. Nunc rutrum nunc nec cursus fringilla. Praesent sollicitudin metus quam, a commodo neque ullamcorper vel.</p>";
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