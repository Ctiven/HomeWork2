//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да



Console.WriteLine("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
int nPolindrome = n;
int rev = 0;
while(n > 0)
{
   int dig = n % 10;
    rev = rev * 10 + dig;
    n = n/10;
}
if(nPolindrome == rev)
{
    Console.WriteLine("Это палоиндром");
}
else
{
    Console.WriteLine("Это не палоиндром");
}