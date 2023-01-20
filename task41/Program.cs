// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string ArrayIntToString(int[] array)//Метод преобразования массива в строку
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $" {array[i]}";
        result = i < (array.Length - 1) ? result = result + "," : result;//для корректности вывода запятых
    }
    return result;
}

int[] UserEnteredNumbers(string text, char delim)//Метод пользовательского ввода нескольких чисел через разделитель delim
{
    bool tryParseToInt;
    int j = 0, intTmp = 0;
    //Очищаем консоль и ожидаем пользовательского ввода
    Console.Clear();
    Console.WriteLine(text);
    string usersText = Console.ReadLine()?? string.Empty;

    //преобразуем строку в строковый массив и переводим его в числовой массив
    string[] tmpStrArray = usersText.Split(delim);
    int[] tmpArray = new int[tmpStrArray.Length];
    for (int i = 0; i < tmpStrArray.Length; i++)
    {
        tryParseToInt = Int32.TryParse(tmpStrArray[i], out intTmp);
        //Берем только числовые значения
        if (tryParseToInt)
        {
            tmpArray[j] = intTmp;
            j++;
        }
    }
    //Если размер нового числого массива будет больше чем количество вписанных туда элементов 
    //Например: не все, что ввел пользователь было числами, задвоение разделеителей и т.п.
    //то удаляем не нужное через создание другого массива
    int[] resArray = new int[j];
    if (tmpArray.Length > j)
    {
        for (int i = 0; i < resArray.Length; i++)
            resArray[i] = tmpArray[i];
    }
    else resArray = tmpArray;

    return resArray;
}

int CounterPositiveIntegers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        result = array[i] > 0 ? result + 1 : result;
    return result;
}

//Запрашиваем у пользователя ввод данных
int[] usersNumbers = UserEnteredNumbers("Введите целые числа через запятую", ',');

//Производим подсчет количество положительных чисел
int cntPos = CounterPositiveIntegers(usersNumbers);

//выводим на экран массив и результат работы счетчика
string usersNumbersStr = ArrayIntToString(usersNumbers);
Console.WriteLine($"{usersNumbersStr}-> {cntPos}");