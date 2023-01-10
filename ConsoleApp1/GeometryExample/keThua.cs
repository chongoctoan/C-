using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GeometryExample
{
    public class KeThua
    {

        public double weight;
        public string name;
        public KeThua(double weight, string name)
        {
            SetMe(weight, name);
        }

        public void Show()
        {
            Console.WriteLine("Name: " + name + ", " + "weight " + weight);
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}

