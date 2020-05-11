using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSignupApi.Data;

namespace WebSignupApi
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IEmailService _IEmailService;
        private readonly IRegistrationRepository _IRegistrationRepository;

        public RegistrationService(IEmailService IEmailService, IRegistrationRepository IRegistrationRepository)
        {
            _IEmailService = IEmailService;
            _IRegistrationRepository = IRegistrationRepository;
        }

        public void SignupUser(Signup signup)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string GenerateCode()
        {
            return "44410";

        }

        public void VerifyRegisteration(UserEmailVerification userEmailVerification)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CompleteRegistration(UserProfile userProfile)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
