// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void RevertDigit(int a)
{
    int  b=0;
    Console.WriteLine(a+"\n");
    while (a>=1)
    {
        //Console.Write(a%10);
        b = b*10+(a%10);
        a = a / 10;
        Console.Write($"{b} => ");
    }
    Console.WriteLine($"{b}\n");
}

RevertDigit(50021);
