using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class BinaryToDecimal
    {
        public static void Convertion()
        {
            int num, binVal, decVal = 0, baseVal = 1, rem;
            num = 101; //5
            binVal = num;
            while (num > 0) 
            {
                rem = num % 10;
                decVal = decVal+rem * baseVal;
                num = num / 10;//num /=10
                baseVal = baseVal * 2;
            }
            Console.WriteLine(" Binary Number" + binVal);
            Console.WriteLine("\n Decimal Number" + decVal );
            

            
        }
    }
}
