// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("введите первое число");
String number = Console.ReadLine() ?? "";
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(number);
String number1 = Console.ReadLine() ?? "";
int c = Convert.ToInt32(number1);

int max = 0;
int min = 0;

if(b > c)
{
    max = b;
    min = c;
}
else
{
    max = c;
    min = b;
}


Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);