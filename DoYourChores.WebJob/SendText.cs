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

            string AccountSid = "ACa8e8bf0cb3e09e9b7664a6e0c983a50b";
            string AuthToken = "023d4a3d27816c64155d57d9242299ae";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage(
              "+17632519969", recipient,
              "Hey jerks!! It's been " + daysSinceCleaning + " days since the cat box was last cleaned! Click the link if it's been cleaned: http://doyourchoresjb.azurewebsites.net/CatBox/Clean</a>",
              ""
            );

            Debug.WriteLine("Text sent with number of days: {0}", daysSinceCleaning);            
        }
    }
}
