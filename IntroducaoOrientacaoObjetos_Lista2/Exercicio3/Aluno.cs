/*
    Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
    (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no 
    ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam 
    para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver 
    este problema.
*/

using System;

class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    // Método responsável pela nota final do aluno
    public double NotaFinal()
    {
        return Nota1 + Nota2 + Nota3;
    }

    public bool Aprovacao()
    {
        if ( NotaFinal() >= 60)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PontosRestantes()
    {
        double notaRestante = 60 - NotaFinal();
        Console.Write($"Pontos mínimos para ser aprovado: {notaRestante}");
    }

}