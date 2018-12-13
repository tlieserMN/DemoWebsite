using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWebsite.Models
{
    public class Message
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
    }

    public class MessagesModel
    {
        public List<User> Conversations { get; set; }
    }

    public class ConversationModel
    {
        public List<Message> Messages { get; set; }
        public int ReceiverID { get; set; }
    }

    public class Test
    {
        [Key]
        public int ID { get; set; }
    }
}