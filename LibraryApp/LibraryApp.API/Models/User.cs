﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.API.Models
{
    /// <summary>
    /// model uzytkownika ktory odwzorowuje jego tabele w bazie danych
    /// </summary>
    public class User
    {
        [Key]
        public long UserID { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsEmployee { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Borrowed> Borroweds { get; set; }
    }
}
