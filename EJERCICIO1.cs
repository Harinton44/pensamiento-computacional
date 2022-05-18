using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int horastrabajadas;
            int cuotaporhora;
            double sueldo;

            Console.WriteLine("Introduzca el nombre: ");
            nombre = (Console.ReadLine());
            Console.WriteLine("Introduzca las horas trabajadas: ");
            horastrabajadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el pago por hora: ");
            cuotaporhora = int.Parse(Console.ReadLine());

            sueldo = (horastrabajadas * cuotaporhora);
            Console.WriteLine("El nombre de la secretaria es: " + nombre);
            Console.WriteLine("El sueldo es de:" + sueldo);
            Console.ReadKey();


                

        }
    }
}
