// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InsertDigit(string text) //Метод ввода пользовательских числовых значений
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int ThirdDigit(int digit) //Метод для получения 3 цифры числа
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

//Пользовательский ввод числа
int usNumber = InsertDigit("Для получения 3 цифры введите число:");

//Вызова метода для получения 3 цифры 
int dig3 = ThirdDigit(usNumber); 

if (dig3 >= 0) //Метод должен вернуть цифру от 0 до 9
{
    Console.WriteLine($"{usNumber} -> {dig3}");
}
else //Если метод вернет отрицательное значение, значит пользовательское число меньше 100
{
    Console.WriteLine($"{usNumber} -> Третей цифры нет");
}

