/*
    Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
    um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
    4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
    que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
    mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
    exemplo.
*/

using System;

namespace Exercicios {
    class Exercicios {
        static void Main(string[] args) {

            int contagemAlcool = 0;
            int contagemGasolina = 0;
            int contagemDiesel = 0;

            Console.WriteLine("Combustíveis \n1- Álcool \n2- Gasolina \n3- Diesel\n4- Sair");
            Console.Write("Escolha o seu combustível preferido : ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 4){

                if (opcao < 1 || opcao > 4) {
                    Console.WriteLine("OPÇÃO INVÁLIDA");                    
                } 
                else if (opcao == 1) {
                    contagemAlcool += 1;
                }
                else if (opcao == 2){
                    contagemGasolina += 1;
                }
                else if (opcao == 3){
                    contagemDiesel += 1;
                } else {
                    Console.WriteLine("FIM");
                    break;
                }

                Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("Combustíveis \n1- Álcool \n2- Gasolina \n3- Diesel\n4- Sair");
                Console.Write("Escolha o seu combustível preferido : ");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Total");
            Console.WriteLine($"Gasolinha: {contagemGasolina}");
            Console.WriteLine($"Álcool: {contagemAlcool}");
            Console.WriteLine($"Diesel: {contagemDiesel}");

            Console.ReadKey();

        }
        
    }
}