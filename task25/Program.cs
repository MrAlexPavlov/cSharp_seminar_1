// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result;
    Console.WriteLine(text);
    Int32.TryParse(Console.ReadLine(), out result);
    return result;
}

double powerDigit(int a, int b) //возводим число {a} в степень {b}, проверку на корректность переданных параметров будет перед вызовом метода
{
    double answer = 1;
    for (int i = 0; i < Math.Abs(b); i++) answer *= a;
    return b < 0 ? 1 / answer : answer;
}


//Просим пользователя ввести целое число и степень в которую надо возвести
int pow, userNumber;
userNumber = InsertDigit("Введите целое число:"); 
pow = InsertDigit("Введите степень числа");

//Производим проверку корректности полученных чисел перед вызовом метода возведения в степень
if (userNumber == 0 && pow <= 0) // ноль в нулевой и в отрицательной степени - считают неопределённым
{
    Console.WriteLine($"число {userNumber} в степени {pow} -> не определен");
}
else if (userNumber == 0) //ноль в любой положительной степени ноль
{
    Console.WriteLine($"число {userNumber} в степени {pow} -> 0");
}
else // в остальных случаях можно число возвести в степень
{
    double result = powerDigit(userNumber, pow);
    Console.WriteLine($"число {userNumber} в степени {pow} -> {result}");
}
