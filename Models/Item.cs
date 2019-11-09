using System;
using System.Collections.Generic;

namespace Mindfulness_Hub_V3.Models
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public DateTime? DateLine { get; set; }
        public DateTime CreationDate { get; set; }
        public int PriorityId { get; set; }

        public virtual Priority Priority { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
