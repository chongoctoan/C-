﻿using ConsoleApp1;
using ConsoleApp1.btvn1;
using ConsoleApp1.btvn2;
using ConsoleApp1.session1;
using ConsoleApp1.session2;
using ConsoleApp1.session4;
using ConsoleApp1.session5;
public class Program
{
    static void Main(string[] args) 
    {
        Fetch();
    }
    static async void Fetch() 
    {
        CallApi ca = new CallApi();
        Product s = await ca.FetchData();
        Console.WriteLine(s.ToString());
    }
    static void Main6(string[] args) 
    {
        //ThreadRun();
        //Thread t1 = new Thread(ThreadRun);
        //Thread t2 = new Thread(ThreadRunParam);
        //t2.IsBackground= true;
        //t1.Start();
        //t2.Start("Toan");
        Number num = new Number() { X = 0, Y = 0 };
        Thread n1 = new Thread(ThreadLock);
        Thread n2 = new Thread(ThreadLock);
        n1.Start(num);
        n2.Start(num);
    }
    static void ThreadLock(object o) 
    {
        Number n = (Number)o;
        for(int i = 0;i<20;i++) 
        {
            lock (n) 
            {
                n.ChangeXY();
                n.PrintXY();
            }
            try 
            {
                Thread.Sleep(1000);
            }catch(Exception e) { }
        }
    }
    static void ThreadRun() 
    {
        for(int i = 0; i < 20; i++) 
        {
            Console.WriteLine("i=" + i);
            try 
            {
                Thread.Sleep(1000);
            }catch(Exception e) { }
        }
    }static void ThreadRunParam(object msg) 
    {
        for(int i = 0; i < 30; i++) 
        {
            Console.WriteLine("i=" + i +" Msg:" + msg);
            try 
            {
                Thread.Sleep(1000);
            }catch(Exception e) { }
        }
    }
    static void Main5(string[] args) 
    {
        StringToVoid stv = new StringToVoid(ShowMessage);
        StringToVoid stv2 = new StringToVoid(DemoDelegate.SayHello);
        StringToVoid stv3 = new StringToVoid(new DemoDelegate().ShowInfo);

        stv += DemoDelegate.SayHello;
        stv += new DemoDelegate().ShowInfo;
        stv("Xin chao cac ban");

        DemoEvent de = new DemoEvent();
        de.Invoke();
    }
    static void ShowMessage(string msg) 
    {
        Console.WriteLine(msg);
    }
    static void Main4(string[] args) 
    {
        PhoneBook pb= new PhoneBook();
        pb.InsertPhone("Toan", "0111111");
        pb.InsertPhone("Toan2", "0222222");
        pb.InsertPhone("Toan3", "0333333");
        pb.InsertPhone("Toan4", "0444444");
        pb.InsertPhone("Toan5", "0555555");
        pb.Sort();

        foreach (PhoneNumber p in pb.PhoneList) 
        {
          Console.WriteLine(p.ToString());
        }
    }
    static void Main3(string[] args) 
    {
        try
        {
            int x = 10;
            int y = 0;
            throw new Exception("Y Bằng 0 Mất Rồi");
            float z = x / y;
        }catch(Exception e) 
        {
            Console.WriteLine(e.Message);
        }
        finally 
        {
            
        }
    }
    static void Main2(String[] args)
    {
        Human h = new Human();
        h.Run();
        Human dvt= new Human();
        dvt.Run();
        h.Age = 19;
        h.Email = "abc@gmail.com";

        Student s = new Student();
        s[0] = "0327958099";
        s[1] = "0333333333";
        s[2] = "0444444444";
        List<string> ls = new List<string>();
        ls.Add("Hello");
        ls.Add("World");
        ls.Add("Morning");

        for (int i = 0; i< ls.Count; i++)
        {
            Console.WriteLine(ls[i]);
        }
        foreach (string l in ls) 
        {
            Console.WriteLine(l);
        }

        Console.WriteLine("Nhap phan so 1");
        phanso p1 = new phanso();

        Console.WriteLine("Nhap phan so 2");
        phanso p2 = new phanso();

        phanso p3 = new phanso();

        p3 = p3.Add(p1, p2);
        Console.WriteLine("tong 2 phan so la");
        p3.InPhanso();
        p3 = p3.Sub(p1, p2);
        Console.WriteLine("tru 2 phan so la");
        p3.InPhanso();
        p3 = p3.Mul(p1, p2);
        Console.WriteLine("nhan 2 phan so la");
        p3.InPhanso();
        p3 = p3.Div(p1, p2);
        Console.WriteLine("chia 2 phan so la");
        p3.InPhanso();

        

    }
}