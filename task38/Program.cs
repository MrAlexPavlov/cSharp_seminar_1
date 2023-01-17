// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//Метод генерации массива со случайными элементами вещественных чисел
double[] CreatArrayRndDouble(int arraySize, int arrayMinValue, int arrayMaxValue, int arrayDec)
{
    double[] resArray = new double[arraySize];
    Random rnd = new Random();
    double tmp;

    for (int i = 0; i < resArray.Length; i++)
    {
        tmp = rnd.NextDouble() * (arrayMaxValue - arrayMinValue) + arrayMinValue;
        resArray[i] = Math.Round(tmp, arrayDec, MidpointRounding.ToZero);
    }

    return resArray;
}

string ArrayDoubleToString(double[] array)//Метод преобразования массива в строку
{
    string result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + Math.Round(array[i], 3);
        result = i < (array.Length - 1) ? result + " | " : result;//для корректности вывода запятых
    }
    return result + " ]";
}

double ArrayDoubleMaxValue(double[] array)//Метод для нахождения максимального элемента массива
{
    double result = array[0];

    for (int i = 0; i < array.Length; i++)
        if (result < array[i]) result = array[i];

    return result;
}

double ArrayDoubleMinValue(double[] array)//Метод для нахождения минимального элемента массива
{
    double result = array[0];

    for (int i = 0; i < array.Length; i++)
        if (result > array[i]) result = array[i];

    return result;
}


int arraySize = 5,      //Входные параметры, размер массива
    arrayMinValue = 0,//Миинимальное значение
    arrayMaxValue = 20, //Максимальное значение
    arraydecimal = 1;   //Количество знаков после запятой

//генерируем массив с указаными параметры
double[] newArray = CreatArrayRndDouble(arraySize, arrayMinValue, arrayMaxValue, arraydecimal);
string strArray = ArrayDoubleToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

//Вычисляем разницу между максимальным и минимальными элементами
double diffMaxMinElem = ArrayDoubleMaxValue(newArray) - ArrayDoubleMinValue(newArray);
//Переодически возвращает число с 15 знаками после запятой, добавляю дополнительное округление
diffMaxMinElem = Math.Round(diffMaxMinElem, arraydecimal);

Console.WriteLine($"{strArray} -> {diffMaxMinElem}");
