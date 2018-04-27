using System;
using System.Diagnostics;
using Twilio;

namespace DoYourChores.WebJob
{
    class SendText
    {

        public static void Twilio(DateTime deadLine, string recipient)
        {

            var daysSinceCleaning = Math.Round(((DateTime.UtcNow - deadLine.AddDays(-2)).TotalDays),0);

            string AccountSid = "";
            string AuthToken = "";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage(
              "", recipient,
              "Could you please clean my bathroom :*( ... It's been " + daysSinceCleaning + " days since the cat box was last cleaned! Click the link if it's been cleaned: http://doyourchoresjb.azurewebsites.net/CatBox/Clean",
              ""
            );

            Debug.WriteLine("Text sent with number of days: {0}", daysSinceCleaning);            
        }
    }
}
