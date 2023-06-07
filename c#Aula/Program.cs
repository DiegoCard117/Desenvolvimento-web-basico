// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int var1 = 10;
int var2 = 20;
int var3 = 30;

Console.WriteLine(var1);
Console.WriteLine(var2);
Console.WriteLine(var3);

Console.WriteLine(var1 + " é maior que " + var2 +"?");
Console.WriteLine(var1 > var2);

Console.WriteLine(var1 + " é maior que " + var3 +"?");
Console.WriteLine(var1 > var3);

Console.WriteLine(var3 + " é maior que " + var2 +"?");
Console.WriteLine(var3 > var2);

int total = var3 + var1;
Console.WriteLine(var3 + " + " + var1 +" = " + total);

Console.WriteLine(var1 + " é igual a " + var3 + " ? ");
Console.WriteLine(var1 == var3);

Console.WriteLine(total + " é igual a " + var1 + " + " + var2);
Console.WriteLine(total == var3);

int a = 5;
Console.WriteLine(++a);