using CT.Website.Models;

namespace CT.Website.Repositories
{
    public static class TextComponentRepository
    {
        public static TextComponent AboutUsComponent()
        {
            TextComponent aboutUsComponent = new TextComponent();
            aboutUsComponent.Title = "Who Are We";
            aboutUsComponent.Description = @"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                                        Aenean fermentum neque sit amet dolor ornare, eget pellentesque justo sollicitudin. Morbi tincidunt ligula elementum metus sodales porta.</p>
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
            aboutUsComponent.ColorClass = "section-color-light-blue";

            return aboutUsComponent;
        }

        public static TextComponent OurTeamComponent()
        {
            TextComponent ourTeamComponent = new TextComponent();
            ourTeamComponent.Title = "Our Team";
            ourTeamComponent.Description = @"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                                        Aenean fermentum neque sit amet dolor ornare, eget pellentesque justo sollicitudin. Morbi tincidunt ligula elementum metus sodales porta.</p>
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
            ourTeamComponent.LinkText = "More About Us";
            ourTeamComponent.LinkUrl = "/our-team";
            ourTeamComponent.ColorClass = "section-color-light-black";

            return ourTeamComponent;
        }

        public static TextComponent OurServicesComponent()
        {
            TextComponent ourServicesComponent = new TextComponent();
            ourServicesComponent.Title = "What We Offer";
            ourServicesComponent.Description = @"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                                        Aenean fermentum neque sit amet dolor ornare, eget pellentesque justo sollicitudin. Morbi tincidunt ligula elementum metus sodales porta.</p>
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
            ourServicesComponent.LinkText = "More About Us";
            ourServicesComponent.LinkUrl = "/our--sevices";
            ourServicesComponent.ColorClass = "section-color-light-blue";

            return ourServicesComponent;
        }
    }
}