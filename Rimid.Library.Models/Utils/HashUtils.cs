using System.Security.Cryptography;
using System.Text;

namespace Rimid.Library.Models.Utils
{
    public static class HashUtils
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (var sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                var hashBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                var builder = new StringBuilder();
                foreach (var hashByte in hashBytes)
                {
                    builder.Append(hashByte.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
