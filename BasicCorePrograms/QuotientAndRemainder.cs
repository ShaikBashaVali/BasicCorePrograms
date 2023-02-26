using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientAndRemainder
    {
        public int Divider()
        {
            Console.Write("Enter the  Divisor value = ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public int Dividend()
        {
            Console.Write("Enter the Dividend value = ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public void FindValue()
        {
            int dividend = Divider();
            int divisor = Dividend();
            int quoitent = dividend / divisor;
            int remainder = dividend - (divisor * quoitent);
            Console.WriteLine("Quoitent is : " + quoitent);
            Console.WriteLine("Remainder is : " + remainder);

        }
    }
}