using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия");
            ArithProgression arith=new ArithProgression();
            arith.setStart(5);
            arith.setStep(3);
            Console.WriteLine("Вывод первых 4 чисел");
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine("Возврат к первоночальному значению и вывод 3 чисел");
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine("Геометрическая прогрессия");
            GeometricProgression geometric = new GeometricProgression();
            geometric.setStart(2);
            geometric.setStep(2);
            Console.WriteLine("Вывод первых 4 чисел");
            Console.WriteLine(geometric.getNext());
            Console.WriteLine(geometric.getNext());
            Console.WriteLine(geometric.getNext());
            Console.WriteLine(geometric.getNext());
            geometric.reset();
            Console.WriteLine("Возврат к первоночальному значению и вывод 3 чисел");
            Console.WriteLine(geometric.getNext());
            Console.WriteLine(geometric.getNext());
            Console.WriteLine(geometric.getNext());
            geometric.reset();
            Console.ReadKey();
        }
    }
}
