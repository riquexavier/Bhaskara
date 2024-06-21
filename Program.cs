double a, b, c, x1, x2, delta;
Console.Clear();

Console.WriteLine("Bem-vindo ao programa Bhaskara\n");
Console.WriteLine("Aperte qualquer tecla para iniciar o programa (: \n");
Console.ReadKey(true);

Console.WriteLine("Abaixo encontra-se a fórmula de Bhaskara\n");

Console.WriteLine("                                _______________");
Console.WriteLine("                               /");
Console.WriteLine("                      - b  ±  √ b² - 4 * a * c");
Console.WriteLine("              x  =  ---------------------------");
Console.WriteLine("                              2 * a\n");

Console.Write("Digite o valor de a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"a={a} b=x c=x\n");

if (a == 0)
{
    Console.WriteLine("'a' não pode ser zero ou a equação não é do segundo grau.");
}

Console.Write("Agora o valor de b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"a={a} b={b} c=x\n");

Console.Write("Digite o valor de c: ");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"a={a} b={b} c={c}\n");

Thread.Sleep(1000);

Console.WriteLine("Primeiro calcularemos o delta que se encontra na raiz");

Console.WriteLine($"                                ___________________");
Console.WriteLine($"                               /");
Console.WriteLine($"                    - {b}  ±  √ {b}² - 4 * {a} * {c}");
Console.WriteLine($"              x  =  --------------------------------");
Console.WriteLine($"                              2 * {a}\n");

Thread.Sleep(1000);

delta = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(delta)) / (2 * a);
x2 = (-b - Math.Sqrt(delta)) / (2 * a);

if (delta < 0)
{
    Console.WriteLine($"Como delta {delta} é menor que zero, a equação não possui raízes reais.\n");
}

if (delta > 0)
{
    Console.WriteLine($"\nDelta é igual a {delta}.\n");
    Thread.Sleep(1000);
    Console.WriteLine($"Portanto x1 = {x1:N2} e x2 = {x2:N2}.\n");
}
