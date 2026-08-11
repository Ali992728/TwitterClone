using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid requestedByUserId) : base("FriendRequest")
        {
            RequestedByUserId = requestedByUserId;
        }

        public Guid RequestedByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribedRecord()
        {
            var baseRecord = base.DescribedRecord();
            return $"{baseRecord}, RequestedByUserId: {RequestedByUserId}";
        }
    }
}
