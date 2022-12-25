// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double LengthLine(int[] fp, int[] sp) //Метод для рассчета расстояния между двумя точками
{
    int x = (sp[0] - fp[0]) * (sp[0] - fp[0]);
    int y = (sp[1] - fp[1]) * (sp[1] - fp[1]);
    int z = (sp[2] - fp[2]) * (sp[2] - fp[2]);
    return Math.Sqrt(x + y + z);
}


int[] firstPoint = new int[3], secondPoint = new int[3];
//int[] firstPoint = {3,6,8}; int[] secondPoint = {2,1,-7};

firstPoint[0] = InsertDigit("Введите координату X первой точки");
firstPoint[1] = InsertDigit("Введите координату Y первой точки");
firstPoint[2] = InsertDigit("Введите координату Z первой точки");

secondPoint[0] = InsertDigit("Введите координату X второй точки");
secondPoint[1] = InsertDigit("Введите координату Y второй точки");
secondPoint[2] = InsertDigit("Введите координату Z второй точки");

double len = LengthLine(firstPoint, secondPoint); //Расчитываем растояние между двумя точками
len = Math.Round(len,2,MidpointRounding.ToZero);// Оставляем 2 знака после запятой
Console.WriteLine($"Растояние между точками: {len}");