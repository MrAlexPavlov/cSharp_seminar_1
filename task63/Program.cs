// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

void IntegerNumbers(int n)
{
    if (n==0) return;
    IntegerNumbers(n-1);
    Console.Write($"{n} ");
    return;
}


int userNumber = InsertDigit("Ввеодите целое число:");
Console.Write($"{userNumber}-> ");
IntegerNumbers(userNumber);
