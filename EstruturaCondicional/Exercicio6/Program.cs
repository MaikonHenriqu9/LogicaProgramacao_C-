/*  Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
    seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
    nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. */

using System; 

namespace Exercicio
{
    class Exercicio6
    {
        static void Main(string[] args) {
            int numero;
            Console.Write("Digite um valor: ");
            numero = int.Parse(Console.ReadLine());
            
            string resultado = VerificarIntervalo(numero);

            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        static string VerificarIntervalo(int numero) {

            string mensagem;

            if (numero < 0 || numero > 100){
                mensagem = $"{numero} está fora do intervalo";

            } else if (numero <= 25) {
                mensagem = $"{numero} está entre os valores até 25";

            } else if (numero <= 50) {
                mensagem = $"{numero} está entre os valores até 50";

            } else if (numero <= 75) {
                mensagem = $"{numero} está entre os valores até 75";

            } else{
                mensagem = $"{numero} está entre os valores até 100";

            }

            return mensagem;

        }

    }
}