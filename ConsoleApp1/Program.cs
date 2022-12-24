using ConsoleApp1;
using ConsoleApp1.btvn1;
using ConsoleApp1.session1;
using ConsoleApp1.session2;

public class Program
{
    static void Main(string[] args) 
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