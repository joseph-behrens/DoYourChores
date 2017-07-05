using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNaggingMom.Models
{
    public class CatBox
    {
        public DateTime LastTimeCleaned { get; set; }
        public DateTime TimeToCleanAgain { get; set; }


        // Constructor
        public CatBox()
        {
            LastTimeCleaned = DateTime.Now;
            TimeToCleanAgain = LastTimeCleaned.AddDays(1);
        }
    }
}