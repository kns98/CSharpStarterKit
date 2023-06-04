using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class BobRobot
    {
        public static void Bob(Language languageChoice)
        {
            // English: Implementation for the Bob problem
            // Chinese: Bob问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a phrase to Bob: ", "Bob's response: " } :
                new string[] { "输入要与Bob交流的短语: ", "Bob的回应: " };

            Console.Write(languageStrings[0]);
            string phrase = Console.ReadLine();
            string response = "";
            if (languageChoice == Language.English)
            {
                response = BobResponse(phrase);
            }
            else
            {
                response = BobResponse_Chinese(phrase);
            }
            Console.WriteLine(languageStrings[1] + response);
        }

        private static string BobResponse(string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase))
            {
                return "Fine. Be that way!";
            }

            bool isQuestion = phrase.EndsWith("?");
            bool isYelling = phrase.ToUpper() == phrase;

            if (isQuestion && isYelling)
            {
                return "Calm down, I know what I'm doing!";
            }
            else if (isQuestion)
            {
                return "Sure.";
            }
            else if (isYelling)
            {
                return "Whoa, chill out!";
            }
            else
            {
                return "Whatever.";
            }
        }

        private static string BobResponse_Chinese(string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase))
            {
                return "好吧，随你的便！";
            }

            bool isQuestion = phrase.EndsWith("？");
            bool isYelling = phrase.EndsWith("@");

            if (isQuestion && isYelling)
            {
                return "冷静点，我知道我在做什么！";
            }
            else if (isQuestion)
            {
                return "当然。";
            }
            else if (isYelling)
            {
                return "哇，冷静！";
            }
            else
            {
                return "随你便吧。";
            }
        }
    }
}
