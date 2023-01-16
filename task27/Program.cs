// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result;
    Console.WriteLine(text);
    if (!Int32.TryParse(Console.ReadLine(), out result)) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

int SumDigit(int uInt) //Метод для нахождения суммы цифр в числе uInt
{
    int result = 0;
    while (uInt != 0)
    {
        result = result + uInt % 10;//Получаем последнюю цифру в числе и суммируем с полученными ранее
        uInt = uInt / 10;//удаляем последний регистр числа
    }
    return result;
}

int userNumber = InsertDigit("Введите число:");
int sumDig = SumDigit(Math.Abs(userNumber));//cуммируем цифры пользовательского числа

Console.WriteLine($"{userNumber} -> {sumDig}");
