
using CT.Website.Models;
using System.Collections.Generic;

namespace CT.Website.Repositories
{
    public static class ServiceRepository
    {

        public static List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            Service service1 = new Service();
            service1.Title = "Software Development";
            service1.Description = "With more than 7 years of experience and complementary knowledge, we provide Sitecore";
            service1.TopImage = true;
            service1.ImageUrl = "/../Images/services1.jpg";

            Service service2 = new Service();
            service2.Title = "Software Support";
            service2.Description = "If your busness requires permanent support for your employees.";
            service2.TopImage = false;
            service2.ImageUrl = "/../Images/services2.jpg";

            Service service3 = new Service();
            service3.Title = "Project Management";
            service3.Description = "You need someone to really understand you? Software wise, we can help you.";
            service3.TopImage = true;
            service3.ImageUrl = "/../Images/services3.jpg";

            services.Add(service1);
            services.Add(service2);
            services.Add(service3);

            return services;
        }
    }
}