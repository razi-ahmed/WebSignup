using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSignupApi.Data
{
    public interface IRegistrationRepository
    {
        void SignupUser(Signup signup);
        void VerifyUser(UserEmailVerification userEmailVerification);
        void CompleteRegistration(UserProfile userProfile);

    }
}
