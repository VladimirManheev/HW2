﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.Write("Введите 3-х значное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = n / 10;
int n2 = n1 % 10;

Console.WriteLine(n2);
