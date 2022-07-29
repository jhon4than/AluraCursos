// See https://aka.ms/new-console-template for more information

using CursoDesignPatterns;
using CursoDesignPatterns.Desconto;
using CursoDesignPatterns.Desconto.Desconto;

//Orcamento reforma = new Orcamento(500.0);

//Imposto novoImposto = new ICCC();
//Console.WriteLine(novoImposto.Calcula(reforma));
////------------------------------------------------------------------------------------//

//Conta conta = new Conta();
//RealizadorDeInvestimentos realizaInvestimento = new RealizadorDeInvestimentos();
//Arrojado arrojado = new Arrojado();

//conta.Deposita(250000);
//arrojado.Calcula(conta);

//realizaInvestimento.Realiza(conta, arrojado);

CalculadorDeDescontos calculator = new CalculadorDeDescontos();

Orcamento orcamento = new Orcamento(500);
orcamento.AdicionaItem(new Item("CANETA", 250));
orcamento.AdicionaItem(new Item("LAPIS", 250));

double desconto = calculator.Calcula(orcamento);
Console.WriteLine(desconto);