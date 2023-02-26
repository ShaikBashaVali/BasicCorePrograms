using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class Powerof2
    {
        public void Power(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
        }
    }
}