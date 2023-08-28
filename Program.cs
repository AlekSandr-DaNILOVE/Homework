Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.");

Console.Write("Input number a: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int numB = Convert.ToInt32(Console.ReadLine());


if (numA > numB)
{
    Console.WriteLine("Max number: " +numA);
    Console.WriteLine("Min number: " +numB);
}
else
{
    Console.WriteLine("Max number: " +numB);
    Console.WriteLine("Min number: " +numA);
}
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.");

Console.Write( "Input 1st number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3rd number: ");
int third = Convert.ToInt32(Console.ReadLine());

 if (first > second && first > third)
{
    Console.WriteLine("Max number: " +first);
}
 else if (first < second && second > third)
{
    Console.WriteLine("Max number : " +second);
}

else
{
    Console.WriteLine("Max number: " +third);
}

Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).");


Console.Write("Input your number: ");
int numb = Convert.ToInt32(Console.ReadLine());


if (numb % 2 == 0) 
{
   Console.Write("Number " +numb );
   Console.WriteLine(" is even");
}
else 
{
    Console.Write("Number " +numb);
    Console.WriteLine(" is Not even");
}

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int cnt = 0;

while(cnt < n -1)
{
    cnt += 2;
    Console.Write(cnt+ " " );
}