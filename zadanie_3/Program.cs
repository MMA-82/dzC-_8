Console.Write("Введите число строк: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите высоту матрицы: ");
int c = int.Parse(Console.ReadLine() ?? "0");

int[,,] matrix = new int[a, b, c];
Console.WriteLine("Трехмерная матрица случайных двузначных чисел построчно с индексами элементов:");
void FillArray (int[,,] matr)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            for(int k=0; k<matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                Console.Write($"({i},{j},{k})={matrix[i, j, k]}, ");
            }
        }
    Console.WriteLine();    
    }
} 
FillArray (matrix);

