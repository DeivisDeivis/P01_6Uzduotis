using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_6Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

         
            Console.Write("Iveskite 1 sienos ilgi ");
            double ilgis1 = double.Parse(Console.ReadLine());

            Console.Write("Iveskite 1 sienos ploti ");
            double plotis1 = double.Parse(Console.ReadLine());

            Console.Write("Iveskite 2 sienos ilgi ");
            double ilgis2 = double.Parse(Console.ReadLine());

            Console.Write("Iveskite 2 sienos ploti");
            double plotis2 = double.Parse(Console.ReadLine());

            Console.Write("Iveskite 3 sienos ilgi");
            double ilgis3 = double.Parse(Console.ReadLine());

            Console.Write("Iveskite 3 sienos ploti ");
            double plotis3 = double.Parse(Console.ReadLine());

            Console.Write("Iveskite 4 sienos ilgi ");
            double ilgis4 = double.Parse(Console.ReadLine());

            Console.Write("Iveskite 4 sienos plotiS ");
            double plotis4 = double.Parse(Console.ReadLine());

            
            namas Namas = new namas(ilgis1, ilgis2, ilgis3, ilgis4, plotis1, plotis2, plotis3, plotis4);

            double visosvidinesplytos = Namas.ApskaiciuotiIsorinesPlytas();
            double visosisorinesplytos = Namas.ApskaiciuotiVidinesPlytas();

            Console.WriteLine("Visos reikalingos vidines plytos");
            Console.WriteLine();
            Console.WriteLine(visosvidinesplytos);
            Console.WriteLine("Visos reikalingos isorines plytos");
            Console.WriteLine();
            Console.WriteLine(visosisorinesplytos);
        }
    }

   class namas
    {
        private double ilgis1, ilgis2, ilgis3, ilgis4, plotis1, plotis2, plotis3, plotis4;
        private int plytos_storis = 2;
        private double isorinesplytosplotas = 0.5;

        public namas(double len1, double hgt1, double len2, double hgt2, double len3, double hgt3, double len4, double hgt4)
        {
            ilgis1 = len1;
            plotis1 = hgt1;
            ilgis2 = len2;
            plotis2 = hgt2;
            ilgis3 = len3;
            plotis3 = hgt3;
            ilgis4 = len4;
            plotis4 = hgt4;
        }

        public double ApskaiciuotiIsorinesPlytas()
        {
            double plotas1 = (ilgis1 * plotis1) * 2; // Two sides of the first wall
            double plotas2 = (ilgis2 * plotis2) * 2; // Two sides of the second wall
            double plotas3 = ( ilgis3* plotis3) * 2; // Two sides of the third wall
            double plotas4 = (ilgis4 * plotis4) * 2; // Two sides of the fourth wall

            double VisasIsorinisPlotas = plotas1 + plotas2 + plotas3 + plotas4;
            double VisosIsorinesPlytos = VisasIsorinisPlotas / (plytos_storis * isorinesplytosplotas);

            return VisosIsorinesPlytos;
        }
        public double ApskaiciuotiVidinesPlytas( )
        {
           
            double VidinisPlotas = (ilgis1 - 4) * (plotis1 - 4) + (ilgis2 - 4) * (plotis2 - 4) +
                              (ilgis3 - 4) * (plotis3 - 4) + (ilgis4 - 4) * (plotis4 - 4);

            double VisosVidinesPlytos =VidinisPlotas / (plytos_storis * isorinesplytosplotas);

            return VisosVidinesPlytos;
        }

    }
}
 

