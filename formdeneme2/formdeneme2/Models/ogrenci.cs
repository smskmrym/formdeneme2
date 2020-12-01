﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace formdeneme2.Models
{
    public class ogrenci
    {

        [Required(ErrorMessage = "isminizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email adresi giriniz")]
        [EmailAddress(ErrorMessage = "Email adresinizi düzgün giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon giriniz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Katılma durumunuz nedir ?")]
        public bool? Confirm { get; set; }

    }
}
