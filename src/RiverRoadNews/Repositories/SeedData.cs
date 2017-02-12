using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RiverRoadNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverRoadNews.Repositories
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.Messages.Any())
            {
                Member member = new Member { Name = "Steve Jones", Email = "steve@gmail.com", MemberSince = new DateTime(2017,2,1) };
                context.Members.Add(member);
                Message message = new Message { Subject = "Missing Chickens", Body = "Has anyone seem my chickens?", Topic = "Chickens", Date = DateTime.Parse("2/2/2017") };
                message.Members.Add(member);
                context.Messages.Add(message);

                member = new Member { Name = "Kathy Mills", Email = "kathy@gmail.com", MemberSince = new DateTime(2017, 2, 20) };
                context.Members.Add(member);
                message = new Message { Subject = "Found Chickens", Body = "I found some chickens.", Topic = "Chickens", Date = DateTime.Parse("2/3/2017") };
                message.Members.Add(member);
                context.Messages.Add(message);

                member = new Member { Name = "Jon Haggard", Email = "jon@gmail.com", MemberSince = new DateTime(2017, 2, 15) };
                context.Members.Add(member);
                message = new Message { Subject = "Strange Creature", Body = "I saw something strange in the creek today.", Topic = "Bigfoot", Date = DateTime.Parse("2/4/2017") };
                message.Members.Add(member);
                context.Messages.Add(message);

                member = new Member { Name = "Hope Landon", Email = "hope@gmail.com", MemberSince = new DateTime(2017, 2, 12) };
                context.Members.Add(member);
                message = new Message { Subject = "Creature on hind legs", Body = "I was in my garden when a I saw a creature walking on its hind legs.", Topic = "Bigfoot", Date = DateTime.Parse("2/5/2017") };
                message.Members.Add(member);
                context.Messages.Add(message);
            }
        }
    }
}
