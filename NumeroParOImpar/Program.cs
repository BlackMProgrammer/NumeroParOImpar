using System;

namespace NumeroParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un Numero");
            string num1 = Console.ReadLine();

            int num = Convert.ToInt32(num1);

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero {0} es par.", num);
            }
            else {
                Console.WriteLine("El numero {0} es impar.",num);
            }
        }
    }
}
