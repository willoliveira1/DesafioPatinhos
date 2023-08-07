using AceleraZG.Models.Interfaces;

namespace AceleraZG.Models;

public class Patinhos : IPatinhos
{
    public int Quantidade { get; set; }

    public Patinhos(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("Erro: A quantidade de patinhos não pode ser menor ou igual a zero.");
        }
        Quantidade = quantidade;
    }

    public void Musica()
    {
        int quantidadeAtual = Quantidade;

        for (int i = 1; i <= Quantidade; i++)
        {
            if (quantidadeAtual > 2)
            {
                VersoVariosPatinhos(quantidadeAtual, false);
                quantidadeAtual--;
            }
        }
        VersoVariosPatinhos(2, true);
        VersoUmPatinho();
        VersoFinal(Quantidade);
    }

    private void VersoVariosPatinhos(int quantidade, bool RestaDoisPatinhos)
    {
        string frase = RestaDoisPatinhos
            ? "patinho.\nVoltou de lá" 
            : "patinhos.\nVoltaram de lá";

        Console.WriteLine(
            $"\n{quantidade} patinhos" +
            $"\nForam passear" +
            $"{PrimeiraFraseRepetida()}" +
            $"{SegundaFraseRepetida()}" +
            $"\nMas só {quantidade - 1} {frase}."
        );
    }

    private void VersoUmPatinho()
    {
        Console.WriteLine(
            $"\n1 patinho" +
            $"\nFoi passear" +
            $"{PrimeiraFraseRepetida()}" +
            $"{SegundaFraseRepetida()}" +
            $"\nMas nenhum patinho." +
            $"\nVoltou de lá."
        );
    }

    private void VersoFinal(int quantidade)
    {
        string frase = (quantidade == 1) 
            ? $"E o patinho\nVoltou de lá." 
            : $"E os {quantidade} patinhos\nVoltaram de lá.";

        Console.WriteLine(
            $"\nPoxa, a mamãe patinha ficou tão triste naquele dia" +
            $"\nAonde será que estavam os seus filhotinhos?" +
            $"\nMas essa história vai ter um final feliz" +
            $"\nSabe por quê?\n" +
            $"\nA mamãe patinha foi procurar" +
            $"\nAlém das montanhas" +
            $"\nNa beira do mar" +
            $"{SegundaFraseRepetida()}" +
            $"\n{frase}"
        );
    }

    private string PrimeiraFraseRepetida()
    {
        return $"\nAlém das montanhas\nPara brincar";
    }

    private string SegundaFraseRepetida()
    {
        return $"\nA mamãe gritou\nQuá, quá, quá, quá";
    }
}
