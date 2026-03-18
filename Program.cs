using System.Reflection;
using Sistema_de_Hospedagem.Models;

// instanciando Pessoas 

var p1 = new Pessoa("Sabrina", "Paschini"); 
var p2 = new Pessoa("Igor", "Correia"); 
var p3 = new Pessoa ("Joao", "Alves");
var p4 = new Pessoa ("Maria", "Silva");
var p5 = new Pessoa ("Joana", "Dark");
var p6 = new Pessoa ("Capitão", "América"); 
var p7 = new Pessoa ("Lara", "Croft");
var p8 = new Pessoa ("Kratos", "God-Of_war");


// instanciar a suite nova 

var suite1 = new Suite ("Premmium", 2, 1500);
var suite2 = new Suite ("Master", 4, 3500); 
var suite3 = new Suite ("Basic", 1, 500);


List<Pessoa> hospedes = new List<Pessoa>(); // aqui é uma variavel hospedes que é do tipo lista de Pessoas, adiciona pessoas. 

hospedes.Add(p1); 
hospedes.Add(p2); 

List<Pessoa> hospedes2 = new List<Pessoa>(); // segunda lista de hospedes 

hospedes2.Add(p3);
hospedes2.Add(p4);
hospedes2.Add(p5);
hospedes2.Add(p6);

List<Pessoa> hospede3 = new List<Pessoa>(); 

hospede3.Add(p7);

// aqui é a instancia da reserva (hospedes = lista de pessoas, suíte = caracterisca e preço e dias reservados que é da propria classe reserva).

var reserva1 = new Reserva(hospedes,suite1,11);  
var reserva2 = new Reserva (hospedes2, suite2,11);  
var reserva3 = new Reserva (hospede3,suite3,10); 


reserva3.ObterQuantidadeHospedes (hospede3); 


Console.WriteLine(reserva1.ValorDiária() + " Valor total da diária");

