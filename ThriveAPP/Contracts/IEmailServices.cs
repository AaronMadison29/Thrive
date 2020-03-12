using System.Collections.Generic;
using System.Threading.Tasks;
using ThriveAPP.Models;

namespace ThriveAPP.Contracts
{
    public interface IEmailServices
    {
        Task<bool> EmailAsync(IEmail sender, IEmail Receiver);
        Task EmailAlertAsync(IEnumerable<IEmail> recipients);
    }
}
