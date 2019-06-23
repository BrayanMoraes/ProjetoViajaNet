using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public int ItemTypeId { get; set; }
        public double Quantity { get; set; }
        public bool Confirmed { get; set; }

        public virtual ItemType ItemType { get; set; }
    }
}
