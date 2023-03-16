using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace desafioTarget1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inverteString();
        }

        static void fibonacci(int valor)
        {
            int ultimoValor = 0;
            int valor1 = 1;
            int valor2 = 1;

            while (ultimoValor < valor)
            {
                ultimoValor = valor1 + valor2;
                valor1 = valor2;
                valor2 = ultimoValor;
            }

            if (ultimoValor == valor)
            {
                Console.WriteLine("O número informado pertence à sequência de Fibonacci.");
            } else
            {
                Console.WriteLine("O número informado NÃO pertence à sequência de Fibonacci.");
            }

            Console.ReadKey();
        }

        static void inverteString()
        {
            string entrada = "amarelo";
            string saida = "";
            int tamanho = entrada.Length;

            for (int i = tamanho; i > 0; i--)
            {
                saida += entrada[i-1];
            }

            Console.WriteLine(saida);

            Console.ReadKey();
        }
    }
}
