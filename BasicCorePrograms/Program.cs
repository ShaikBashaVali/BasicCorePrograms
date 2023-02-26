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
            Console.WriteLine("Welcome to the Basic Core Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select the option");
                Console.WriteLine("1.FlipCoin" + "\n" +
                                  "2.Exit" + "\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Flip();
                        break;
                    case 2:
                        flag = false;
                        break;

                }
            }
        }
    }
}