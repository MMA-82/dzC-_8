Console.Write("Введите число строк матрицы1: ");
int a1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число строк матрицы2: ");
int a2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов матрицы1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов матрицы2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Заданные матрицы имеют вид:");
int[,] matrix1 = new int[a1, b1];
void FillArray1 (int[,] matr1)
{
    for(int i=0; i<matrix1.GetLength(0); i++)
    {
        for(int j=0; j<matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix1[i, j]} ");
        }
    Console.WriteLine();    
    }
}
FillArray1 (matrix1);
Console.WriteLine();
int[,] matrix2 = new int[a2, b2];  
void FillArray2 (int[,] matr2)
{
    for(int i=0; i<matrix2.GetLength(0); i++)
    {
        for(int j=0; j<matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix2[i, j]} ");
        }
    Console.WriteLine();    
    }
}
FillArray2 (matrix2);
Console.WriteLine();

if(b1 != a2) Console.WriteLine("Матрицы нельзя перемножить, т.к. число столбцов первой матрицы не равно числу строк второй матрицы!!!");
else
{
    int[,] matrix3 = new int[a1, b2]; 
    for(int i=0; i<matrix1.GetLength(0); i++)
    {
        for(int j=0; j<matrix2.GetLength(1); j++)
        {
            for(int x=0; x<matrix2.GetLength(0); x++)
            {
                matrix3[i, j] += matrix1[i, x] * matrix2[x, j];
            }
        }
    }
    Console.WriteLine("Произведением данных матриц будет матрица:");
    void PrintArray (int[,] matrix3)
    {
        for(int i=0; i<matrix3.GetLength(0); i++)
        {
            for(int j=0; j<matrix3.GetLength(1); j++)
            {
               Console.Write($"{matrix3[i, j]} ");
            }
        Console.WriteLine();   
        }
    }    
    PrintArray (matrix3);
}


