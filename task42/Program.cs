// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result;bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse || result <= 0) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

double DecimalToBinary(int a)//Метод преобразования десятичного натурального числа в двоичное циклом While
{
    double res = 0;
    int countPower = 0;
    while (a > 0)
    {
        res = res + a % 2 * Math.Pow(10, countPower);//Каждая последующая цифра должна попадать в следующий регистр от предидущего
        a /= 2;
        countPower++;
    }
    return res;
}

int DecimalToBinaryRecursive(int a)//Рекурсивный метод преобразования десятичного натурального числа в двоичное
{
    int res = 0;
    if (a == 0) return res;
    res = DecimalToBinaryRecursive(a / 2);
    res = res * 10 + a % 2;
    return res;
}

int DecimalToBinaryString(int a)//Метод преобразования десятичного натурального числа в двоичное, используя строку
{
    string res="";
    while (a > 0)
    {
        res = a%2 + res;
        a /=2;
    }
    return Convert.ToInt32(res);
}

int usNumber = InsertDigit("Введите натуральное число:");//Просим пользователя ввести натуральное число

double res = DecimalToBinary(usNumber); //1 метод преобразованя из 10 в 2. Цикл while
int resRecursive = DecimalToBinaryRecursive(usNumber);//2 метод преобразованя из 10 в 2. Рекурсия
int resStringToInt = DecimalToBinaryString(usNumber);//3 метод преобразования из 10 в 2. Строка

Console.WriteLine($"{res} = {resRecursive} = {resStringToInt}");