using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSignupApi
{

    public interface IEmailService
    {
        void Configure();
        void Send(EmailMessage emailMessage);
    }
}
