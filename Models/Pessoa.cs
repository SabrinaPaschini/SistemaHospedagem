using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem.Models
{
    public class Pessoa
    {
    // classe Pessoa  

         public string Nome {get;set;}
         public string Sobrenome {get;set;}

    // constructor 
         public Pessoa(string nome, string sobrenome)
         {
             Nome = nome; // aqui eu coloco que os parametros do constructor sao o nome da classe = o nome do parametro 
             Sobrenome = sobrenome; 
         }

         

    }
}