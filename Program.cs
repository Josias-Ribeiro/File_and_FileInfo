using System;
using System.IO;
using static System.Console;

WriteLine("Digite o nome do arquivo");
var nome = ReadLine();

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

static void CriarArquivo(string path)
{
    var sw = File.CreateText(path);

    sw.WriteLine("Primeira linha do arquivo");
    sw.Flush();
}


