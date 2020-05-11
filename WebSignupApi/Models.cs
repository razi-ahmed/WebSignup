using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSignupApi
{
    public class Signup
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }

    public class UserEmailVerification : Signup
    {
        public string VerificationCode { get; set; }
    }

    public class UserProfile : UserEmailVerification
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string ContactPhoneNumber { get; set; }
        public IDictionary<string, bool> Preferences { get; set; }

    }

    public class Preferences
    {
        public string Name { get; set; } 
    }
    public class EmailMessage
    {
        public string FromEmailAddress { get; set; }
        public string ToEmailAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ReplyTo { get; set; }

    }
}
