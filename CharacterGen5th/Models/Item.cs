﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterGen5th.Models
{
    [Table("Items")]
    public class Item
    {
        public Item() { }

        [Key]
        public int Item_Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public decimal Cost { get; set; }

        [Required()]
        public decimal Weight { get; set; }

        [Required()]
        public string ItemType { get; set; }

        public virtual IEnumerable<BackgroundToItemMap> BackgroundEquipment { get; set; }
    }
}