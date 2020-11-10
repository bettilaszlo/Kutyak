using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Kutyak
{
    class Program
    {
        static List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        static List<Kutyafajta> kutyafajtak = new List<Kutyafajta>();
        static List<Kutya> kutyalista = new List<Kutya>();
        static void KutyaNevekBeolvasas()
        {
            StreamReader be = new StreamReader("KutyaNevek.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyaNevek.Add(new KutyaNev(
                  Convert.ToInt32(adat[0]),
                  adat[1]
                ));
            }
            be.Close();
        }
        static void Harmadik()
        {
            Console.WriteLine("3. feladat: Kutyanevek száma: {0}", kutyaNevek.Count);
        }
        static void KutyafajtakBeolvasas()
        {
            StreamReader be = new StreamReader("KutyaFajtak.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyafajtak.Add(new Kutyafajta(Convert.ToInt32(adat[0]), adat[1], adat[2]));
            }
            be.Close();
        }
        static void Negyedik()
        {
            Console.WriteLine(kutyafajtak.Count);
        }
        static void KutyaBeolvasas()
        {
            StreamReader be = new StreamReader("Kutyak.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyalista.Add(new Kutya(Convert.ToInt32(adat[0]), Convert.ToInt32(adat[1]),
                    Convert.ToInt32(adat[2]), Convert.ToInt32(adat[3]), adat[4]));
            }
            be.Close();
         }
    
        static void Main(string[] args)
        {
            KutyaNevekBeolvasas();
            Harmadik();
            KutyafajtakBeolvasas();
            Negyedik();
            KutyaBeolvasas();
            Console.WriteLine(kutyalista.Count);

            //foreach (var k in kutyaNevek)
            //{
            //    Console.WriteLine(k.Nev);
            //}
            Console.ReadKey();
        }
    }
}

