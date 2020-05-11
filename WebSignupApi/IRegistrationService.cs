namespace WebSignupApi
{
    public interface IRegistrationService
    {
        void CompleteRegistration(UserProfile userProfile);
        string GenerateCode();
        void SignupUser(Signup signup);
        void VerifyRegisteration(UserEmailVerification userEmailVerification);
    }
}