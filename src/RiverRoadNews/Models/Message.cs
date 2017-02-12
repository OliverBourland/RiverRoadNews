using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverRoadNews.Models
{
    public class Message
    {
        private List<Member> members = new List<Member>();
        public int MessageID { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public Member From { get; set; }
        public string Topic { get; set; }
        public List<Member> Members { get { return members; } }
    }
}
