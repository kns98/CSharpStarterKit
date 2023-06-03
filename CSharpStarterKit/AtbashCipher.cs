//see: https://en.wikipedia.org/wiki/Atbash


namespace CSharpLearn
{

    public class AtbashCipher
    {
        private static List<char> Alphabet = new List<char>()
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
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
                if (Alphabet.Contains(c))
                {
                    char encryptedChar = Alphabet[Alphabet.Count - Alphabet.IndexOf(c) - 1];
                    ciphertext += encryptedChar;
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

        public void Go(Language languageChoice)
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
