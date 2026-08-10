using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
        public DateTime RetweetedAt { get; set; }

        public Retweet()
        {
            UserId = Guid.NewGuid();
            TweetId = Guid.NewGuid();
        }
    }
}
