using SimpleEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFContext context = new EFContext())
            {
                UserProfile aslan = new UserProfile {
                    Name = "Aslan",
                    Image = "img.jpg",
                    Telephone = "+3454635464654"
                };
                context.UserProfiles.Add(aslan);
                context.SaveChanges();
                Console.WriteLine($"UserProfiles ID = {aslan.Id}");
            }
        }
    }
}
