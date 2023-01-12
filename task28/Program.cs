// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int ProdDigit(int insertNum) //Метод перебора от 1 до переданого числа
{
    int result = 1;
    for (int i = 1; i <= insertNum; i++) result = result * i; //получаем факториал числа
    return result;
}

int userNum = InsertDigit("Введите число");
if (userNum > 0)
{
    int prodNum = ProdDigit(userNum);
    Console.WriteLine($"Факториал числа {userNum}! = {prodNum}");
}
else
{
    Console.WriteLine($"Факториал отрицательного числа не определен");
}


