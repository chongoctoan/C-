using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.btvn2
{
    public abstract class Phone
    {
        public abstract void InsertPhone(String name, String phone);
        public abstract void Removephone(String name);
        public abstract void UpdatePhone(String name,String oldPhone, String newphone);
        public abstract PhoneNumber SearchPhone(String name);
        public abstract void Sort();
    }
    public class PhoneBook : Phone
    {
        public PhoneBook()
        {
            PhoneList = new List<PhoneNumber>();
        }
        public List<PhoneNumber> PhoneList { get;}
        public override void InsertPhone(string name, string phone) 
        {
            foreach(PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name)) 
                {
                    if (p.Phone.Contains(phone)) 
                    {
                        return;
                    }
                    p.Phone.Add(phone);
                    return;
                }
            }
            PhoneNumber pn = new PhoneNumber(name, phone);
        }

        public override void Removephone(string name)
        {
            foreach (PhoneNumber p in PhoneList) 
            {
                if(p.Name.Equals(name)) 
                {
                    PhoneList.Remove(p);
                    return;
                }
            }
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }
            return null;
        }

        public override void Sort()
        {
            PhoneList.Sort((o1, o2) =>
            {
                return o1.Name.CompareTo(o2.Name);
            });
        }

        public override void UpdatePhone(string name,string oldPhone, string newphone)
        {
            foreach(PhoneNumber p in PhoneList) 
            {
                if (p.Name.Equals(name)) 
                {
                    foreach (string phone in p.Phone) 
                    {
                        if(phone.Equals(name) && p.Phone.Contains(oldPhone)) 
                        {
                            p.Phone.Remove(oldPhone);
                            p.Phone.Add(newphone);
                            return;
                        }
                    }
                }
            }
        }
    }
}
