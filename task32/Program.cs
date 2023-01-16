// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
{
    int[] resArray = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
    }
    return resArray;
}


string ArrayToString(int[] array)//Метод преобразования массива в строку
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $" {array[i]}";
        result = i < (array.Length - 1) ? result = result + "," : result;//для корректности вывода запятых
    }
    return result + " ]";
}

void InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
        array[i]  = -array[i];
}


int arraySize = 4, arrayMinValue = -10, arrayMaxValue = 10;

int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

Console.WriteLine(strArray);
InverseArray(newArray);
strArray = ArrayToString(newArray);
Console.WriteLine(strArray);

