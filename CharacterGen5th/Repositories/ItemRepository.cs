﻿using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class ItemRepository : AbstractRepository, IItemRepository
    {
        public ItemRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Item> GetItems()
        {
            return this.context.Items.ToList();
        }

        public void CreateItem(Item newItem)
        {
            this.context.Items.Add(newItem);
            this.context.SaveChanges();
        }

        public Item FindItemById(int id)
        {
            return this.context.Items.Find(id);
        }

        public void UpdateItem(Item toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var toDelete = this.context.Items.Find(id);
            this.context.Items.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}