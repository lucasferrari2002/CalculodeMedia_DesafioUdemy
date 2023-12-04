 using classesProject.Models;


// Computador AMD4 = new Computador();

// AMD4.Memoria = 16;
// AMD4.placaVideo = "RTX 2080";
// AMD4.Apresentar();

// Pessoa pessoa01 = new Pessoa ();
// pessoa01.Nome = "João";
// pessoa01.Idade = 15;
// pessoa01.Exibir();




// int b = 4;
// int x = 30;
// int c = b + x;
// c += 5;
// c *= 2;
// Console.WriteLine(c);

// string a = Convert.ToString(55);
// Console.WriteLine(a);


// Calculadora calc = new Calculadora();

// calc.Mutiplicar(56, 10);


// int numero = 0;
// Console.WriteLine("Faça a contagem de 1 a 10");
// for (int contador = 0; contador <= 10; contador++)
// {   
//     Console.WriteLine($"{numero + contador}");
// }


// int numeroPremiado = 2 ;
// int numero = 0;
// int contador = 1;

// Console.WriteLine("Digite um numero e veja se é o premiado");
// do { 
//     if(contador == 6){
//         Console.WriteLine("Suas chances se esgotaram");
//         break;

//     }
//     Console.WriteLine($"Tentativa {contador}");
//     numero = Convert.ToInt32(Console.ReadLine());
//     contador++;
    
    

// }while(numero != numeroPremiado);
// if(numero == numeroPremiado) 
// {
//     Console.WriteLine("Parabens você acertou");

// }else{
//     Console.WriteLine("Continue tentando");
// }


// int numeroPremiado = 2;
// int numero;
// int tentativasMaximas = 5;

// Console.WriteLine("Digite um número e veja se é o premiado");
// for (int contador = 1; contador <= tentativasMaximas; contador++)
// {
//     Console.WriteLine($"Tentativa {contador}");
//     numero = Convert.ToInt32(Console.ReadLine());

//     if (numero == numeroPremiado)
//     {
//         Console.WriteLine("Parabéns, você acertou");
//         break;
//     }

//     if (contador == tentativasMaximas)
//     {
//         Console.WriteLine("Suas chances se esgotaram");
//         break;
//     }

//     Console.WriteLine("Continue tentando");
// }

// Calculadora calc = new Calculadora();

// calc.Soma(2, 5);
// Console.WriteLine(calc);

int [] pares = new int[] {2, 4, 6, 8, 10};
Console.WriteLine(pares[0]);

pares[0] = 6;
Console.WriteLine(pares[0]);

pares[4] = 2;
Console.WriteLine(pares[4]);

int [] impar = new int[5];
impar[0] = 1;

