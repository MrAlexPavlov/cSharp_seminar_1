// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] MakeArray(int[] array) // Метод для создания массива на основе переданного. Согласно Т.З.
{
    int size = array.Length % 2 != 0 ? array.Length / 2 + 1 : array.Length / 2; //определяем размер нового массива. Нюнасы с четным и не четным кол-вом элементов
    int[] resArray = new int[size];
    for (int i = 0; i < resArray.Length; i++)
    {
        if (i == resArray.Length - 1 && array.Length % 2 == 1)// на тот случай если кол-во элементов в исходном массиве не четное
        {
            resArray[i] = array[i];
        }
        else
        {
            resArray[i] = array[i] * array[array.Length - i - 1]; 
        }

    }
    return resArray;
}


int arraySize = 5, arrayMinValue = 0, arrayMaxValue = 10;

int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

int[] halfAndDouble = MakeArray(newArray); //Создаем новый массив на основании ранее сгенернируемого
string strHalfAndDouble = ArrayToString(halfAndDouble);

Console.WriteLine($"{strArray} -> {strHalfAndDouble}");

