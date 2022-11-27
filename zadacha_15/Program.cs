// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите порядковый номер дня недели: "); //вводим цифру
int numberDay = int.Parse(Console.ReadLine());

string[] weekDays = new string[8];                      //задаем массив

weekDays[1] = "Нет";                                    //обозначаем выходные/рабочие дни
weekDays[2] = "Нет";
weekDays[3] = "Нет";
weekDays[4] = "Нет";
weekDays[5] = "Нет";
weekDays[6] = "Да";
weekDays[7] = "Да";

Console.WriteLine($"{numberDay} -> {weekDays[numberDay]}");