//
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int max = 0;

Console.WriteLine("Enter Number One: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number Two: ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());

if(NumberOne > NumberTwo)
{
    max = NumberOne;
}
else
{
    max = NumberTwo;
}
Console.WriteLine("max = " + max);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int maximum = 0;

Console.WriteLine("Enter Number One: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number Two: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number Three: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

if(Number1 > maximum)
{
    maximum = Number1;
}
if (Number2 > maximum)
{
    maximum = Number2;
}
if (Number3 > maximum)
{
    maximum = Number3;
}
Console.WriteLine("max = " + maximum);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter Number");

int NumberAny = Convert.ToInt32(Console.ReadLine());
if (NumberAny%2 == 0)
{
    Console.WriteLine("четное число");
}
else
{
    Console.WriteLine("нечетное число");
}

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//int Number = 5;

Console.WriteLine("Enter Number");

int NumberN = Convert.ToInt32(Console.ReadLine());

int NumberFst = 1;

while (NumberFst<=NumberN)
{
    if (NumberFst%2 == 0)
    {
    Console.WriteLine(NumberFst + "");
    }
NumberFst = NumberFst + 1;
    
}