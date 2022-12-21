// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

bool DivCheck(int number1, int number2)
{
    return number1/number2 == number2 || number2/number1 == number1;
}

if ( DivCheck(userNumber,userNumber2) ) 
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> да");
} else 
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> нет");
}

