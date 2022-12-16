// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int a,cnt = 2;
string text = "";

Console.WriteLine("Программа для вывода четных чисел от 1 до N\n");

Console.WriteLine("Введите число N:");
a = Convert.ToInt32(Console.ReadLine()); // Без проверки на ввод текста.

while (cnt<=a) {
    text +=$"{cnt} ";
    cnt +=2;
}

Console.WriteLine($"{a} -> {text}");  