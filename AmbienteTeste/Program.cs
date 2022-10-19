using System;

namespace AmbienteTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //NÚMERO PRIMO
            int numero;

            Console.WriteLine("Entre com um número para verificação se é primo: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (NumeroPrimo(numero))
                Console.WriteLine("\nÉ PRIMO!");
            else
                Console.WriteLine("\nNÃO É PRIMO!");

            ////SEQUÊNCIA DE FIBONACCI
            //int numero;

            //Console.WriteLine("Entre com o número desejado da sequência de Fibonacci: ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(SequenciaFibonacci(numero));

            ////PIRÂMIDE COM CARACTERES ASC (#)
            //int numero = 0;

            //while (numero < 3 || numero > 8)
            //{
            //    Console.WriteLine("Entre com o número de andares da pirâmide: ");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"\n{ConstroiPiramide(numero)}");
        }

        public static bool NumeroPrimo(int n)
        {
            int aux = 0;
            if (n == 1)
                aux++;

            for (int i = 1; i <= n; i++)
            {
                int resto = n % i;
                if (resto == 0)
                    aux++;
            }

            if (aux == 2)
                return true;
            else
                return false;
        }

        public static string SequenciaFibonacci(int n)
        {
            int n0 = 0;
            int n1 = 1;
            string resultado = $"{n0} {n1}";

            if (n >= 3)
            {
                for (int i = 2; i < n; i++)
                {
                    n1 = n0 + n1;
                    n0 = n1 - n0;
                    resultado += $" {n1}";
                }
            }

            return resultado;
        }

        public static string ConstroiPiramide(int n)
        {
            string resultado = "";
            string aux = "";

            for (int i = 0; i < n; i++)
            {
                aux += "#";
                resultado += $"{aux}\n";
            }

            resultado += "\n\n--------------------------------------\n\n";

            aux = "";
            for (int i = 0; i < n; i++)
            {
                aux += "#";
                for (int j = i + 1; j < n; j++)
                {
                    resultado += " ";
                }
                resultado += $"{aux}\n";
            }

            resultado += "\n\n--------------------------------------\n\n";

            aux = "#";
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    resultado += " ";
                }
                resultado += $"{aux}\n";
                aux += "##";
            }

            return resultado;
        }
    }
}
