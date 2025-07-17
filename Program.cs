using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fff = "                      jnfjdgudfihbdfklrg;vogjl;rngv385ouhelgn;nbgfjdpofkgnjfkdffngdfljuu          ";
            fff = fff.Replace('f', '5');
            fff = fff.Trim();
            fff = char.ToUpper(fff[0]) + fff.Substring(1);
            string upper = fff.ToUpper();
            string lower = fff.ToLower();

            Console.WriteLine("Capitalized : " + fff);
            Console.WriteLine("Uppercase   : " + upper);
            Console.WriteLine("Lowercase   : " + lower);
            Console.WriteLine("___________________________________________________________________________________");

            int a = 5, b = 10;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Swapped values without temp variable: a = " + a + ", b = " + b);

            Console.WriteLine("___________________________________________________________________________________");

            int avg = 75;
            string grade;

            if(avg>= 90)
            {
                grade = "A";
            }
            else if(avg >= 80)
            {
                grade = "B";
            }
            else if(avg >= 70)
            {
                grade = "C";
            }
            else if(avg >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine("Average: " + avg + ", Grade: " + grade);
        }
    }
}
