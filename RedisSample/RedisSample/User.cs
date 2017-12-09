using System;
using System.Collections.Generic;
using System.Text;

namespace RedisSample
{
    public class User
    {
        public User()
        {
            this.BlogIds = new List<long>();
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public List<long> BlogIds { get; set; }
    }
}
