// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа сравнения двух чисел\n");

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
    Console.WriteLine($"\nЧисло {a} больше {b}");
    Console.WriteLine($"a = {a} b = {b} -> max = {a}");
}
else if(a < b){
    Console.WriteLine($"\nЧисло {a} меньше {b}");
    Console.WriteLine($"a = {a} b = {b} -> max = {b}");
} else {     //Eсли оба числа равны то не определить какое из них больше. 
            //Добавлена обработка этого события, для корректности работы программы, хотя в задании этого небыло.
    Console.WriteLine($"\nЧисла {a} и {b} равны");
    Console.WriteLine($"a = {a} b = {b} -> {a} = {b}");
}
    
