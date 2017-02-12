using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverRoadNews.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime MemberSince { get; set; }

    }
}
