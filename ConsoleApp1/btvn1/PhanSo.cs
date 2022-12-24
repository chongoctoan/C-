using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.btvn1
{
    public class phanso
    {
        internal phanso Sub(phanso p1, phanso p2)
        {
            throw new NotImplementedException();
        }
        internal void InPhanso()
        {
            throw new NotImplementedException();
        }

        internal void NhapPhanso()
        {
            throw new NotImplementedException();
        }

        internal phanso Add(phanso p1, phanso p2)
        {
            throw new NotImplementedException();
        }

        internal phanso Mul(phanso p1, phanso p2)
        {
            throw new NotImplementedException();
        }

        internal phanso Div(phanso p1, phanso p2)
        {
            throw new NotImplementedException();
        }

        class Phanso
        {
            private int tuso, mauso;
            public int TuSo
            {
                set { tuso = value; }
                get { return tuso; }
            } public int MauSo
            {
                set { mauso = value; }
                get { return mauso; }
            }
            public void NhapPhanSo()
            {
                Console.WriteLine("TuSo :");
                this.TuSo = TuSo;
                Console.WriteLine("MauSo :");
                do
                    this.MauSo = MauSo;
                while (this.mauso == 0);

            }
            public void InPhanso()
            {
                Console.Write("Phan so = " + tuso + "/" + mauso);
            }
            public Phanso Add(Phanso a, Phanso b)
                {
                Phanso c = new Phanso();
                c.tuso = a.tuso * b.mauso + a.mauso * b.tuso;
                c.mauso = a.mauso * b.mauso;
                return c;
                }public Phanso Sub(Phanso a, Phanso b)
                {
                Phanso c = new Phanso();
                c.tuso = a.tuso * b.mauso - a.mauso * b.tuso;
                c.mauso = a.mauso * b.mauso;
                return c;
                }public Phanso Mul(Phanso a, Phanso b)
                {
                Phanso c = new Phanso();
                c.tuso = a.tuso * b.tuso;
                c.mauso = a.mauso * b.mauso;
                return c;
                }public Phanso Div(Phanso a, Phanso b)
                {
                Phanso c = new Phanso();
                c.tuso = a.tuso * b.mauso;
                c.mauso = a.mauso * b.tuso;
                return c;
                }
        }

    }
}
