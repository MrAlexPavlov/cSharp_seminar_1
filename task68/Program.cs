// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InsertNaturalDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse || result < 0) result = InsertNaturalDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

int AccermanMethod1(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AccermanMethod1(m - 1, 1);
    return AccermanMethod1(m - 1, AccermanMethod1(m, n - 1));
}

int AccermanMethod2(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = AccermanMethod2(m, n - 1);
        m = m - 1;
    }
    return n + 1;
}

int mUser = InsertNaturalDigit("Введите натуральное число m:");
int nUser = InsertNaturalDigit("Введите натуральное число n:");

int answer = AccermanMethod2(mUser, nUser);
Console.WriteLine($"m = {mUser}, n = {nUser} -> A(m,n) = {answer}");