    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


// Michel Rosales
// Fecha: 17 de Marzo de 2022
// Encuentra el área de un rectángulo que tiene una base de 20 cm y una altura de 12 cm²



namespace Ejercicio_1
    {
        class Program
        {
            static void Main(string[] args)
            {

                double Base, Altura, area;

                Console.Title = "Area de un rectangulo";
                Console.WriteLine("Base");
                Base = double.Parse(Console.ReadLine());

                Console.WriteLine("Altura");
                Altura = double.Parse(Console.ReadLine());


                // Procesamiento de datos

                area = ((Base * Altura));

                Console.WriteLine("La area de un rectangulo es : {0} cm²  ", area);
                Console.ReadKey(); 









            }
        }
    }
