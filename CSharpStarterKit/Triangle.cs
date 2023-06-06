using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    class TriangleMod
    {
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "isosceles";
            }
            else
            {
                return "scalene";
            }
        }

        internal static void Triangle(Language languageChoice)
        {
            if (languageChoice == Language.English)
            {
                Console.WriteLine("Enter the length of side 1:");
                double side1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the length of side 2:");
                double side2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the length of side 3:");
                double side3 = double.Parse(Console.ReadLine());

                string triangleType = DetermineTriangleType(side1, side2, side3);

                Console.WriteLine("The triangle is " + triangleType);
            }

            if (languageChoice == Language.Chinese)
            {
                Console.WriteLine("输入边长1的长度：");
                double side1 = double.Parse(Console.ReadLine());

                Console.WriteLine("输入边长2的长度：");
                double side2 = double.Parse(Console.ReadLine());

                Console.WriteLine("输入边长3的长度：");
                double side3 = double.Parse(Console.ReadLine());

                string triangleType = DetermineTriangleType(side1, side2, side3);

                Console.WriteLine("该三角形为" + triangleType + "三角形");
            }
        }
    }

}


