﻿using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharacterGen5th.Repositories
{
    public class AlignmentRepository : AbstractRepository, IAlignmentRepository
    {
        public AlignmentRepository(CharGenContext context) : base(context)
        {
        }

        public IEnumerable<Alignment> GetAlignments()
        {
            return this.context.Alignments.ToList();
        }

        public void CreateAlignment(Alignment newAlignment)
        {
            this.context.Alignments.Add(newAlignment);
            this.context.SaveChanges();
        }

        public Alignment GetAlignmentById(int id)
        {
            return this.context.Alignments.Find(id);
        }

        public void UpdateAlignment(Alignment toUpdate)
        {
            this.context.Entry(toUpdate).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void DeleteAbilityScore(int id)
        {
            var toDelete = context.Alignments.Find(id);
            this.context.Alignments.Remove(toDelete);
            this.context.SaveChanges();
        }
    }
}