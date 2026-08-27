namespace calculadora
{
    public class Program 
    {
       public static void Main()
        {
            Console.WriteLine("-------CALCULADORA INICIAL---------");

           Console.WriteLine("Digite o primeiro número: ");
           int num1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Digite o segundo número: ");
           int num2 = Convert.ToInt32(Console.ReadLine());


            int soma = num1 + num2;
            int sub = num1 - num2;
            int mult = num1 * num2;
            int div = num1 / num2;
            int mod = num1 % num2;

            Console.WriteLine("O valor da soma é: " + soma);
            Console.WriteLine("O valor da subtração é: " + sub);
            Console.WriteLine("O valor da multiplicação é: " + mult);
            Console.WriteLine("O valor da divisão é: " + div);
            Console.WriteLine("O valor do módulo é: " + mod);



        }
        


    }
}
