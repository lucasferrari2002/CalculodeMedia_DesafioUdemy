using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoExemplos.Models
{
    public class Pessoa
    {   
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;


        }
        private string _nome;
        public string Nome 
        {
            get {return _nome.ToUpper();}
            
            set 
            {
                if (value == ""){
                    throw new ArgumentException ("Nome é vazio");


                }
                _nome = value;
            }
            
            
            
            
        }
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        private int _idade;
        public int Idade 
        { 
            get{return _idade;}
            
            
            
            
            
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException ("Idade não corresponde");
                }
                _idade = value;



            }

        
        }

        public void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome} e eu tenho {Idade} anos!");
        }
    }
}