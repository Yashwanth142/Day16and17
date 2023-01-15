using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class PrimeNum
    {
        public void Display()
        {
            Console.WriteLine("The prime number form 1 to 1000 are :");
            for (int num = 2; num <= 1000; num++)
            {
                int p = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        p = 1;
                        break;
                    }
                }
                if (p == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
