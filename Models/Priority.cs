using System;
using System.Collections.Generic;

namespace Mindfulness_Hub_V3.Models
{
    public partial class Priority
    {
        public Priority()
        {
            Item = new HashSet<Item>();
        }

        public int PriorityId { get; set; }
        public string Description { get; set; }
        public int? MaxTime { get; set; }

        public virtual ICollection<Item> Item { get; set; }
    }
}
