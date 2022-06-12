﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChiCuong_bigschool.ViewModels
{
    public class CustomViewModel
    {
        [Required] 
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date {get; set;}  
    }
}