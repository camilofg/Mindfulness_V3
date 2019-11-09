using System;
using System.Collections.Generic;

namespace Mindfulness_Hub_V3.Models
{
    public partial class User
    {
        public User()
        {
            Item = new HashSet<Item>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public string SecuritySalt { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int ProfileId { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
