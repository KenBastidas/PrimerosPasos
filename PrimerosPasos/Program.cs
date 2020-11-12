using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos
            int a, b, suma;// delcarara una avariable type entero
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {0} + {1} = {2}", a, b, suma);
            
            //type of date: number in coma flotante
            float sueldo, egreso, total;
            Console.WriteLine("Ingrese el sueldo del trabajador: ");
            sueldo = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los gatos del trabajador: ");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;

            Console.WriteLine("El liquido a recibir es:{0}", total);

            //case sensitive

            //type of date: flotante de doble precicisón
            double x1 = 200.5679;
            Console.WriteLine("Tipo de dato: {0}", x1);

            //type of date:Cadena de caracteres (string)
            String nombre;

            Console.WriteLine("Ingresa your name: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + "welcome al cursoof programacion!!!");
            //type of date:Booleano(type logic:true/false)
            bool sw;
            sw = (a+50) > b;
            Console.WriteLine("El valor del booleano sw: {0}", sw);



            Console.ReadKey();
        }
    }
}
