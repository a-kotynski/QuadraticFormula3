using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticFormula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie wykonywane jest bez liczb zespolonych

            Console.WriteLine("Wpisz współczynniki liczbowe a, b i c." + Environment.NewLine +
                "Pamiętaj, aby współczynnik a był równy lub większy 0." + Environment.NewLine);

            Console.Write("Wpisz współczynnik a: ");
            double valueA = Convert.ToDouble(Console.ReadLine());

            //while (!Double.TryParse(Console.ReadLine(), out valueA)) ???
            if (valueA == 0)
            {
                Console.WriteLine("Równanie ze współczynnikiem a równym 0 " +
                    "nie jest równaniem kwadratowym.");
                return;
            }

            Console.Write("Wpisz współczynnik b: ");
            double valueB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wpisz współczynnik c: ");
            double valueC = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Root(valueA, valueB, valueC);
        }

        public static void Menu()
        {

        }

        public static void Root(double valueA, double valueB, double valueC)
        {
            double delta = (valueB * valueB) - (4 * valueA * valueC);

            double firstRoot = (-1 * valueB - Math.Sqrt(delta)) / (2 * valueA);
            double secondRoot = (-1 * valueB + Math.Sqrt(delta)) / (2 * valueA);
            double zeroRoot = (-1 * valueB) / (2 * valueA);

            if (delta > 0)
            {
                Console.WriteLine("Pierwiastki x1 i x2 wynoszą kolejno: {0} {1}",
                    firstRoot, secondRoot);
                Console.ReadLine();
            }
            if (delta < 0)
            {
                Console.WriteLine("Pierwiastek x wynosi: {0}", zeroRoot);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Wynik należy do zbioru liczb zespolonych");
                Console.ReadLine();

            }
        }
    }
}