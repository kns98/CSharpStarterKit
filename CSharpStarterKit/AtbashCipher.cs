//see: https://en.wikipedia.org/wiki/Atbash

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    using System;
    using System.Collections.Generic;

    public class AtbashCipher
    {
        private static List<char> Alphabet = new List<char>()
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '一', '人', '大', '小', '中', '国', '日', '月', '水', '山',
            '木', '火', '土', '金', '王', '女', '男', '子', '学', '爱', '家',
            '食', '车', '书', '电'
        };

        private static string Encrypt(string plaintext)
        {
            string ciphertext = "";
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = Alphabet[Alphabet.Count - Alphabet.IndexOf(char.ToUpper(c)) - 1];
                    ciphertext += char.IsUpper(c) ? encryptedChar : char.ToLower(encryptedChar);
                }
                else
                {
                    ciphertext += c;
                }
            }
            return ciphertext;
        }

        private static string Decrypt(string ciphertext)
        {
            return Encrypt(ciphertext); // The Atbash cipher is symmetric, so decryption is the same as encryption
        }

        public void Go(CSharpLearn.Language languageChoice)
        {
            Console.WriteLine("Enter the text to encrypt: ");
            string plaintext = Console.ReadLine();

            string encryptedText = Encrypt(plaintext);
            Console.WriteLine("Encrypted text: " + encryptedText);

            string decryptedText = Decrypt(encryptedText);
            Console.WriteLine("Decrypted text: " + decryptedText);

            List<char> encryptedList = new List<char>();
            foreach (char c in encryptedText)
            {
                encryptedList.Add(c);
            }

            Console.WriteLine("Encrypted List:");
            foreach (char c in encryptedList)
            {
                Console.Write(c + " ");
            }
        }
    }

}
