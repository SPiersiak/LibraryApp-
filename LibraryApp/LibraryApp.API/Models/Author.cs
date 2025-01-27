﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.API.Models
{
    /// <summary>
    /// model autora ktory odwzorowuje jego tabele w bazie danych
    /// </summary>
    public class Author
    {
        [Key]
        public long AuthorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
