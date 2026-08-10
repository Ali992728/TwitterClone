using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
        public DateTime BookmarkedAt { get; set; }

        public Bookmark()
        {
            UserId = Guid.NewGuid();
            TweetId = Guid.NewGuid();
        }
    }
}
