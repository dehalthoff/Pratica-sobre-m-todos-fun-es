using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escreva 4 funções para cada operação matemática(soma, subtração, multiplicação ou divisão).a seguir,
            //escreva uma função chamada operacao que receba dois numeros como parametro e um terceiro parametro do tipo string que informe
            //qual operação deseja fazer(soma, subtração, multiplicação ou divisão). no programa principal, o usuário ira chamar a função operacao.
            //Exemplo: operacao(11, 22, "somar");

            string calculadora = "";
            int prinumero = 0;
            int segnumero = 0;

            operacao(calculadora, prinumero, segnumero);
            Console.ReadKey();
        }

        public static void operacao(string calculadora, int prinumero, int segnumero)
        {
            Console.WriteLine("Qual operação deseja fazer? \n");
            Console.WriteLine("1 - Somar? \n");
            Console.WriteLine("2 - Subtrair? \n");
            Console.WriteLine("3 - Multiplicar? \n");
            Console.WriteLine("4 - Dividir? \n");
            int numInformado = int.Parse(Console.ReadLine());
            if (numInformado == 1)
            {
                somar();
            }
            else if (numInformado == 2)
            {
                subtrair();
            }
            else if (numInformado == 3)
            {
                multiplicar();
            }
            else
            {
                dividir();
            }
        }
        public static void somar()
        {
            double soma = 0;
            Console.WriteLine("Digite o primeiro numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            int numero2 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2;

            Console.WriteLine("A soma é " + soma);
        }

        public static void subtrair()
        {
            double subtrairNumeros = 0;
            Console.WriteLine("Digite o primeiro numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            int numero2 = int.Parse(Console.ReadLine());

            subtrairNumeros = numero1 - numero2;

            Console.WriteLine("A subtração é " + subtrairNumeros);
        }
        public static void multiplicar()
        {
            double multiplicarNumeros = 0;
            Console.WriteLine("Digite o primeiro numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            int numero2 = int.Parse(Console.ReadLine());

            multiplicarNumeros = numero1 * numero2;

            Console.WriteLine("A multiplicação é " + multiplicarNumeros);
        }
        public static void dividir()
        {
            double dividirNumeros = 0;
            Console.WriteLine("Digite o primeiro numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            int numero2 = int.Parse(Console.ReadLine());

            dividirNumeros = numero1 / numero2;

            Console.WriteLine("A divisão é " + dividirNumeros);
        }
    }
}
