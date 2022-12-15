// Напишите программу, 
//которая на вход принимает число 
//и выдает его квадрат (число умнодженное на само себя)
// 4 ---> 16
// -3 --> 9
// -7 --> 49

// if ( Console.ReadLine() is string) {
//     Console.WriteLine("Yes");
// }
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
//int number = int.Parse(Console.ReadLine());
int square = number * number;
//Console.WriteLine("Квадрат числа " + number + " = " + square);

Console.WriteLine($"Квадрат числа {number} = {square}");