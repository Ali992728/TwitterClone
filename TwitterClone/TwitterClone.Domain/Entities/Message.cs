using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; }

        public Message()
        {
            Id = Guid.NewGuid();
            SenderId = Guid.NewGuid();
            ReceiverId = Guid.NewGuid();
        }
    }
}
