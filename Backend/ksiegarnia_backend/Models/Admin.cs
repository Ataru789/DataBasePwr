﻿using System.ComponentModel.DataAnnotations;

namespace ksiegarnia_backend.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public int UserId { get; set; }

    }
}
