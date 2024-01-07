// Задача 1: Напишите программу, 
// принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// Console.WriteLine ("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.Write($"Число {number} кратно 7 и 23");
// }
// else
// {
//     Console.Write($"Число {number} не подходит");
// }

// Задача 2: Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.WriteLine ("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
if ( X > 0 && Y > 0 )
{
    Console.Write($"Координаты X и Y в 1-ой четверти");
}
if ( X < 0 && Y > 0 )
{
    Console.Write($"Координаты X и Y в 2-ой четверти");
}
if ( X < 0 && Y < 0 )
{
    Console.Write($"Координаты X и Y в 3-ой четверти");
}
if ( X > 0 && Y < 0 )
{
    Console.Write($"Координаты X и Y в 4-ой четверти");
}



