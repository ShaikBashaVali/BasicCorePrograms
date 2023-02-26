using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicSeries
    {
        float sum = 0;
        public void Harmonic()
        {
            Console.WriteLine("Enter the number upto which you want harmonic series");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                this.sum += (float)1 / i;
            }
            Console.WriteLine("Sum of Nth Harmonic series is {0}", sum);
        }
    }
}