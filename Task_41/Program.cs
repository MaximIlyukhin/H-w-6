// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();
int[] GetintFromConsole(string message)
{
    Write(message);
    return Array.ConvertAll(ReadLine()!.Split(), int.Parse);
}

void CountPositiveElements(int[] Arr)
{
    int count = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] > 0)
            count++;
    }
    WriteLine($"Number of positive elements = {count}");
}

int[] message = GetintFromConsole("Enter elements(separated by space): ");
CountPositiveElements(message);

