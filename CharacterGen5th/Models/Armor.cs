﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Armors")]
    public class Armor
    {
        public Armor() {}

        [Key]
        public int Armor_Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public decimal Cost { get; set; }

        [Required()]
        public decimal Weight { get; set; }

        [Required()]
        public string ArmorType { get; set; }

        [Required()]
        public int BaseAc { get; set; }

        public int? MaxDexMod { get; set; }

        [Required()]
        public int RequiredStr { get; set; }

        [Required()]
        public bool StealthDisadvantage { get; set; }

        public virtual IEnumerable<ClassToArmorMap> ArmorProfByClass { get; set; }
    }
}