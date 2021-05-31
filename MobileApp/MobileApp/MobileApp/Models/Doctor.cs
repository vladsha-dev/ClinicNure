﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    class Doctor
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Speciality { get; set; }
        public Hospital Hospital { get; set; }
    }
}
