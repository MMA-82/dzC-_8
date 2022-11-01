Console.Write("Введите число строк: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int b = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[a, b];
void FillArray (int[,] matr)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();    
    }
} 
FillArray (matrix);

int min = matrix[0, 0];
int mini = 0;
int minj = 0;
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        if(min > matrix[i, j]) 
        {
        min = matrix[i, j];
        mini = i;
        minj = j;
        }
    }
}
Console.WriteLine($"Минимальное число матрицы:({mini+1}, {minj+1}) = {min}");
Console.WriteLine(); 

int[,] matrix2 = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
int i2 = 0;
int j2 = 0;
for(int i=0; i< matrix.GetLength(0)-1; i++)
{
    if(i>=mini) i2 = i+1;
    else i2 = i;
    for(int j=0; j< matrix.GetLength(1)-1; j++)
    {
        if(j>=minj) j2 = j+1;
        else j2 = j;
        matrix2[i, j] = matrix[i2, j2];
    }    
}    
Console.WriteLine("Убираем из матрицы строку и столбец, на пересечении которых находится минимальное число:");
void PrintArray (int[,] matrix2)
{
    for(int i=0; i< matrix.GetLength(0)-1; i++)
    {
        for(int j=0; j< matrix.GetLength(1)-1; j++) Console.Write($"{matrix2[i, j]} ");
        Console.WriteLine();
    }
}
PrintArray(matrix2);
