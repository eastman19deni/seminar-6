// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using static System.Console;

const int COEFFECIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineDate1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineDate1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Write($"Точка пересечения управления y={lineDate1[COEFFECIENT]}*x+{lineDate1[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]}");
    WriteLine($"имеет координаты ({coord[X_COORD]}),{coord[Y_COORD]}");
}
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFECIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} примой");
    return lineData;
}
double[] FindCoords(double[] lineDate1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFECIENT] - lineDate1[COEFFECIENT]);
    coord[Y_COORD] = lineDate1[CONSTANT] * coord[X_COORD] + lineDate1[CONSTANT];
    return coord;
}
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFECIENT] == lineData2[COEFFECIENT])
    {
        if(lineDate1[CONSTANT] == lineData2[CONSTANT])
        {
            WriteLine("stright line");
            return false;
        }
        else
        {
            WriteLine("Прямая паралельная");
            return false;
        }
    }
    return true;
}