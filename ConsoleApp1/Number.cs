using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session5
{
    public class Number
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void ChangeXY()
        {
            X++;
            Y++;
        }
        public void PrintXY()
        {
            Console.WriteLine("X = " + X);
            Console.WriteLine("Y = " + Y);
        }
    }
}
