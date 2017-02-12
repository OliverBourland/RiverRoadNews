using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiverRoadNews.Repositories;
using RiverRoadNews.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RiverRoadNews.Controllers
{
    public class MessageController : Controller
    {
        
        private IMessageRepository messageRepo;
        private IMemberRepository memberRepo;
        public MessageController(IMessageRepository repo)
        {
            messageRepo = repo;
        }

        public MessageController(IMemberRepository repo)
        {
            memberRepo = repo;
        }
            // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //public ViewResult Forum()
        //{
        //    var repo = new MessageRepository();
        //    var messages = repo.GetAllMessagesNewestFirst();
        //    return View(messages);
        //}

        
    }
}
