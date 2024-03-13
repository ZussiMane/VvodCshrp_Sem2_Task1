﻿// Напишите программу, которая принимает на 
// вход трёхзначное число и удаляет вторую 
// цифру этого числа.
// Примеры
// a = 256 => 26 
// a = 891 => 81

Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine()); // Преобразуем строку "strinng" в целочисленное число "int"

int firstDigit = a / 100; // 256 / 100 = 2.56 => 2(этим дейсвием мы отсекли от трёхзначного числа 2 последние цифры(56))
int thirdDigit = a % 10; // 256 % 10 = 260 + 6 => 6(этим действием мы отсекли от трёхзначного числа первые 2 цифры(25))
int result = firstDigit * 10 + thirdDigit; // на примере: 2 * 10 = 20 + 6 => 26

Console.Write(" => " + result);
