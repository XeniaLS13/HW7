Console.WriteLine("Введите количество строк ");
int lineSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}
int columnSize = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lineSize, columnSize];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);