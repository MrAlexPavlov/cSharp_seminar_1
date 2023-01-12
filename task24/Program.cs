// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumDigit(int insertNum) //Метод перебора от 1 до переданого числа
{
    int temp, result = 0; //переменная temp на тот случай если введено отрицательное число
    temp = Math.Abs(insertNum);
    for (int i = 1; i <= temp; i++) result = result + i;
    if (insertNum < 0) result = -result;
    return result;
}

int userNum = InsertDigit("Введите число");
int sumNum = SumDigit(userNum);

Console.WriteLine($"Сумма натуральных чисел от 1 до {userNum} это {sumNum}");