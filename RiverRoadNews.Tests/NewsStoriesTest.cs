using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiverRoadNews.Models;
using Xunit;
using RiverRoadNews.Controllers;

namespace RiverRoadNews.Tests
{
    public class NewsStoriesTest
    {
        [Fact]
        public void CanChangeNewsEventTitle()
        {
            //Arrange
            var n = new NewsEvents { Title = "Test" };

            //Act
            n.Title = "New Name";

            //Assert
            Assert.Equal("New Name", n.Title);
        }

        [Fact]
        public void CanChangeNewsEventDate()
        {
            //Arrange
            var n = new NewsEvents();

            //Act
            n.Date = new DateTime(2016, 1, 3);

            //Assert
            Assert.Equal(new DateTime(2016, 1, 3), n.Date);
        }

        [Fact]
        public void CanChangeNewsEventStory()
        {
            //Arrange
            var n = new NewsEvents { Story = "Test" };

            //Act
            n.Story = "New Name";

            //Assert
            Assert.Equal("New Name", n.Story);
        }

        [Fact]
        public void NewsEventDateIsValid()
        {
            //Arrange
            var n = new NewsEvents();

            //Act
            //n.Date = new DateTime(2018, 12, 12);

            //Assert
            Exception ex = Assert.Throws<Exception>( () => n.Date = new DateTime(2018,1,1));
            Assert.Equal("Can not set to future date.", ex.Message);
        }



        [Fact]
        public void NewsEventStoryCantBeBlank()
        {
            //Arrange
            NewsEvents n = new NewsEvents { Story = "Test" };

            //Act
           // n.Story = "";

            //Assert
            Exception ex = Assert.Throws<Exception>(() => n.Story = "");

            Assert.Equal("Can't post empty story.", ex.Message);
        }

        [Fact]
        public void ControllerRepositoryMatchesFake()
        {

            // Arrange
            FakeMessageRepository repository = new FakeMessageRepository();
            MessageController controller = new MessageController(repository);
            
            // Act
           
                   
            List<Message> messages = controller.Forum().ViewData.Model as List<Message>;

            // Assert

            Assert.Equal(repository.GetAllMessagesNewestFirst()[0].Body, messages[0].Body);
            Assert.Equal(repository.GetAllMessagesNewestFirst()[0].From.Name, messages[0].From.Name);
            Assert.Equal(repository.GetAllMessagesNewestFirst()[1].Date, messages[1].Date);
            Assert.Equal(repository.GetAllMessagesNewestFirst()[1].Topic, messages[1].Topic);
        }

        [Fact]
        public void ControllerMemberMessagesMatchFake()
        {
            // Arrange
            FakeMessageRepository repository = new FakeMessageRepository();
            var fakeMemberMessages = new List<Message>();

            MessageController controller = new MessageController(repository);
            var controllerMemberMessages = new List<Message>();

            // Act          
            List<Message> messages = controller.Forum().ViewData.Model as List<Message>;
            fakeMemberMessages = repository.GetAllMessagesFromMember("John Doe");
            foreach (var m in messages)
            {
                if (m.From.Name == "John Doe")
                    controllerMemberMessages.Add(m);
            }
            // Assert

            Assert.Equal(controllerMemberMessages.Count,fakeMemberMessages.Count);
        }

        [Fact]
        public void ControllerMemberEmailMatchesFake()
        {
            // Arrange
            FakeMemberRepository memRepo = new FakeMemberRepository();
            string repoEmail;

            FakeMessageRepository repository = new FakeMessageRepository();
            MessageController controller = new MessageController(repository);
            string controllerEmail = "";

            // Act          
            List<Message> controllerMembers = controller.Forum().ViewData.Model as List<Message>;
            foreach (var m in controllerMembers)
                if (m.From.Name == "John Doe")
                    controllerEmail = m.From.Email;

            repoEmail = memRepo.GetMemberEmail("John Doe");

            // Assert

            Assert.Equal(repoEmail,controllerEmail);
        }

        [Fact]
        public void ControllerTopicMatchesFake()
        {
            // Arrange
            FakeMessageRepository repository = new FakeMessageRepository();           
            MessageController controller = new MessageController(repository);

            // Act                     
            List<Message> controlMess = controller.Forum().ViewData.Model as List<Message>;

            List<Message> repoTopic = repository.GetMessagesByTopic("Bigfoot");
            // Assert

            Assert.Equal(repoTopic[0].Topic, controlMess[0].Topic);
        }

   

    }
}
