//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int X = 4;
int Y = -2;
if (X > 0 && Y > 0)
{
    Console.WriteLine ("1 chetvert");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine ("2 chetvert");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine ("3 chetvert");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine ("4 chetvert");
}