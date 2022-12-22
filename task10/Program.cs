﻿// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int digit)//Метод для получения 2 цифры трехзначного числа
{
    digit = digit / 10;
    return digit % 10;
}

int InsertDigit(string text) //Метод ввода пользовательских числовых значений
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


//Просим пользователья ввести трех значное число. Будем просить пока не введет правильно.
int usNumber = 0;
while (usNumber<100 || usNumber>999) 
{
    usNumber = InsertDigit("Введите трех значаное число"); // вызов метода для получения числа от пользователя
    if (usNumber<100 || usNumber>999)
    {
        Console.WriteLine($"{usNumber} - не трехзначное число\n");
    }
}

// Вызываем метод для определения второй цифры числа
int dig2 = SecondDigit(usNumber);

// Выводим пользователю значение второй цифры
Console.WriteLine($"{usNumber} -> {dig2}");