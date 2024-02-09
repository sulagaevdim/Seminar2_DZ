// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер координатной четверти плоскости, в которой находится эта точка.

System.Console.Write("Введите Х: ");
int x = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите Y: ");
int y = Convert.ToInt32(System.Console.ReadLine());

if (x == 0 || y == 0){
    System.Console.WriteLine("Точка расположена на оси кординат");
}else {
    if (x > 0)
    {
       if (y > 0)
       {
           System.Console.WriteLine("Точка в 1 четверти");
       } else {
           System.Console.WriteLine("Точка в 4 четверти");
       }
    } else {
       if (y > 0)
       {
           System.Console.WriteLine("Точка в 2 четверти");
       } else {
           System.Console.WriteLine("Точка в 3 четверти");
      }
    }
}