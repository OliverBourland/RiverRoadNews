using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiverRoadNews.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RiverRoadNews.Controllers
{
    public class NewsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<NewsEvents> leads = new List<NewsEvents>();

            NewsEvents bigfoot = new NewsEvents();
            bigfoot.Title =  "Another Bigfoot Sighting!";
            bigfoot.Date = new DateTime(2017, 1, 15);
            bigfoot.Story = "Mrs. Fletcher was walking her dog pickles on the river side path when pickles stopped in her tracks and began urinating.  Mrs. Fletcher looked down in bewilderment.  Pickles on a normal day has great control of her blatter.  It was then that a crack of a branch in distance stirred Mrs. Fletcher's attention.  A large animal was walking on it's hind legs!" ;
            leads.Add(bigfoot);
            NewsEvents chickens = new NewsEvents();
            chickens.Title = "Only One Remains";
            chickens.Date = new DateTime(2017, 1, 16);
            chickens.Story = "Little Billy Briggs entered the chicken coop yesterday morning only to find one chicken.  The rest have mysteriously disappered.  Billy checked each of the hens sleeping quarters finding no chicken or egg.  The family would have to split the one egg Billy did find under Bertha their only ckicken.  The Briggs were all a little grouchy by the afternoon.";
            leads.Add(chickens);

            return View(leads.ToList());

        }

        public IActionResult TodaysNews()
        {
            return View();
        }

        public IActionResult Archive()
        {
            return View();
        }
    }
}
