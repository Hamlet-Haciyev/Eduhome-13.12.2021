﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Phone_1 { get; set; }
        [MaxLength(50)]
        public string Phone_2 { get; set; }
        [MaxLength(50)]
        public string Email_1 { get; set; }
        [MaxLength(50)]
        public string Email_2 { get; set; }

    }
}
