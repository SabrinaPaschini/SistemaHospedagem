using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem.Models

{
    public class Suite
    {
        public string TipoDaSuite {get; set;}
        public int Capacidade {get; set;}
        public decimal Preco {get; set;}

       // constructor 

    public Suite (string tipoDaSuite, int capacidade, decimal preco)
        {
            TipoDaSuite = tipoDaSuite; 
            Capacidade = capacidade; 
            Preco = preco; 
        }


    }

    
}