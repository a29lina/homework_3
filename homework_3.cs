


//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int reverseNumber = 0;
int number1 = number;

while (number1 > 0)
{
reverseNumber = reverseNumber*10 + number1%10;
number1 = number1/10;
}

if (number > 10000 && number < 99999 && number == reverseNumber) Console.WriteLine("Число является палиндромом");
else if (number > 10000 && number < 99999 && number != reverseNumber) Console.WriteLine("Число не является палиндромом");
else Console.WriteLine("Не пятизначное число");


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
Console.Write("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());


double result = (Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)));
Console.WriteLine($"Расстояние между точками = {Math.Round(result, 2)}");
*/


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
int a = 1;
Console.Write("Введите число: ");
int N = Convert.ToInt32 (Console.ReadLine());
int result = 0;

while (a <= N)
{
   result = Convert.ToInt32(Math.Pow(a, 3));
   Console.WriteLine($"{a}^3 = {result}");
   a++;
}
*/