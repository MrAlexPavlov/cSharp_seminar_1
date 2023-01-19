// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] CreatIntArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
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

void ReversArray(int[] array)// Метод разворота массива через верменную переменную
{
    int tmp;
    for (int i = 0; i < array.Length/2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length-i-1];
        array[array.Length-i-1] = tmp;
    }
}

//Входные параметры, размер массива, минимальное и максимальное значения
int arraySize = 5, 
    arrayMinValue = 0, 
    arrayMaxValue = 10;

int[] newArray = CreatIntArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим массив в строку для дальнейшего вывода на экран

ReversArray(newArray);//разворачиваем массив
string strArrayReverse = ArrayToString(newArray);// переводим массив в строку для дальнейшего вывода на экран

Console.WriteLine($"{strArray}\n{strArrayReverse}");