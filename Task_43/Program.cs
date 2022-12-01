// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

double GetIntFromConsole(string message)
{
    Write(message);
    return double.Parse(ReadLine()!);
}

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    WriteLine($"({x}; {y})");
}

double message1 = GetIntFromConsole("Enter b1 = ");
double message2 = GetIntFromConsole("Enter k1 = ");
double message3 = GetIntFromConsole("Enter b2 = ");
double message4 = GetIntFromConsole("Enter k2 = ");
IntersectionPoint(message1, message2, message3, message4);






