//Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

int a = 322;
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine ($"chislo {a} kratno 7 i 23");
}
else 
{
    Console.WriteLine ($"chislo {a} ne kratno 7 i 23");
}

