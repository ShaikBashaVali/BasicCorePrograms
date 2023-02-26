using BasicPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Flip
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Basic Core Programs---------");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select the option");
                Console.WriteLine("1.FlipCoin" + "\n" +
                                  "2.LeapYear" + "\n" +
                                  "3.Exit" + "\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Flip();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Leap();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}