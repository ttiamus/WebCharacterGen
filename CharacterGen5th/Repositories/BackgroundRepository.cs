﻿using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class BackgroundRepository : AbstractRepository , IBackgroundRepository
    {
        public BackgroundRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Background> GetBackgrounds()
        {
            return this.context.Backgrounds.ToList();
        }

        public void CreateBackground(Background newBackground)
        {
            this.context.Backgrounds.Add(newBackground);
            this.context.SaveChanges();
        }

        public Background FindBackgroundById(int id)
        {
            return this.context.Backgrounds.Find(id);
        }

        public void UpdateBackground(Background toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteBackground(int id)
        {
            var toDelete = this.context.Backgrounds.Find(id);
            this.context.Backgrounds.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}