using System;

namespace DoYourChores.Models
{
    public class CatBox
    {
        public int Id { get; set; }
        public DateTime LastTimeCleaned { get; set; }
        public DateTime TimeToCleanAgain { get; set; }
        public string Message { get; set; }
    }
}