using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class ClockMod
    {
        public static void Clock(Language languageChoice)
        {
            // English: Implementation for the Clock problem
            // Chinese: 时钟问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the hours: ", "Enter the minutes: ", "Invalid time." } :
                new string[] { "输入小时: ", "输入分钟: ", "无效的时间." };

            Console.Write(languageStrings[0]);
            int hours = int.Parse(Console.ReadLine());
            Console.Write(languageStrings[1]);
            int minutes = int.Parse(Console.ReadLine());

            if (hours < 0 || hours >= 24 || minutes < 0 || minutes >= 60)
            {
                Console.WriteLine(languageStrings[2]);
            }
            else
            {
                int totalMinutes = hours * 60 + minutes;

                int newHours = (totalMinutes / 60) % 24;
                int newMinutes = totalMinutes % 60;

                Console.WriteLine($"The time is: {newHours.ToString("D2")}:{newMinutes.ToString("D2")}");
            }
        }
    }
}
