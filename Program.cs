using System;

namespace ActividadMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar las variables
            var valores = new double[4];
            var operaciones = new double[4];
            var comparaciones = new bool[6];

            // Pedir al usuario los 4 números
            Console.WriteLine("Por favor, introduce 4 números separados por espacios:");
            string[] numeros = Console.ReadLine().Split();
            for (int i = 0; i < 4; i++)
            {
                valores[i] = double.Parse(numeros[i]);
            }

            // Realizar las operaciones matemáticas
            operaciones[0] = valores[0] + valores[1] + valores[2] + valores[3]; 
            operaciones[1] = valores[0] * valores[1] * valores[2] * valores[3];
            operaciones[2] = (valores[0] / valores[1]) + (valores[2] / valores[3]);
            operaciones[3] = operaciones[0] / operaciones[1];

            // Realizar las operaciones lógicas
            comparaciones[0] = valores[0] != valores[2];
            comparaciones[1] = valores[1] == valores[3];
            comparaciones[2] = valores[0] > valores[2] || valores[0] > valores[3];
            comparaciones[3] = valores[1] < operaciones[2];
            comparaciones[4] = comparaciones[0] && comparaciones[1]; 
            comparaciones[5] = comparaciones[2] || comparaciones[3]; 

            // Imprimir todas las variables "operación" y todas las variables "compara"
            Console.WriteLine("Los resultados de las operaciones matemáticas son:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"operacion_{i + 1} = {operaciones[i]}"); 
            }
            Console.WriteLine("Los resultados de las operaciones lógicas son:");
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine($"compara_{i + 1} = {comparaciones[i]}");
            }
        }
    }
}
