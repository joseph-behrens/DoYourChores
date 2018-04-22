using System;
using System.Diagnostics;

namespace DoYourChores.WebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            var deadLine = CheckCatBox.GetDeadline();
            Debug.WriteLine("The deadline is " + deadLine.ToString("f"));
            Debug.WriteLine("The current time is " + DateTime.UtcNow.ToString("f"));
            
            if (deadLine < DateTime.UtcNow)
            {
                SendText.Twilio(deadLine, "+17634427782");
            }
        }
    }
}
