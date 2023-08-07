using AceleraZG.Models;
using AceleraZG.Models.Interfaces;

namespace AceleraZG.Services;

public static class PatinhosService
{
    public static void GerarMusica()
    {
        while (true)
        {
            try
            {
                Console.Write("Informe a quantidade de patinhos: ");
                int qtdePatinhos = int.Parse(Console.ReadLine());

                IPatinhos patinhos = new Patinhos(qtdePatinhos);
                patinhos.Musica();
                break;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                AguardarLeituraErro();
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Valor inválido.");
                AguardarLeituraErro();
            }
        }
    }

    private static void AguardarLeituraErro()
    {
        Thread.Sleep(1200);
        Console.Clear();
    }
}
