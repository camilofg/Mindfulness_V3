using System;
using System.Collections.Generic;

namespace Mindfulness_Hub_V3.Models
{
    public partial class Profile
    {
        public Profile()
        {
            User = new HashSet<User>();
        }

        public int ProfileId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
