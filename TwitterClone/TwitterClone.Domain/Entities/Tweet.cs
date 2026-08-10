using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public string Content { get; set; }

        public Tweet()
        {
            Id = Guid.NewGuid();
            AuthorId = Guid.NewGuid();
        }
    }
}
