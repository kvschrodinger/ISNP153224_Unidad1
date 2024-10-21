using System;

namespace ISNP153224_Unidad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("\n Ejercicios");
                Console.WriteLine("1. Mostrar si un número es positivo o negativo.");
                Console.WriteLine("2. Mostrar la tabla de multiplicar de un número entre 1 y 10.");
                Console.WriteLine("3. Suma de números positivos.");
                Console.WriteLine("4. Verificar si un número es primo.");
                Console.WriteLine("5. Calcular el promedio de una serie de números.");
                Console.WriteLine("Introduce cualquier otro caracter para salir");
                Console.Write("Selecciona un ejercicio: ");
                int opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        PositivoONegativo();
                        break;
                    case 2:
                        TablaDeMultiplicar();
                        break;
                    case 3:
                        SumarNumerosPositivos();
                        break;
                    case 4:
                        VerificarNumeroPrimo();
                        break;
                    case 5:
                        CalcularPromedio();
                        break;
                    default:
                        continuar = "n";
                        break;
                }
            }
        }

        static void PositivoONegativo()
        {
            int num;
            do
            {
                Console.Write("Introduce un número (Introduce 0 para finalizar): ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                    Console.WriteLine("El número {0} es positivo.", num);
                else if (num < 0)
                    Console.WriteLine("El número {0} es negativo.", num);

            } while (num != 0);
        }

        static void TablaDeMultiplicar()
        {
            int num;
            do
            {
                Console.Write("Introduce un número entre 1 y 10 (Introduce 0 para finalizar): ");
                num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 10)
                {
                    Console.WriteLine("Tabla de multiplicar del {0}:", num);
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
                    }
                }
                else if (num != 0)
                {
                    Console.WriteLine("Número fuera del rango. Favor introduzca un número entre 1 y 10.");
                }
            } while (num != 0);
        }

        static void SumarNumerosPositivos()
        {
            int num;
            int suma = 0;
            do
            {
                Console.Write("Introduce un número positivo (Introduce 0 o un número negativo para finalizar): ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    suma += num;
                }
            } while (num > 0);

            Console.WriteLine("La suma de los números positivos introducidos es: {0}", suma);
        }

        static void VerificarNumeroPrimo()
        {
            Console.Write("Introduce un número para verificar si es primo: ");
            int num = int.Parse(Console.ReadLine());
            bool esPrimo = num > 1;

            for (int i = 2; i <= Math.Sqrt(num) && esPrimo; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                }
            }

            if (esPrimo)
                Console.WriteLine("El número {0} es primo.", num);
            else
                Console.WriteLine("El número {0} no es primo.", num);
        }

        static void CalcularPromedio()
        {
            int num;
            int suma = 0;
            int contador = 0;

            Console.WriteLine("Introduce números para calcular el promedio (Introduce 0 para finalizar):");
            do
            {
                Console.Write("Número: ");
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    suma += num;
                    contador++;
                }
            } while (num != 0);

            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                Console.WriteLine("El promedio de los números es: {0}", promedio);
            }
            else
            {
                Console.WriteLine("No se introdujeron números para calcular el promedio.");
            }
        }
    }
}
