// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

int a = 17;
int thirstDigit = a / 10;
int secondDigit = a % 10;
if (thirstDigit > secondDigit)
{
    Console.WriteLine ($"Naibolshaya cifra {thirstDigit}");
}
else
{
    Console.WriteLine ($"Naibolshaya cifra {secondDigit}");
}