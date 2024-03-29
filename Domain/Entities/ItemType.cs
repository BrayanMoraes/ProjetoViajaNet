﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ItemType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
