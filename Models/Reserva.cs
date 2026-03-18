using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem.Models

{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } // aqui que fica a lista da classe pessoa  

        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        // constructor recebe e atribui o paramentro pelo valor da classe. 
        // constructor com parametros

        public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
        }


        public void CadastroHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("Capacidade Máxima atingida." + Suite.Capacidade);
            }

            Hospedes = hospedes;

        }

        public void CadastroSuite(Suite suite)
        {
            if (suite == null)
            {
                throw new Exception("Sem suíte para cadastro");
            }

            Suite = suite;

        }

        public void ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
            {
                throw new Exception("Não existe suíte!");
            }

            if (hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("Ultrapassou a quantidade permitida.");
            }

            Console.WriteLine(hospedes.Count() + " Hospedes.");

        }

        public decimal ValorDiária()
        {

            if (Suite.Preco == 0)
            {
                throw new Exception("o preço não pode ser 0");
            }

            decimal valorDiaria = DiasReservados * Suite.Preco;

        

            if (DiasReservados > 10)
            {
                decimal desconto = valorDiaria * 10 / 100;

                valorDiaria = valorDiaria - desconto; 

                Console.WriteLine("Valor do desconto " + desconto + " Reais");
            }

            return valorDiaria; 

        }

        //Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.



    }

}