using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekursinisMedis
{
    class Program
    {
        static void Main(string[] args)
        {
            Saka saka0 = new Saka();
            Saka saka10 = new Saka();
            Saka saka11 = new Saka();
            Saka saka100 = new Saka();
            Saka saka101 = new Saka();
            Saka saka110 = new Saka();
            Saka saka111 = new Saka();
            Saka saka1000 = new Saka();
            Saka saka1010 = new Saka();
            Saka saka1011 = new Saka();
            Saka saka1110 = new Saka();
            Saka saka1111 = new Saka();
            Saka saka10000 = new Saka();
            Saka saka10001 = new Saka();
            Saka saka11100 = new Saka();
            Saka saka100010 = new Saka();
            Saka saka111000 = new Saka();
            Saka saka111001 = new Saka();
            Saka saka1110010 = new Saka();

            saka0.sakos = new List<Saka>();
            saka10.sakos = new List<Saka>();
            saka11.sakos = new List<Saka>();
            saka100.sakos = new List<Saka>();
            saka101.sakos = new List<Saka>();
            saka110.sakos = new List<Saka>();
            saka111.sakos = new List<Saka>();
            saka1000.sakos = new List<Saka>();
            saka1010.sakos = new List<Saka>();
            saka1011.sakos = new List<Saka>();
            saka1110.sakos = new List<Saka>();
            saka1111.sakos = new List<Saka>();
            saka10000.sakos = new List<Saka>();
            saka10001.sakos = new List<Saka>();
            saka11100.sakos = new List<Saka>();
            saka100010.sakos = new List<Saka>();
            saka111000.sakos = new List<Saka>();
            saka111001.sakos = new List<Saka>();
            saka1110010.sakos = new List<Saka>();

            saka0.sakos.Add(saka10);
            saka0.sakos.Add(saka11);
            saka10.sakos.Add(saka100);
            saka10.sakos.Add(saka101);
            saka11.sakos.Add(saka110);
            saka11.sakos.Add(saka111);
            saka100.sakos.Add(saka1000);
            saka101.sakos.Add(saka1010);
            saka101.sakos.Add(saka1011);
            saka111.sakos.Add(saka1110);
            saka111.sakos.Add(saka1111);
            saka1000.sakos.Add(saka10000);
            saka1000.sakos.Add(saka10001);
            saka1110.sakos.Add(saka11100);
            saka10001.sakos.Add(saka100010);
            saka11100.sakos.Add(saka111000);
            saka11100.sakos.Add(saka111001);
            saka111001.sakos.Add(saka1110010);

            Console.WriteLine($"Didziausias medzio gylis yra {RekursiskaiPaskaiciuojaDidziausiaMedzioGyli(saka0.sakos, 1)}");
            Console.ReadLine();
        }

        public static int RekursiskaiPaskaiciuojaDidziausiaMedzioGyli(List<Saka> saka, int gylis)
        {
            int didziausiasGylis = gylis;

            if (saka.Count > 0)
            {
                for (int i = 0; i < saka.Count; i++)
                {
                    if (didziausiasGylis < RekursiskaiPaskaiciuojaDidziausiaMedzioGyli(saka.ElementAt(i).sakos, gylis + 1))
                    {
                        didziausiasGylis = RekursiskaiPaskaiciuojaDidziausiaMedzioGyli(saka.ElementAt(i).sakos, gylis + 1);
                    }
                }
            }
            return didziausiasGylis;
        }
    }
}
