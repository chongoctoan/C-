using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.btvn2
{
    public class PhoneNumber
    {
        public string Name { get; set; }
        public List<string> Phone { get; set; }

        public PhoneNumber(string name,string phone) 
        {
            Name = name;
            Phone = new List<string>();
            Phone.Add(phone);
        }
        public string this[int index] 
        {
            get => Phone[index];
            set => Phone[index] = value;
        }
        public override string ToString() 
        {
            string str = Name;
            foreach (string p in Phone) 
            {
                str += "==" + p;
            }
            return str;
        }
    }
}
