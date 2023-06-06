// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("A data atual é " + DateTime.Now);
/*
int i = 3;
Console.WriteLine(i);   // saída: 3
Console.WriteLine(i++); // saída: 3
Console.WriteLine(i);   // saída: 4

double a = 1.5;
Console.WriteLine(a);   // saída: 1.5
Console.WriteLine(++a); // saída: 2.5
Console.WriteLine(a);   // saída: 2.5

int negativo = 3;
Console.WriteLine(negativo);   // saída: 3
Console.WriteLine(negativo--); // saída: 3
Console.WriteLine(negativo);   // saída: 2

double a = 1.5;
Console.WriteLine(a);   // saída: 1.5
Console.WriteLine(--a); // saída: 0.5
Console.WriteLine(a);   // saída: 0.5

Console.WriteLine(+4);     // saída: 4
Console.WriteLine(-4);     // saída: -4
Console.WriteLine(-(-4));  // saída: 4

Console.WriteLine(13 / 5);    // saída: 2
Console.WriteLine(-13 / 5);   // saída: -2
Console.WriteLine(13 / -5);   // saída: -2
Console.WriteLine(-13 / -5);  // saída: 2

Console.WriteLine(13 / 5.0);       // saída: 2.6
int dobro = 13;
int b = 5;
Console.WriteLine((double)dobro / b);  // saída: 2.6

Console.WriteLine(5 % 4);   // saída: 1
Console.WriteLine(5 % -4);  // saída: 1
Console.WriteLine(-5 % 4);  // saída: -1
Console.WriteLine(-5 % -4); // saída: -1

Console.WriteLine(5 + 4);       // saída: 9
Console.WriteLine(5 + 4.3);     // saída: 9.3

Console.WriteLine(47 - 3);      // saída: 44
Console.WriteLine(5 - 4.3);     // saída: 0.7
*/
Console.WriteLine("Digite o valor de a");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de b");
int b = Int32.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de c");
int c = Int32.Parse(Console.ReadLine());

int delta = (b*b) - 4*a*c;
Console.WriteLine("delta é " + delta);
if (delta > 0 ) {
    double bhas1 = ((b * (-1)) + Math.Sqrt(delta)) / (2*a);
    Console.WriteLine("A primeira raiz é " + bhas1);
    double bhas2 = ((b * (-1)) - Math.Sqrt(delta)) / (2*a);
    Console.WriteLine("A segunda raiz é " + bhas2);
} else {
    Console.WriteLine("Nao existe raiz real");
}