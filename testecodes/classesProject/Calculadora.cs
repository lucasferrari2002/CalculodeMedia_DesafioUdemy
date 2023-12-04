using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classesProject.Models
{
    public class Calculadora
    {
        public void Soma(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");

        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
         public void Mutiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
         public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}