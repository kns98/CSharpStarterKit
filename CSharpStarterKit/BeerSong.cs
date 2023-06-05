using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    class BeerSongMod
    {
        public static void BeerSong(Language languageChoice)
        {
            // English: Implementation for the Beer Song problem
            // Chinese: 啤酒歌问题的实现
            string bottles = languageChoice == Language.English ? " bottles" : " 瓶";
            string bottle = languageChoice == Language.English ? " bottle" : " 瓶";
            string onTheWall = languageChoice == Language.English ? " of beer on the wall," : " 的啤酒在墙上,";
            string ofBeer = languageChoice == Language.English ? " of beer." : " 的啤酒.";
            string takeOneDown = languageChoice == Language.English ? "Take one down and pass it around," : "拿掉一瓶传来传去,";
            string noMoreBottles = languageChoice == Language.English ? "No more bottles of beer on the wall, no more bottles of beer." : "没有啤酒在墙上, 没有啤酒.";
            string goToStore = languageChoice == Language.English ? " Go to the store and buy some more," : "去商店买一些,";
            string bottlesOnTheWall = languageChoice == Language.English ? " bottles of beer on the wall." : " 瓶的啤酒在墙上.";

            for (int i = 99; i > 0; i--)
            {
                Console.WriteLine($"{i}{(i == 1 ? bottle : bottles)}{onTheWall} {i}{(i == 1 ? bottle : bottles)}{ofBeer}");
                Console.WriteLine(takeOneDown);
                Console.WriteLine($"{i - 1}{((i - 1) == 1 ? bottle : bottles)}{goToStore}\n");
            }

            Console.WriteLine(noMoreBottles);
            Console.WriteLine(goToStore.Trim());
            Console.WriteLine($"99{bottles}{bottlesOnTheWall}\n");
        }
    }
}
