/*
    Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
    essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/

using System;

namespace Exercicios {
    class Exercicios {
        static void Main(string[] args) {
            Console.Write("Digite a quantidade de número que deseja digitar: ");
            int quantidadeValor = int.Parse(Console.ReadLine());
            int intervalo = 0;
            int fora_intervalor = 0;

            for (int i = 1; i <= quantidadeValor; i++){

                Console.Write($"Informe o {i}° valor: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20){
                    intervalo = intervalo + 1;
                } 
                else{
                    fora_intervalor = fora_intervalor  + 1;
                }

            }

            Console.WriteLine($"{intervalo} in");
            Console.WriteLine($"{fora_intervalor} out");
            Console.ReadKey();

        }
    }
}