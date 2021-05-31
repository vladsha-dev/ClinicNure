﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    public class Request
    {
        public string Date { get; set; }
        public string Symptoms { get; set; }
        public Patient Patient { get; set; }
        public Hospital Hospital { get; set; }
        public Doctor Doctor { get; set; }
        public string State { get; set; }
        public Disease Disease { get; set; }
    }
}
