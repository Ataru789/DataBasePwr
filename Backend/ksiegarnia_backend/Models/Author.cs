﻿using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
