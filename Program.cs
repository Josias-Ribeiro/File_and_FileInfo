using System;
using System.IO;
using static System.Console;

WriteLine("Digite o nome do arquivo");
var nome = ReadLine();
nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);
WriteLine("Digite enter para finalizar");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var caractere in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(caractere, '-');
    }

    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        var sw = File.CreateText(path);

        sw.WriteLine("Primeira linha do arquivo");
        sw.Flush();
    }
    catch
    {

        WriteLine("Nome do arquivo inválido");
    }


}


