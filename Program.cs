// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. (Можно изучить метод Split.
// Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);, где первый аргумент это разделитель чисел, второе обработчик введеной последовательности)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// int countNum (string numbers)
// {
//     System.Console.Write(numbers);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int [] InputArray(int length)
// {
//     int [] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//          array[i] = countNum($"Введите {i + 1}-й элемент");
//     }
//     return array;
// }

// void printArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] + {array[i]}");
//     }
// }

// int Positive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int length = countNum("Введите количество элементов ");
// int [] array;
// array = InputArray(length);
// printArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {Positive(array)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int Coeff = 0;
const int Constant = 1;
const int X = 0;
const int Y = 1;
const int Line1 = 1;
const int Line2 = 2;

double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y1={lineData1[Coeff]}*x1+{lineData1[Constant]} и y1={lineData2[Coeff]}*x1+{lineData2[Constant]}");
    Console.WriteLine($" имеет координаты ({coord[X]}),{coord[Y]}");
}

double InputNum(string numbers)
{
    System.Console.Write(numbers);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int NumLine)
{
    double[] lineData = new double[2];
    lineData[Coeff] = InputNum($"Введите коэффициент для {NumLine} прямой >");
    lineData[Constant] = InputNum($"Введите константу для {NumLine} прямой >");
    return lineData;
}
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X] = (lineData1[Constant] - lineData2[Constant]) / (lineData1[Coeff] - lineData2[Coeff]);
    coord[Y] = lineData1[Constant] * coord[X] + lineData1[Constant];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[Coeff] == lineData2[Coeff]);
    {
        if (lineData1[Constant] == lineData2[Constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Пямые параллельны");
        }
    }
    return true;
}
