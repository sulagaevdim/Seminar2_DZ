// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

System.Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(System.Console.ReadLine());
int res = 0;
res += (n % 10);
while (n > 10)
{
    n /= 10;
    res = (res * 10) + (n % 10);
}  
System.Console.Write(res % 10);
while (res > 10)
{
    res /= 10;
    System.Console.Write(", " + res % 10);
}  