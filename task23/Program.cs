// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// Добавил обработку отрицательного числа, возможно можно и элегантнее, 
// но как-то в голову больше ничего не пришло, как вариант ниже.

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int count = 1, cnt;
double cubed = 0;

int userNumber = InsertDigit("Введите число:");//Просим пользователя ввести число

while (count <= Math.Abs(userNumber)) //Перебираем все числа от 1 до N, Если введено отрицательное число берем его по модулю
{
    cubed = Math.Pow(count, 3); //Вычисляем куб числа
    cnt = count;
    if (userNumber < 0) { cubed = -cubed; cnt = -count; } //Если число было отрицательное то при возведения в степень оно тоже будет отрицательным

    Console.WriteLine($"{cnt}  {cubed}");
    count++;
}
