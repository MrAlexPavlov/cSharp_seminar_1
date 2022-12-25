// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber = InsertDigit("Введите число:");

int count = 1,cnt;
while (count<=Math.Abs(userNumber))
{
    cnt = count;
    if (userNumber<0) cnt = -count;
    Console.WriteLine($"{cnt,2}  {count*count,3}");
    count++;
}