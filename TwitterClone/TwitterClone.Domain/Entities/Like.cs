using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
        public DateTime LikedAt { get; set; }
    }
}
