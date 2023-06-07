using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Sea bienvenido a la calculadora de la UMG");

        while (true)
        {
            Console.WriteLine("Ingrese la operación que se desea realizar (+, -, *, /):");
            string operacion = Console.ReadLine();

            Console.WriteLine("Ingrese el primer número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Operación inválida");
                    continue;
            }

            Console.WriteLine("El resultado es: " + resultado);
            Console.WriteLine("¿Desea realizar otra operación? (s/n)");
            string continuar = Console.ReadLine();

            if (continuar.ToLower() != "S")
                break;
        }

        Console.WriteLine("Gracias por usar la calculadora de la UMG. Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}