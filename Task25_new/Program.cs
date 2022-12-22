// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!

Console.WriteLine("Ender number A:");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Ender number B:");
int b=int.Parse(Console.ReadLine());
int num=1;
for (int i=1; i<=b; i++)
{
num=num*a;
}
Console.WriteLine("A raised to B power = "+num);