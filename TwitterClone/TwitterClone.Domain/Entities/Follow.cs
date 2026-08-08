using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        public Guid FollowerId { get; set; }
        public Guid FollowingId { get; set; }
        public DateTime FollowedAt { get; set; }
    }
}
