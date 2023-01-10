using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GeometryExample
{
    public class Cylinder
    {

        public Cylinder()
        {
        }
        public float BaseArea { get; set; }
        public float LateralArea { get; set; }
        public float TotalArea { get; set; }
        public float Volume { get; set; }
        public float Radius { get; set; }
        public float Height { get; set; }


        public void Process(float BaseArea, float LateralArea, float TotalArea, float Volume, float Radius, float Height)
        {
            BaseArea = (float)(Radius * Radius * Math.PI);

            LateralArea = (float)(2 * Math.PI * Radius * Height);

            TotalArea = (float)(2 * Math.PI * Radius * (Height + Radius));

            Volume = (float)(Math.PI * Radius * Radius * Height);

            return;
        }
        public void Result()
        {
            Console.WriteLine("Radius : " + Radius);
            Console.WriteLine("Height : " + Height + "\n");
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius : " + Radius + "Height : " + Height);
            Console.WriteLine("BaseArea: " + BaseArea + "" + "LateralArea: " + LateralArea + "" + "TotalArea: " + TotalArea + "" + "Volume: " + Volume);

        }
    }
}
