using System;
using System.Globalization;
using Udemy;

NotaFinal alunoX = new NotaFinal();
Console.Write("Insira o nome do aluno: ");
alunoX.NomeDoAluno = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
alunoX.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
alunoX.PrimeiroSemestre();
Console.WriteLine();
alunoX.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
alunoX.SegundoSemestre();
Console.WriteLine();
alunoX.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
alunoX.TerceiroSemestre();
Console.WriteLine();
alunoX.SomaFinal();
Console.WriteLine($"Nota final: {alunoX.SomaFinal().ToString("F2", CultureInfo.InvariantCulture)} ");
alunoX.Aprovado();



/*Console.WriteLine(alunoX.Nota1);*/

