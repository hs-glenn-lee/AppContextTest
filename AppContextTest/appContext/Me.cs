using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AppContextTest.appContext
{
    class Me
    {
        public String username { get; set; }
        public String encryptedPassword
        {
            get; set;
        }

        public void setEncryptedPasswordByPalinPassword(string plainPassword)
        {
            encryptedPassword = Crypto.Encrypt(plainPassword);
        }
        public string getDecryptedPassword()
        {
            return Crypto.Decrypt(encryptedPassword);
        }
    }
}
