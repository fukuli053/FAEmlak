﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FAEmlak.Data
{
    public class Photo
    {
        [Key]
        public long PhotoId { get; set; }

        public long PropertyId{ get; set; }
        public Property Property { get; set; }

        public bool IsDefault { get; set; }
    }
}