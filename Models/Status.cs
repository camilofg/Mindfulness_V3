using System;
using System.Collections.Generic;

namespace Mindfulness_Hub_V3.Models
{
    public partial class Status
    {
        public Status()
        {
            Item = new HashSet<Item>();
        }

        public int StatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Item> Item { get; set; }
    }
}
