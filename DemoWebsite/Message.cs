namespace DemoWebsite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Sender { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }

    public partial class Conversation
    {
        public List<Message> Messages { get; set; }
        public int FriendID { get; set; }
    }

    public partial class Friend
    {
        [Key]
        public int UserID { get; set; }
        public string Sender { get; set; }
    }

}
