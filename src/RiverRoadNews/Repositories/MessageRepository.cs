using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiverRoadNews.Models;

namespace RiverRoadNews.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private ApplicationDbContext context;

        public MessageRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }



        public List<Message> GetAllMessagesFromMember(Member member)
        {
            return (from b in context.Messages
                    where b.Members.Contains(member)
                    select b).ToList();

            //List<Message> memberMessages = new List<Message>();
            //MessageRepository repo = new MessageRepository();
            //memberMessages = repo.GetAllMessagesNewestFirst();
            //var selectMember = new List<Message>();

            //foreach (var m in memberMessages)
            //{
            //    if (m.From.Name == name)
            //        selectMember.Add(m);
            //}
            //return selectMember;
        }

        public IEnumerable<Message> GetAllMessagesNewestFirst()
        {
            return context.Messages;

            //var messages = new List<Message>();
            //List<Member> members = memberRepo.GetAllMembers();           
            //messages.Add(new Message() { From = members[0], Date = new DateTime(2017, 2, 2), Topic = "Bigfoot", Subject = "Chickens Missing", Body = "Chickens made a big fuss last night but I was to tired to get up.  This morning all my chickens gone, sad!" });
            //messages.Add(new Message() { From = members[1], Date = new DateTime(2017, 2, 3), Topic = "Bigfoot", Subject = "Fresh Tracks", Body = "Fresh tracks were found this morning by officer Columbo.  Columbo said they can't be more than a day old." });
            //return messages;
        }

        public Message GetMessageByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessagesByTopic(string topic)
        {
            throw new NotImplementedException();

            //List<Message> allMessages = new List<Message>();
            //List<Message> topicMessages = new List<Message>();
            //MessageRepository repo = new MessageRepository();
            //allMessages = repo.GetAllMessagesNewestFirst();
            //foreach (var m in allMessages)
            //    if (m.Topic == topic)
            //        topicMessages.Add(m);
            //return topicMessages;

        }

        List<Message> IMessageRepository.GetAllMessagesNewestFirst()
        {
            throw new NotImplementedException();
        }
    }
}
