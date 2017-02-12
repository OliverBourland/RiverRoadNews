using RiverRoadNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverRoadNews.Repositories
{
    public interface IMessageRepository
    {
        Message GetMessageByName(string name);
        List<Message> GetMessagesByTopic(string topic);
        List<Message> GetAllMessagesFromMember(Member name);
        List<Message> GetAllMessagesNewestFirst();
    }
}
