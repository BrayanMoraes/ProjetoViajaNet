﻿using Domain.Context;
using Domain.Entities;
using Infra.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repository
{
    public class ItemTypeRepository : IItemTypeRepository
    {
        private readonly ProjectContext _context;

        public ItemTypeRepository(ProjectContext context)
        {
            _context = context;
        }
        public ICollection<ItemType> GetAllItemTypes()
        {
            return _context.ItemTypes.ToList();
        }
    }
}
