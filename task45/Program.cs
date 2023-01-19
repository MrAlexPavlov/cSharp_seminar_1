// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] CreatIntArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
{
    int[] resArray = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
    }
    return resArray;
}

int[] CopyArray(int[] arr)
{
    int[] resArray = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++)
        resArray[i] = arr[i];
    
    return resArray;
}

int arrSize = 6,
    arrMinValue = 0,
    arrMaxValue = 10;

int[] newArray = CreatIntArray(arrSize, arrMinValue, arrMaxValue);
int[] fullCopyArray = CopyArray(newArray);

string strSourceArray = ArrayToString(newArray);
string copyArray = ArrayToString(fullCopyArray);

Console.WriteLine($"{strSourceArray}\n{copyArray}");