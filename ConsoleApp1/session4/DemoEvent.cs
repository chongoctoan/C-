using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session4
{
    public class DemoEvent
    {
        public event StringToVoid Print;
        public event StringToVoid Action;
        public event StringToVoid Touch;
        public event StringToVoid Swipe;
        public DemoEvent() 
        {
            Print += DemoDelegate.SayHello;
            Print += new DemoDelegate().ShowInfo;
        }
        public void Invoke() 
        {
            Print("Hello World");
        }
    }
}
