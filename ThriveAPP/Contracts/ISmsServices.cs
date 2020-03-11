using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriveAPP.Contracts
{
    public interface ISmsServices
    {
        Task SendSMS(IPhoneNumber receiver);
    }
}
