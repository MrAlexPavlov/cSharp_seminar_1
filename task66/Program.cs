// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int InsertInteger(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertInteger(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

//Метод для подсчета всех целых чисел в промежутке от M до Н
(string text, int sum) SumIntegerNumbers(int n, int m, int s)
{
    (string text, int sum) result = (text: String.Empty, sum: 0);
    if (n == m)
    {
        result.text += $"{n} ";
        result.sum += n;
        return result;
    }
    result = SumIntegerNumbers(n - s, m, s);
    result.text = result.text + $"+ {n} ";
    result.sum = result.sum + n;
    return result;
}

int mUser = InsertInteger("Введите число M:");
int nUser = InsertInteger("Введите число N:");

int sign = Math.Sign(nUser - mUser);
Console.WriteLine($"sign = {sign}");
//В задании сказано что надо найти сумму всех натуральных элементов,
//если пользователь ввел отрицательное значение то считаем от 0
int nTmp = nUser < 0 ? 0 : nUser;
int mTmp = mUser < 0 ? 0 : mUser;
var naturalSum = SumIntegerNumbers(nTmp, mTmp, sign);

// Выводим на экран
Console.Clear();
string answer = $"\nCумма натуральных чисел \n";
answer += $"M = {mUser}; N = {nUser}";

Console.WriteLine($"{answer} -> {naturalSum.sum}\n\n{naturalSum.text} = {naturalSum.sum}");


