// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



int rnd = new Random().Next(100,1000);

int MakeDigit(int number)
{
    int result  = (number/100)*10 + number % 10;
    return result;
}

int newDigit = MakeDigit(rnd);
Console.WriteLine($"{rnd} -> {newDigit}");
