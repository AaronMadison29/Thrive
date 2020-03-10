using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Contracts;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ThriveAPP.Services
{
    public class SmsService : ISmsServices
    {
        private readonly string Account_SID = Api_Keys.Account_SID;
        private readonly string AUTH_TOKEN = Api_Keys.AUTH_TOKEN;
        public SmsService()
        {

        }

        public async Task SendSMS(IPhoneNumber receiver)
        {
            TwilioClient.Init(Account_SID, AUTH_TOKEN);

            var message = await MessageResource.CreateAsync(
                body: "Your student's grade has dropped below a 70.",
                from: new Twilio.Types.PhoneNumber("+12512700452"),
                to: new Twilio.Types.PhoneNumber($"1{receiver.PhoneNumber}")
            );
        }
    }
}
