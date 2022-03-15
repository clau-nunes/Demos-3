using static System.Console;

 Pessoa p1 = new Pessoa();

p1.Nome = "Cláudia";
p1.Idade = 24;

p1.EnderecoPessoa = new Endereco()
 {
     Logradouro = "Rua teste",
     Numero = 300,
     CEP = "000000",
     Cidade = "Paraiba",

 }; 

 WriteLine("Fim");
 