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
                                  "5.Factors" + "\n" +
                                  "6. QuotientAndRemainder" + "\n" +
                                  "7.Swap2Numbers" + "\n" +
                                  "8.EvenorOdd" + "\n" +
                                  "9.VowelOrConsonant" + "\n" +
                                  "10.LargestNumber" + "\n" +
                                  "11.Exit" + "\n");
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
                        Factors factors = new Factors();
                        factors.Factor();
                        break;
                    case 6:
                        QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                        quotientAndRemainder.FindValue();
                        break;
                    case 7:
                        Swap2Numbers swap2Numbers = new Swap2Numbers();
                        swap2Numbers.Swap();
                        break;
                    case 8:
                        EvenorOdd evenorOdd = new EvenorOdd();
                        evenorOdd.EvenOdd();
                        break;
                    case 9:
                        VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                        vowelOrConsonant.VowelConsonant();
                        break;
                    case 10:
                        LargestNumber largestNumber = new LargestNumber();
                        largestNumber.LargeNumber();
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}