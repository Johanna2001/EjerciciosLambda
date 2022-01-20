using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };

            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes

            Console.WriteLine("");
            var q = details.Select(emp => new { emp.Nombre, emp.Apellido });
            Console.WriteLine(string.Join(" \n", q));

            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine(" ");
            var multiz = details.OrderByDescending(prome => prome.Promedio).Select(x => new { x.Nombre, x.Apellido });
            Console.WriteLine(string.Join(" \n", multiz));

            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            Console.WriteLine("");
            var multiz1 = details.OrderBy(prome => prome.Apellido).Select(x => new { x.Apellido });
            Console.WriteLine(string.Join(" \n", multiz1));

            //4. Muestre por pantalla los datos del estudiante mas joven
            //Console.WriteLine("");
           // var edad1 = details.OrderBy(x => new { x.Edad, x.Apellido }).First();
            //Console.WriteLine(string.Join("\n", edad1));

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            var numerosAlCuadrado = list.Select(x => x * x);
            Console.WriteLine("El cuadrado de los numeros son los siguientes:");
            foreach (int x in numerosAlCuadrado)
                Console.WriteLine(x);

            
            //2. Muestre por pantalla los números pares
            Func<int, bool> ObtenerPares = (numero) => numero % 2 == 0;
            var pares = list.Where(ObtenerPares);
            Console.WriteLine("Los números pares son:");
            foreach (var item in pares)
            {
                 Console.WriteLine(item);
            }

            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            Func<int, bool> ObtenerImpares = (numero) => numero %2 != 0;
            var impares = list.Where(ObtenerImpares);
            Console.WriteLine("Los números impares son:");
            foreach (var item in impares)
            {
                Console.WriteLine(item);
            }
           Console.WriteLine("La multiplicación de los números Impares son:");
                var multiplicacion = list.Select(item => item * 5);
            foreach (int item in multiplicacion)
            {
                Console.WriteLine(item);
           }
        }
    }
}