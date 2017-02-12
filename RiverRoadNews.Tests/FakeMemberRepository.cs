using RiverRoadNews.Models;
using RiverRoadNews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverRoadNews.Tests
{
    public class FakeMemberRepository : IMemberRepository
    {
        public List<string> GetAllEmails()
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAllMembers()
        {
            var members = new List<Member>();

            members.Add(new Models.Member() { Name = "John Doe", Email = "johndoe@gmail.com", MemberSince = new DateTime(2012, 4, 1) });
            members.Add(new Models.Member() { Name = "Sam Jones", Email = "samjones@gmail.com", MemberSince = new DateTime(2011, 12, 30) });
            members.Add(new Models.Member() { Name = "Kathy Kay", Email = "kathykay@gmail.com", MemberSince = new DateTime(2013, 6, 24) });

            return members;
        }

        public DateTime GetJoinDate(string name)
        {
            throw new NotImplementedException();
        }

        public string GetMemberByEmail(string email)
        {
            var members = new List<Member>();
            MemberRepository repo = new MemberRepository();
            members = repo.GetAllMembers();
            foreach (var m in members)
            {
                if (m.Email == email)
                    return m.Name;
            }
            return null;
        }

        public Member GetMemberByName(string name)
        {
            throw new NotImplementedException();
        }

        public string GetMemberEmail(string name)
        {
            var members = new List<Member>();
            MemberRepository repo = new MemberRepository();
            members = repo.GetAllMembers();
            foreach (var m in members)
            {
                if (m.Name == name)
                    return m.Email;
            }
            return null;
        }
    }
}
