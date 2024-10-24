﻿using System.ComponentModel.DataAnnotations;

namespace BloggingPlatform.Models.Entity
{
    public class EntityBase
    {
        public int ID { get; set; }

        [Display(Name = "Datetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
