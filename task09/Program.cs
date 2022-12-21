// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
/*
// Первый вариант без использовании методов
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99 => {number}");

if (number / 10 > number % 10)
{
    Console.WriteLine($"{number} => {number / 10}");
}
else if (number / 10 < number % 10)
{
    Console.WriteLine($"{number} => {number % 10}");
}
else
{
    Console.WriteLine($"{number} => Цифры равны");
}

int fDigit = number / 10;
int sDigit = number % 10;

//Console.WriteLine(fDigit > sDigit ? $"{number} => {number / 10}" : $"{number} => {number % 10}");

string result = fDigit > sDigit ? $"{number} => {number / 10}" : $"{number} => {number % 10}"; //тернарный оператор
Console.WriteLine(result);
//######################################################################################
*/
//Второй вариант с использованием методов
string MaxDigit(int number)
{
    int fDigit = number / 10;
    int sDigit = number % 10;
    string result = fDigit > sDigit ? $"{number} => {fDigit}" : $"{number} => {sDigit}"; //тернарный оператор
    return result;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99 => {number}");
Console.WriteLine(MaxDigit(number));



