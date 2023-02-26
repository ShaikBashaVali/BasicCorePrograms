using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public void VowelConsonant()
        {
            Console.WriteLine("Enter the Alphabet To check Whether It is a Vowel or Consonant");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                case 'i':
                case 'o':
                case 'u':
                case 'e':
                    Console.WriteLine("Entered alphabet is a vowel");
                    break;
                default:
                    Console.WriteLine("Entered alphabet is a consonant");
                    break;
            }
        }
    }
}