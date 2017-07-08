using System.Text;
using System.Security.Cryptography;
using System.IO;
using System;

namespace ShoppingCartApi.Helper
{
    public class Security
    {
        public static string getSHA256(string text)
        {
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
