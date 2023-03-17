//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string number = Console.ReadLine();

if (number.Length > 3)
    Console.Write($"нет третьей цифры");
if (number.Length < 1)
    Console.Write($"нет третьей цифры");

int n1 = n / 10;
int n2 = n % 10;
Console.Write(n2);




