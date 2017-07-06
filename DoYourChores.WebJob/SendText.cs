using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace DoYourChores.WebJob
{
    class SendText
    {

        public static void Twilio(DateTime deadLine)
        {

            var daysSinceCleaning = Math.Round(((DateTime.UtcNow - deadLine.AddDays(-1)).TotalDays),2);

            string AccountSid = "ACa8e8bf0cb3e09e9b7664a6e0c983a50b";
            string AuthToken = "023d4a3d27816c64155d57d9242299ae";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage(
              "+17632519969", "+17634427782",
              "Hey butt hole! It's been " + daysSinceCleaning + " days since the cat box was last cleaned!",
              ""
            );

            Debug.WriteLine("Text sent with number of days: {0}", daysSinceCleaning);            
        }
    }
}
