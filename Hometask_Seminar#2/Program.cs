Console.WriteLine("Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.");
// 456 => 5
// 782 => 8
// 918 => 1

Console.Write("Input 3figured number: ");
int num = Convert.ToInt32(Console.ReadLine());
//int result1 = num / 10;
//int result2 = num % 10;
if (num > 99 && num < 1000)
{   
    int rslt = num /10;
    Console.WriteLine(rslt % 10);
}
else 
{
    Console.WriteLine("Wrong number!Try again");
}

Console.WriteLine("Задача 13.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
//645 => 5
//78 => третьей цифры нет
//32679 => 6

Console.Write("Input your number: ");
int numb = Convert.ToInt32(Console.ReadLine());
int result = -1;

if (numb >= 100)
{
    while (numb > 999)
    {
        numb /= 10;
    }
    result = numb % 10;
    Console.WriteLine(result);
}
 else 
 {  
    Console.WriteLine(result+ "  3rd figure is missed!" );
 }

Console.WriteLine("Задача 15. Напишите программу, которая на вход принимает цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
// 6 => Да
// 7 => Да
// 1 => Нет

Console.Write("Input your figure: ");
int figure = Convert.ToInt32(Console.ReadLine());
//int dayoff;

if (figure == 6 || figure == 7)
{
   Console.Write("Day off!");
}
else if (figure >= 1 && figure <=5)  
 {   
    Console.Write("Working day");
 }
else 
{
    Console.WriteLine("Wrong figure! Try again");
}


