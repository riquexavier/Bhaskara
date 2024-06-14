double a,b,c,x1,x2, delta;
Console.Clear();

Console.WriteLine("Bem-Vindo ao programa Bhaskara\n");
Console.WriteLine("Aperte qualquer tecla para iniciar o programa (: ");
Console.ReadKey(true);

Console.Write("Digite o valor de a: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de b: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de c:");
c = Convert.ToDouble(Console.ReadLine());
delta = b * b -4*a*c;
x1= -b + delta / 2 * a;
x2= -b - delta / 2 * a;

if (a == 0)
{
Console.WriteLine("A equação não é do segundo grau.");
}
else
{
    if (delta < 0)
    {
Console.WriteLine($"Como delta é igual a {delta}, a equação não possui raízes reais.\n");
    }

    if (delta > 0)
    {
Console.WriteLine($"\nDelta é igual a {delta}.\n");
Console.WriteLine($"Portanto x1 = {x1} e x2 = {x2}.");        
    }
}