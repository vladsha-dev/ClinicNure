﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    public class RequestServerType
    {
        public string Date { get; set; }
        public List<Symptom> Symptoms { get; set; }
        public User Patient { get; set; }
        public Hospital Hospital { get; set; }
        public Doctor Doctor { get; set; }
        public string State { get; set; }
        public Disease Disease { get; set; }
    }
}
