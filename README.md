# 🏨 Sistema de Hospedagem - Projeto POO C#

## 🌿 Descrição
Este projeto é um **sistema de reservas de hotel** desenvolvido em C# usando conceitos de **POO (Programação Orientada a Objetos)**.  
O sistema permite cadastrar hóspedes, suítes e reservas, calcular valores de diárias e aplicar **descontos automáticos** para estadias longas.

---

## 🌱 Estrutura do Projeto

### **Classe Pessoa**
- Representa um hóspede do hotel  
- **Atributos principais:**  
  - `Nome`  
  - `Sobrenome`  

### **Classe Suíte**
- Representa uma suíte disponível para reserva  
- **Atributos principais:**  
  - `Tipo` (Ex: Premium, Master, Basic)  
  - `Capacidade` (número máximo de hóspedes)  
  - `ValorDiaria` (valor por dia)

### **Classe Reserva**
- Relaciona **hóspedes** e **suíte**  
- **Atributos e métodos principais:**  
  - `Hospedes` → lista de pessoas na reserva  
  - `Suite` → suíte escolhida  
  - `DiasReservados` → quantidade de dias da estadia  
  - `ObterQuantidadeHospedes()` → retorna número de hóspedes  
  - `ValorDiaria()` → calcula valor total da reserva  
  - Aplica **desconto de 10%** automaticamente se os dias reservados > 10

---

## 🎯 Objetivos do Projeto
1. Aplicar conceitos de **POO**: classes, atributos, métodos e relacionamentos  
2. Criar um **sistema funcional de reservas** com cálculo de diárias  
3. Implementar **descontos** de acordo com a quantidade de dias  
4. Construir um projeto completo para o portfólio no GitHub

---

## 💻 Exemplo de Uso

```csharp
// Instanciando hóspedes
var p1 = new Pessoa("Sabrina", "Paschini");
var p2 = new Pessoa("Igor", "Correia");
var p3 = new Pessoa("Joao", "Alves");

// Instanciando suítes
var suite1 = new Suite("Premmium", 2, 1500);
var suite2 = new Suite("Master", 4, 3500);

// Criando listas de hóspedes
List<Pessoa> hospedes1 = new List<Pessoa> { p1, p2 };
List<Pessoa> hospedes2 = new List<Pessoa> { p3 };

// Criando reservas
var reserva1 = new Reserva(hospedes1, suite1, 11); // 11 dias → desconto aplicado
var reserva2 = new Reserva(hospedes2, suite2, 8);  // 8 dias → sem desconto

// Exibindo resultados
Console.WriteLine($"Reserva 1 - Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Reserva 1 - Valor total: {reserva1.ValorDiaria()}");

Console.WriteLine($"Reserva 2 - Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
Console.WriteLine($"Reserva 2 - Valor total: {reserva2.ValorDiaria()}");

// Saída esperada

Reserva 1 - Hóspedes: 2
Reserva 1 - Valor total: 14850  // 11 dias x 1500 com 10% de desconto
Reserva 2 - Hóspedes: 1
Reserva 2 - Valor total: 28000  // 8 dias x 3500 sem desconto
