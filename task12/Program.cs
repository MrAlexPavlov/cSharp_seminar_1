// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите второе число:");
int userNumber2 = Convert.ToInt32 (Console.ReadLine());
/*
string DivCheck (int number1, int number2)
{
    if ( us1 % us2 == 0 ) 
    {
        return $"{number1}, {number2} -> кратно" ;
    } else {
        return $"{number1}, {number2} -> не кратно, остаток "+(number1 % number2);
    }
}
*/
bool DivCheck (int number1, int number2)
{
    if ( number1 % number2 == 0 ) 
    {
        return true ;
    } else {
        return false;
    }
}

if ( DivCheck(userNumber,userNumber2) ) 
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> кратно");
} else 
{
Console.WriteLine($"{userNumber}, {userNumber2} -> не кратно, остаток "+(userNumber % userNumber2));
}

