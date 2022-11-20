//Leer tres números y escribir el mayor de los tres

internal class Program
{
    private static void Main(string[] args)
    {
        int num1; int num2; int num3;

        Console.WriteLine("Digite el primer número");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite el segundo número");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite el tercer número");
        num3 = int.Parse(Console.ReadLine());

        if(num1 > num2 && num1 > num3)
        {
            Console.WriteLine("El mayor es: "+num1);
        }
        if(num2 > num1 && num2 > num3)
        {
            Console.WriteLine("El mayor es: "+num2);
        }

        if(num3 > num1 && num3 > num2)
        {
            Console.WriteLine("El mayor es: "+num3);
        }
    }
}