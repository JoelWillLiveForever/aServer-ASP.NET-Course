using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace aServer_ASP.NET_Course
{
    public class AuthOptions
    {
        public const string ISSUER = "aServer_ASP.NET_App_Server";
        public const string AUDIENCE = "aReact_App_Client";
        public const string KEY = "8E1156D6-2F58-462E-9C94-B74971671AB7";
        
        public const int LIFETIME = 400;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
