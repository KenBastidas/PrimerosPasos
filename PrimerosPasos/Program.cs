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

            //Pilares fundamnetales de la programacion estructurada
            //Ejecution de sentencias secuenciales
            //Uso de estructures repetitiveas
            //Uso de estructures selectivas
            saludos(nombre);
            saludos("jose alcivar");
            saludos("maria castro");

            Console.WriteLine();
            Console.WriteLine("Llamada a funcion que devuleve valor");
            Console.WriteLine("Liquido a recibir para Juan {0}", calcularSueldo(300,200));
            Console.WriteLine("Liquido a recibir para Carlos {0}", calcularSueldo(2000, 1000));
            Console.WriteLine("Liquido a recibir para Lesli {0}", calcularSueldo(1340, 199));

            figurata();

            Console.WriteLine("El cuadrado de este numero es: {0}", funcioncuadrado(6));

            Console.ReadKey();
            //end to main
        }
        //Funciones: subpocesos - subprogramas - subrutinas
        //dividir el code en modulos
        //Reutilizar el codigo
        //tipo: devuelven valores- no devuelven valores
        static void saludos(string nombre) //parametro - argumento
        {
            Console.WriteLine("Funcion que no devuelve valores...");
            Console.WriteLine("Hola {0} ", nombre);
        }

            //funcion que deuleve valor
            //la funcion devuelve un tipo de dato
        static int calcularSueldo(int ingreso, int egreso)
        {
            return ingreso-egreso;
        }
        //Crear la funcion que imprima la siguiente figura
        /*  
              *
             ***
            ***** 
           *******     
        */
        static void figurata()
        {
            Console.WriteLine("    *    ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****  ");
            Console.WriteLine(" ******* ");
        }

         
        //Crear la funcion que recibe un parametro entero y devuelve el cuadrado de este entero
        static int funcioncuadrado(int K)
        {
            int Sacarcuadrado = K * K;
            return Sacarcuadrado;
        }
    }
}
