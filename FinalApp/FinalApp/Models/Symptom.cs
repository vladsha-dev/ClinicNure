﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalApp.Models
{
    public class Symptom
    {
        [Key]
        public string Name { get; set; }
    }
}
