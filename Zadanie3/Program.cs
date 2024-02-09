// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.Write("Введите двузначное число: ");
int n = Convert.ToInt32(System.Console.ReadLine());

if (n > 10 && n < 100){
    int first = n / 10;
    int second = n % 10;
    if (first > second) {
        System.Console.WriteLine($"Наибольшая цифра введенного числа - {first}");
    } else if (first < second) {
        System.Console.WriteLine($"Наибольшая цифра введенного числа - {second}");
    } else {
        System.Console.WriteLine("цифры введенного числа равны");
    }

} else {
    System.Console.WriteLine("число не двузначное");
}