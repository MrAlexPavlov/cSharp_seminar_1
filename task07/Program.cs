// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число:");
int usernumber = Convert.ToInt32 (Console.ReadLine());

if ( usernumber > 100 && usernumber < 1000 ){
    Console.WriteLine( $"Последняя цифра числа {usernumber} это: {usernumber%10}" );
} else {
    Console.WriteLine( "Вы ввели не трех значное число!" );
}
