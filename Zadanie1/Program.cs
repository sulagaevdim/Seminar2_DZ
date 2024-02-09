// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(System.Console.ReadLine());

if (n % 23 == 0 && n % 7 == 0)
{
    System.Console.WriteLine("Число КРАТНО 23 и 7 одновременно");
} else {
    System.Console.WriteLine("Число НЕ кратно 23 и 7 одновременно");
}