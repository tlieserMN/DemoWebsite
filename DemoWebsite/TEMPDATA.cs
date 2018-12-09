using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoWebsite.Models;

namespace DemoWebsite
{
    public static class TEMPDATA
    {
        public static HomeModel HOME = new HomeModel
        {
            Messages = new List<Message> {new Message
                {
                    ID = 1,
                    Header = "First Header",
                    Body = "This is the First body",
                    Sender = "Thomas Lieser"
                },
                new Message
                {
                    ID = 2,
                    Header = "Second Header",
                    Body = "This is the see body",
                    Sender = "Thomas Lieser"
                }
                }
        };

        public static MessagesModel MESSAGES = new MessagesModel
        {
            Conversations = new List<User>
            {
                new User
                {
                    ID = 1,
                    FirstName = "Sally",
                    LastName = "Johnson"
                },
                new User
                {
                    ID = 2,
                    FirstName = "John",
                    LastName = "Doe"
                },
                new User
                {
                    ID = 3,
                    FirstName = "Austin",
                    LastName = "Anderson"
                }
            }
        };

        public static List<Message> JOHNCONVERSATION = new List<Message>
        {
            new Message
                {
                    ID = 1,
                    Header = "Monday",
                    Body = "Hello Thomas how are you",
                    Sender = "John Doe"
                },
                new Message
                {
                    ID = 2,
                    Header = "Monday",
                    Body = "I am good how are you?",
                    Sender = "Thomas Lieser"
                }
        };

        public static List<Message> AUSTINCONVERSATION = new List<Message>
        {
            new Message
                {
                    ID = 3,
                    Header = "School",
                    Body = "Hey thomas did you finish that school project?",
                    Sender = "Austin Anderson"
                },
                new Message
                {
                    ID = 4,
                    Header = "school response",
                    Body = "Yes I did, do you want to meet tomorrow about it?",
                    Sender = "Thomas Lieser"
                },
                new Message
                {
                    ID = 5,
                    Header = "School",
                    Body = "Ya that would be great. Wanna meet at noon?",
                    Sender = "Austin Anderson"
                },
                new Message
                {
                    ID = 6,
                    Header = "Project",
                    Body = "That works",
                    Sender = "Thomas Lieser"
                }
        };

        public static List<Message> SALLYCONVERSATION = new List<Message>
        {
            new Message
                {
                    ID = 7,
                    Header = "Hey",
                    Body = "Whats up?",
                    Sender = "Sally Johnson"
                }
        };

        public static User LOGEDINUSER = new User
        {
            ID = 4,
            FirstName = "Thomas",
            LastName = "Lieser",
            Email = "tlieserMN@gmail.com",
            Age = 20,
            Birthday = "9/24/1998"
        };
    }
}