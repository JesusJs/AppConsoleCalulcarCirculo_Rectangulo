using System;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Ejecutar indefinidamente hasta que el usuario cierre la ventana
            {
                Console.WriteLine("Seleccione la figura para calcular su área : \n");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Rectángulo \n");



                Console.WriteLine("Seleccione la opción 1 o 2: \n");
                var respFigura = Console.ReadLine();

                switch (respFigura)
                {
                    case "1":
                        Console.WriteLine("Has seleccionado círculo, por favor ingresa el radio del círculo : ");
                        double radio;
                        while (!double.TryParse(Console.ReadLine(), out radio)) // Validar que la entrada sea un número válido
                        {
                            Console.WriteLine("Entrada inválida, por favor ingrese un número válido para el radio: ");
                        }
                        var areaCirculo = Math.PI * Math.Pow(radio, 2);
                        Console.WriteLine("El área del círculo es: " + areaCirculo);
                        break;

                    case "2":
                        Console.WriteLine("Has seleccionado rectángulo, por favor ingresa la base: ");
                        double baseRectangulo;
                        while (!double.TryParse(Console.ReadLine(), out baseRectangulo)) // Validar que la entrada sea un número válido
                        {
                            Console.WriteLine("Entrada inválida, por favor ingrese un número válido para la base: ");
                        }

                        Console.WriteLine("Ahora ingresa la altura: ");
                        double altura;
                        while (!double.TryParse(Console.ReadLine(), out altura)) // Validar que la entrada sea un número válido
                        {
                            Console.WriteLine("Entrada inválida, por favor ingrese un número válido para la altura: ");
                        }

                        var areaRectangulo = baseRectangulo * altura;
                        Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
                        break;

                    default:
                        Console.WriteLine("Opción no válida, por favor seleccione una opción válida");
                        break;
                }

                Console.WriteLine("Presione cualquier tecla para CONTINUAR o presione 'q' para SALIR.");
                var respuesta = Console.ReadKey();

                if (respuesta.KeyChar == 'q') // Salir si el usuario presiona 'q'
                {
                    break;
                }
                Console.Clear(); // Limpiar la consola para la siguiente iteración
            }
        }
    }
}
