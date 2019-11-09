using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Mindfulness_Hub_V3.Repository;

namespace Mindfulness_Hub_V3.Logic
{
    public class PasswordManager : IPasswordManager
    {
        private String CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);

        }

        public String GenerateSha256Hash(String input, String salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sha256HashString = new SHA256Managed();
            byte[] hash = sha256HashString.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }


        public List<string> GeneratePassword(String input, int saltSize)
        {
            List<string> saltHash = new List<string>();
            string salt = CreateSalt(saltSize);

            string pass = GenerateSha256Hash(input, salt);

            saltHash.Add(salt);
            saltHash.Add(pass);
            return saltHash;
        }
    }
}
