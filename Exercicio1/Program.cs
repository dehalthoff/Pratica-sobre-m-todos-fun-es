using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva uma função que imprima a mensagem bem vindo quantas vezes o usuário desejar.
            //utilize um parametro na função para informar quantas vezes o usuário deseja que a mensagem seja exibida.
            //Exemplo: boasVindas(7);


            Console.WriteLine("infrome o numero de interações");
            int numInformado = int.Parse(Console.ReadLine());
            boasVindas(numInformado);

            Console.ReadKey();


        }

        public static void boasVindas(int numInformado)
        {
            for (int i = 0; i < numInformado; i++)
            {
                Console.WriteLine("Boas Vindas!!!");

            }
        }
    }
    }
}
