﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoYourChores.Models
{
    public class CatBox
    {
        public int Id { get; set; }
        public DateTime LastTimeCleaned { get; set; }
        public DateTime TimeToCleanAgain { get; set; }
    }
}