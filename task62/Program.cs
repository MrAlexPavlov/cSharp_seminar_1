// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


string MatrixToString(int[,] array)//Метод преобразования массива в строку
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += "|";
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],3}";
            result = j < (array.GetLength(1) - 1) ? result + "," : result;//для корректности вывода запятых    
        }
        result += " |\n";
    }
    return result;
}

int[,] CreatSpiralMatrix(int rowSize, int colSize)
{

    int[,] resMatrix = new int[rowSize, colSize];

    bool right = true, left = false,
        down = false, up = false, change = false;

    int r = 0, c = 0;
    int mSize = rowSize * colSize;

    for (int i = 1; i <= mSize; i++)
    {
        change = false;
        resMatrix[r, c] = i;
        // Заполняем матрицу, двигаемся в право по столбцам до тех покр пока не закончиться матриуа или следующий элемент уже не заполнен
        if (right)
        {
            if (c < (colSize - 1))
                if (resMatrix[r, c + 1] > 0) { change = true; }

            if (c == (colSize - 1) || change)
            {
                right = false;
                down = true;
                //change = true;
                r++;
                continue;
            }
            else c++;
        }
        // Заполняем матрицу, двигаемся в низ по строкам до тех покр пока не закончиться матрица или следующий элемент уже не заполнен
        if (down && !change)
        {
            if (r < rowSize - 1)
                if (resMatrix[r + 1, c] != 0) { change = true; }

            if (r == rowSize - 1 || change)
            {
                down = false;
                left = true;
                //change = true;
                c--;
                continue;
            }
            else r++;
        }
        // Заполняем матрицу, двигаемся влево по столбцам до тех покр пока не закончиться матрица или предидущий элемент уже не заполнен
        if (left && !change)
        {
            if (c - 1 >= 0)
                if (resMatrix[r, c - 1] != 0) { change = true; }

            if ((c - 1) < 0 || change)
            {
                left = false;
                up = true;
                //change = true;
                r--;
                continue;
            }
            else c--;
        }
        // Заполняем матрицу, двигаемся вверх по строкам до тех покр пока не закончиться матрица или предидущий элемент уже не заполнен
        if (up && !change)
        {
            if (r - 1 >= 0)
                if (resMatrix[r - 1, c] != 0) { change = true; }

            if ((r - 1) < 0 || change)
            {
                up = false;
                right = true;
                //change = true;
                c++;
                continue;
            }
            else r--;
        }
    }
    return resMatrix;
}


int matrixRowSize = 10,
    matrixColSize = 10;

int[,] spiralValMatrix = CreatSpiralMatrix(matrixRowSize,matrixColSize);

string matrix = MatrixToString(spiralValMatrix);

Console.WriteLine(matrix);