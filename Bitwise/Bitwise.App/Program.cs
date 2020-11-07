using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise.App
{
    class Program
    {
        static void Main()
        {
            //testing: 
            //for (int j = 0; j < 32; ++j) 
            //{
            //    Console.WriteLine(GetLeftMostBitPosition(j));
            //}
            
            Console.WriteLine("Please input a 5 digit binary number");
            string binary = Console.ReadLine();
            int i = Convert.ToInt32(binary, 2);

            //19,20 
            Console.WriteLine("{0} is the rightmost bit. {2}{1}{0} are the three rightmost bits.", i & 1, (i >> 1) & 1, (i >> 2) & 1 ); //00001, 00111            
            //21,22
            Console.WriteLine("{0} is the leftmost bit. {0}{1}{2} are the three leftmost bits.", (i >> 4) & 1, (i >> 3) & 1, (i >> 2) & 1);
            
            // Remove taken as setting to 0
            Console.WriteLine(Convert.ToString(i - (i & 1), 2)); //23 - output as binary
            Console.WriteLine(Convert.ToString(i - (i & 0b111), 2)); //24
            Console.WriteLine(Convert.ToString(i - (i & 0b10000), 2)); //25
            Console.WriteLine(Convert.ToString(i - (i & 0b11100), 2)); //26
            Console.WriteLine(Convert.ToString(i & 0b01110, 2)); //27
            
            //28
            int leftmostBit = (i & 0b10000) >> 4;
            int removed = i & 0b01111;
            int shifted = removed << 1;
            int rotatedLeft = shifted + leftmostBit;
            Console.WriteLine(Convert.ToString(rotatedLeft, 2));




            Console.ReadKey();

            while (Console.ReadKey().Key != ConsoleKey.Escape) 
            { Console.WriteLine("press <ESC> to exit"); }


            // Alternative code below if it was truly any binary number;
            //int pos = GetLeftMostBitPosition(i);
            //Console.WriteLine("{0} is the leftmost bit. {0}{1}{2} are the three leftmost bits.", (i >> pos) & 1, (i >> pos-1) & 1, (i >> pos-2) & 1);
            // wouldnt work for numbers less than 4 in decimal i.e. 100        
        } 
        
        
        
        static int GetLeftMostBitPosition(int x)
        {
            if (x == 0)
            {
                return -1;
            }
            return (int)Math.Log(x, 2);
        }
    }
}
