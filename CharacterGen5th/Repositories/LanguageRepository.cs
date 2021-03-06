﻿using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class LanguageRepository : AbstractRepository, ILanguageRepository
    {
        public LanguageRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Language> GetLanguages()
        {
            return this.context.Languages.ToList();
        }

        public void CreateLanguage(Language newLanguage)
        {
            this.context.Languages.Add(newLanguage);
            this.context.SaveChanges();
        }

        public Language FindLanguage(int id)
        {
            return this.context.Languages.Find(id);
        }

        public void UpdateLanguage(Language toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteLanguage(int id)
        {
            var toDelete = this.context.Languages.Find(id);
            this.context.Languages.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}