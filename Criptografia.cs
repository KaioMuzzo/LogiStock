using System.Security.Cryptography;
using System.Text;

namespace LogiStock
{
    public class Criptografia
    {
        public static string GerarHash(string texto)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] textBytes = Encoding.UTF8.GetBytes(texto);
            byte[] hashBytes = sha256.ComputeHash(textBytes);
            StringBuilder result = new StringBuilder();

            foreach (byte b in hashBytes)
            {
                result.Append(b.ToString("x2"));
            }

            return result.ToString();
        }
    }
}
