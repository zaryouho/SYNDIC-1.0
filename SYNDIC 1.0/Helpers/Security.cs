using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SYNDIC_1._0.Helpers
{
    public static class Security
    {
        public class HashandSalt
        {
            public string hash { get; set; }
            public string salt { get; set; }
        }
        public static HashandSalt GenerathashandSalt(int size, string password)
        {
            byte[] saltbytes = new byte[size];
            RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider();
            cryptoServiceProvider.GetNonZeroBytes(saltbytes);
            var salt = Convert.ToBase64String(saltbytes);

            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, saltbytes);
            var hashedPassword = Convert.ToBase64String(deriveBytes.GetBytes(256));
            HashandSalt hashSalt = new HashandSalt { hash = hashedPassword, salt = salt };
            return hashSalt;
            //HashandSalt hashandsalt = GenerathashandSalt(64, password);

        }
        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);
            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes);
            return Convert.ToBase64String(deriveBytes.GetBytes(256)).Equals(storedHash);
        }
    }
}
