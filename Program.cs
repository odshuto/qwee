// Домашнее задание №2
Console.WriteLine("№2");
Console.WriteLine("Введи число");
int number =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int number1 =Convert.ToInt32(Console.ReadLine());
if(number > number1)
{
    Console.WriteLine($"max = {number}");
}
else
    Console.WriteLine($"max = {number1}");

// №4
int max = 0; 
Console.WriteLine("№4");
Console.WriteLine("Введи число");
int number2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int number3 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число");
int number4 =Convert.ToInt32(Console.ReadLine());
if(number2 > number3)
    max = number2;
else
    max = number3;
if(max > number4)
    Console.Write($"max = {max}");
else
    Console.WriteLine($"max = {number2}");


// №6
Console.WriteLine("№6");
Console.WriteLine("Введи число");
int number5 =Convert.ToInt32(Console.ReadLine());
if(number5 % 2 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");


// №8 
int i = 2;
Console.WriteLine("№8");
Console.WriteLine("Введи число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа : ");
do
{
Console.WriteLine(i);
i = i + 2;
}
while(i < n);


