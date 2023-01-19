// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result;
    bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse || result <= 0) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

int ReverseInt(int a) //метод разворота натурального числа
{
    int res = 0;
    if (a == 1) return 10;
    while (a > 0)
    {
        res = res * 10 + a % 10;
        a = a / 10;
    }
    return res;
}

int DecimaltoBool(int a)//Метод преобразования десятичного натурального числа в двоичное
{
    int res = 0;
    while (a > 0)
    {
        res = res * 10 + a % 2;
        //res = res * 10 + a % 2;
        a /= 2;
    }
    //return res;
    return ReverseInt(res);
}

int usNumber = InsertDigit("Введите натуральное число:");

int res = DecimaltoBool(usNumber);

Console.WriteLine(res);
