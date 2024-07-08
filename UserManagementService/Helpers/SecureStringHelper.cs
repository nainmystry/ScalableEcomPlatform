using System.Security;

namespace UserManagementService.Helpers
{

    public static class SecureStringHelper
    {
        public static SecureString ConvertToSecureString(string password)
        {

            if(string.IsNullOrEmpty(password))
            throw new ArgumentException("Password cannot be empty.");

            SecureString securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

            securePassword.MakeReadOnly();
            return securePassword;
        }

    }
    
}