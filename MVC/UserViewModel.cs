﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CropsMVC.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

    }
}