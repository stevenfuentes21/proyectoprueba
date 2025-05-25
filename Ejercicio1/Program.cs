using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horTraba;
            double costHora, sueldo;

            Console.WriteLine("Ingrese las horas de trabajo: ");
            horTraba = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo por hora: ");
            costHora = double.Parse(Console.ReadLine());
            
            //proceso
            sueldo = horTraba * costHora;

            Console.WriteLine("El sueldo total es: " + sueldo);
            Console.ReadKey();
            Console.WriteLine("El sueldo total es: " + sueldo);
            Console.ReadKey();
            Console.WriteLine("El sueldo total es: " + sueldo);
            Console.ReadKey();
            Console.WriteLine("El sueldo total es: " + sueldo);
            Console.ReadKey();
        }
    }
}
