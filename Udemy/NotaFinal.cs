using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Udemy
{
    public class NotaFinal
    {
        public string NomeDoAluno;
        public double Nota1, Nota2, Nota3;
        public void PrimeiroSemestre(){
            bool inserirNota = true;
            while(inserirNota == true){
                if (Nota1 <= 30.0 && Nota1 >= 0.0){
                Nota1 = Nota1;
                inserirNota = false;

                }else{
                Console.WriteLine("Nota maior ou menor que o permitido");
                Console.WriteLine("Insira novamente a nota: ");
                Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                inserirNota = true;
                }
            }
        }
        public void SegundoSemestre(){
            bool inserirNota = true;
            while(inserirNota == true){
                if (Nota2 <= 35.0 && Nota2 >= 0.0){
                Nota2 = Nota2;
                inserirNota = false;

                }else{
                Console.WriteLine("Nota maior ou menor que o permitido");
                Console.WriteLine("Insira novamente a nota: ");
                Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                inserirNota = true;
                }
            }
        }
        public void TerceiroSemestre(){
            bool inserirNota = true;
            while(inserirNota == true){
                if (Nota3 <= 35.0 && Nota3 >= 0.0){
                Nota3 = Nota3;
                inserirNota = false;

                }else{
                Console.WriteLine("Nota maior ou menor que o permitido");
                Console.WriteLine("Insira novamente a nota: ");
                Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                inserirNota = true;
                }
            }
        }
        public double SomaFinal(){
            return Nota1 + Nota2 + Nota3;
        }
        public void Aprovado(){
            if(SomaFinal() >= 60.0){
                Console.WriteLine("APROVADO");
                
            }else{
                double restante = 60.0 - SomaFinal();
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltou: {restante.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}