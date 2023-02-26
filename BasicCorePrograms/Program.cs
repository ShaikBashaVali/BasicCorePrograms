using BasicPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class BasicPraograms
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
                                  "3.Power Of 2" + "\n" +
                                  "4.HarmonicSeries" + "\n" +
                                  "5.Exit" + "\n");
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
                        Powerof2 powerof2 = new Powerof2();
                        Console.WriteLine("\n" + "Enter the power value Up To 31");
                        int num = Convert.ToInt32(Console.ReadLine());
                        powerof2.Power(num);
                        break;
                    case 4:
                        HarmonicSeries harmonicSeries = new HarmonicSeries();
                        harmonicSeries.Harmonic();
                        break;
                    case 5:
                        flag = false;
                        break;

                }
            }
        }
    }
}