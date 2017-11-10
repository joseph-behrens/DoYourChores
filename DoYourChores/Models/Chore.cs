using System;

namespace DoYourChores.Models
{
    public class Chore
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime LastCompleted { get; set; }
        public string CompletedBy { get; set; }
    }
}