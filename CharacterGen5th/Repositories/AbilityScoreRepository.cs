﻿using CharacterGen5th.Models;
using CharacterGen5th.Bootstraper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class AbilityScoreRepository : AbstractRepository, IAbilityScoreRepository
    {
        public AbilityScoreRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<AbilityScore> GetAbilityScores()
        {
            return this.context.AbilityScores.ToList();
        }

        public void CreateAbilityScore(AbilityScore newAbilityScore)
        {
            this.context.AbilityScores.Add(newAbilityScore);
            this.context.SaveChanges();
        }

        public AbilityScore GetAbiltyScoreById (int id)
        {
            return this.context.AbilityScores.Find(id);
        }

        public void UpdateAbilityScore(AbilityScore toUpdate)
        {   
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteAbilityScore(int id)
        {
            var toDelete = context.AbilityScores.Find(id);
            this.context.AbilityScores.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}