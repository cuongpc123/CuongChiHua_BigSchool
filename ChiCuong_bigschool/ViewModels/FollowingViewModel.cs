﻿using ChiCuong_bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChiCuong_bigschool.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}