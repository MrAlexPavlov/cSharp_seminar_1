// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


string ArrayToString(int[] array)//Метод преобразования массива в строку
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $" {array[i]}";
        result = i < (array.Length - 1) ? result + "," : result;//для корректности вывода запятых
    }
    return result + " ]";
}

int[] FibonacheNumbers(int count)
{
    int[] resArray = new int[count - 1];
    resArray[1] = 1;
    for (int i = 2; i < resArray.Length; i++)
    {
        resArray[i] = resArray[i - 2] + resArray[i - 1];
    }
    return resArray;
}

int[] arrayFib = FibonacheNumbers(7);
string arrStr = ArrayToString(arrayFib);
Console.WriteLine(arrStr);