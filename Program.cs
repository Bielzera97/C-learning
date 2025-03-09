namespace AprendendoCsharp{
    class Program{

        static void Saudacao(){
            Console.WriteLine("Ola!");
        }
        static void Main(string[] args){
            
            while(true){
                    Saudacao();
                    Console.WriteLine("Me dê um numero");
                    string num1 = Console.ReadLine();
                    Console.WriteLine("Me dê outro numero");
                    string num2 = Console.ReadLine();
                    int number1, number2;
            if (int.TryParse(num1, out number1) && int.TryParse(num2, out number2))
            {
                int soma = number1 + number2;
                Console.WriteLine("A soma dos numeros é: " + soma);
                break;
            }
            else
            {
                Console.WriteLine("Erro: Por favor, digite apenas números válidos!");
            }
            }
        }

    }

}