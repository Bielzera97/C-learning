// See https://aka.ms/new-console-template for more information

List<Pessoa> pessoas = new List<Pessoa>{
    new Pessoa("Gabriel", 27),
    new Pessoa("Gabriela", 27)
};

foreach (var pessoa in pessoas){
    Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos");
}

public class Pessoa {
    public string Nome {get; set;}
    public int Idade { get; set;}
    public Pessoa ( string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
};
