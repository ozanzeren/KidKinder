﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Models
{
    public class SendMessageViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı boş geçmeyiniz!")]
        [StringLength(30,ErrorMessage ="Lütfen en fazla 30 karatker veri girişi yapınız!")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi boş geçmeyiniz!")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 30 karatker veri girişi yapınız!")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail adresi giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen konu kısmını boş geçmeyiniz!")]
        [StringLength(50, ErrorMessage = "Lütfen en fazla 50 karatker veri girişi yapınız!")]
        [MinLength(5, ErrorMessage = "Lütfen geçerli bir mail adresi giriniz!")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Lütfen mesaj kısmını boş geçmeyiniz!")]
        [StringLength(1000, ErrorMessage = "Lütfen daha az karatker veri girişi yapınız!")]
        public string Message { get; set; }
    }
}