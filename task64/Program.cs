// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int InsertNaturalDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse || result < 0) result = InsertNaturalDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

void IntegerNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    IntegerNumbers(n - 1);
}


int userNumber = InsertNaturalDigit("Введите натуральное число >0:");
Console.Write($"{userNumber} -> ");
IntegerNumbers(userNumber);
