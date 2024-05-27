/*  Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
    começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas
*/

using System;

namespace Exercicios
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            int horarioInicial, horarioFinal, duracaoDoJogo;
            Console.Write("Digite o horário que começou o jogo: ");
            horarioInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite o horario que terminou o jogo: ");
            horarioFinal = int.Parse(Console.ReadLine());

            if (horarioFinal < horarioInicial){
                duracaoDoJogo = (horarioFinal + 24) - horarioInicial;
            }
            else { 
                duracaoDoJogo = horarioFinal - horarioInicial;
            }

            string mensagem = duracaoDoJogo > 1 ? "HORAS" : "HORA";

            Console.WriteLine($"O jogo demorou {duracaoDoJogo} {mensagem}");
            Console.ReadKey();

        }
    }
}