//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

        
if (n == 1)
    Console.Write($"No");
 if (n == 2)
    Console.Write($"No");       
if (n == 4)
    Console.Write($"No");
if (n == 5)
    Console.Write($"No");
if (n == 6)
    Console.Write($"Yes"); 
if (n == 7)
    Console.Write($"Yes");
if (n > 7)
    Console.Write($"Введите число от 1 до 7.");
if (n < 1)
    Console.Write($"Введите число от 1 до 7."); 


    

    