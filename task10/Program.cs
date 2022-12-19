// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int ThirdDigit(int digit)
{
    int res;

    if (digit > 99)
    {
        while (digit > 999)
        {
            digit = digit / 10;
        }
        res = digit % 10;
    }
    else
    {
        res = -1;
    }
    return res;
}

Console.WriteLine("Введите трех значаное число");
int usNumber = Convert.ToInt32(Console.ReadLine());
int dig3 = ThirdDigit(usNumber);

if (dig3 >= 0)
{
    Console.WriteLine($"{usNumber} -> {dig3}");
}
else
{
    Console.WriteLine($"{usNumber} -> Третей цифры нет");
}
*/


int SecondDigit(int digit)//Метод для получения 2 цифры
{
    digit = digit / 10;
    return digit % 10;
}

int InsertDigit() //Метод ввода пользовательских данных
{
    Console.WriteLine("Введите трех значаное число");
    return Convert.ToInt32(Console.ReadLine());
}


//Просим пользователья ввести трех значное число, будем просить пока не введет правильно.
int usNumber = 0;
while (usNumber<100 || usNumber>999) 
{
    usNumber = InsertDigit(); // вызов метода для ввода числа от пользователя
    if (usNumber<100 || usNumber>999)
    {
        Console.WriteLine($"{usNumber} - не трехзначное число\n");
    }
}

// Вызываем метод для определения второй цифры числа
int dig2 = SecondDigit(usNumber);

// Выводим пользователю значение второй цифры
Console.WriteLine($"{usNumber} -> {dig2}");
