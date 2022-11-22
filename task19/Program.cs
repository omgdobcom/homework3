// Задача №19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;

Console.Write("Является ли полиндоромом: ");

if (num1 == num5 && num2 == num4)
{
    Console.WriteLine($"{number} => да");
}
else
{
    Console.WriteLine($"{number} => нет");
}