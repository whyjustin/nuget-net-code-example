using System;
using Twilio.TwiML;

using static Newtonsoft.Json.JsonConvert;

namespace some_library
{
    public class SmsLogger
    {
        public static void Log() {
            var messagingResponse = new MessagingResponse();
            messagingResponse.Message("Mr. Watson--come here--I want to see you.");
            var serialized = SerializeObject(messagingResponse);

            Console.Log(serialized);
        }
    }
}
