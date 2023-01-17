// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
{
    int[] resArray = new int[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < resArray.Length; i++)
        resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);

    return resArray;
}

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

int SumOddElemArray(int[] array)//Метод для подсчета суммы нечетных элементов массива
{
    int result = 0;

    for (int i = 1; i < array.Length; i++)
        if (i % 2 == 1) result = result + array[i];

    return result;
}

int arraySize = 5, arrayMinValue = -10, arrayMaxValue = 99;//Входные параметры, размер массива, минимальное и максимальное значения

int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

int sumOddElem = SumOddElemArray(newArray);//Получаем сумму всех нечетных элементов массива

Console.WriteLine($"{strArray} -> {sumOddElem}");
