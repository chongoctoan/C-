using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session1
{
    public class Human
    {
        private string name;
        private int age;
        private int id;


        public static int xyz;

        public Human()
        {

        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Email { get; set; } // khi gan gia tri vao no se co gia tri, email khi chua gan gia tri thi chua co o nho

        public Human(string s)
        {
            this.name = s;
        }
        public void Run()
        {
            Console.WriteLine("Running...");
            this.name = "Nguyen Van A";
        }

        public static void ScreenShot()
        {

        }

        public virtual void Eat() // phuong thuc ghi de bat buoc phai co virtual de bao hieu la phuong thuc ghi de
        {

        }// neu khong muon cho ghi de thay virtual thanh sealed, su dung khi khong muon ke thua hay ghi de
    }
}