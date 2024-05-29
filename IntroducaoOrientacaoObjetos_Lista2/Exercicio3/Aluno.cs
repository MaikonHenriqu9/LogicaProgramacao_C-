/*
    Fazer um programa para ler o nome de um aluno e as tr�s notas que ele obteve nos tr�s trimestres do ano 
    (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no 
    ano. Dizer tamb�m se o aluno est� APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam 
    para o aluno obter o m�nimo para ser aprovado (que � 60 pontos). Voc� deve criar uma classe Aluno para resolver 
    este problema.
*/

using System;

class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    // M�todo respons�vel pela nota final do aluno
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
        Console.Write($"Pontos m�nimos para ser aprovado: {notaRestante}");
    }

}