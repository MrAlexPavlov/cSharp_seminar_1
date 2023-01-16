// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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

int GetSumPositiveElem(int[] array) //метод подсчета положительных элементов массива
{
    int result=0;
    for(int i=0;i<array.Length;i++) 
    {
        result = array[i]>0 ? result+=array[i]: result;
    }
    return result;
}


 int GetSumNegativeElem(int[] array)// Метод подсчета отрицательных элементоа массива
{
    int result=0;
    for(int i=0;i<array.Length;i++) 
    {
        result = array[i]<0 ? result+=array[i]: result;
    }
    return result;
}

int arraySize = 12, arrayMinValue = -9, arrayMaxValue = 9;

int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

Console.WriteLine(strArray);

int posElem = GetSumPositiveElem(newArray);//Суммируем позитивные элементы массива
int negativeElem = GetSumNegativeElem(newArray);//Суммируем отрицательные элементы массива
Console.WriteLine($"Сумма положительных элементов: {posElem}");
Console.WriteLine($"Сумма отрицательных: {negativeElem}");