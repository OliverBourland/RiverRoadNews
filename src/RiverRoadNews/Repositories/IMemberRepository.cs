using RiverRoadNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverRoadNews.Repositories
{
    public interface IMemberRepository
    {
        Member GetMemberByName(string name);
        List<Member> GetAllMembers();
        string GetMemberByEmail(string email);
        DateTime GetJoinDate(string name);
        List<string> GetAllEmails();
        string GetMemberEmail(string name);

    }
}
