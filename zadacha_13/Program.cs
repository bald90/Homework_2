// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите трехзначиное число ");   //просим ввести число
int numberIn = int.Parse(Console.ReadLine());       //запоминаем введенное число

if (numberIn < 100) Console.WriteLine("-> третьей цифры нет");             //выводим результат
else 
{
while (numberIn > 999)
{
    numberIn = numberIn / 10;

}
int thirdDigit = numberIn % 10;             //определяем 3 цифру числа
Console.WriteLine($"-> {thirdDigit}");
}
