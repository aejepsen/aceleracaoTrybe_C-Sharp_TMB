class Program
{
  static void Main(string[] args)
  {
    int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int sum = getSumDiagonal(matrix);
    Console.WriteLine(sum);
    int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int[,] matrix1 = fromArrayToTwoDimensionalArrayOp1(array,3,3);
    // int[,] matrix1 = fromArrayToTwoDimensionalArrayOp2(array);

    // imprimir matrix1
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
      for (int j = 0; j < matrix1.GetLength(1); j++)
      {
        Console.Write(matrix1[i, j] + " ");
      }
      Console.WriteLine();
    }

  }

  public static int getSumDiagonal(int[,] matrix)
  {
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum += matrix[i, i];
    }
    return sum;
  }

  public static int[,] fromArrayToTwoDimensionalArrayOp1(int[] array, int lines, int columns)

  {
    int[,] matrix3x3 = new int[lines, columns];
    for (int i = 0; i < array.Length; i++)
    {
      matrix3x3[i/lines, i%columns] = array[i];

    }
    return matrix3x3;
  }

  // public static int[,] fromArrayToTwoDimensionalArrayOp2(int[] array)
  // {
  //   int[,] matrix3x3 = new int[3, 3];
  //   int k = 0;
  //   for (int i = 0; i < matrix3x3.GetLength(0); i++)
  //   {
  //     for (int j = 0; j < matrix3x3.GetLength(1); j++)
  //     {
  //       matrix3x3[i, j] = array[k];
  //       k++;
  //     }
  //   }
  //   return matrix3x3;
  // }
}


