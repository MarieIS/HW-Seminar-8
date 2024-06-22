// See https://aka.ms/new-console-template for more information
void PrintResultMatrix(int[,] arrayToPrint){
    for (int i = 0; i < arrayToPrint.GetLength(0); i++) {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++) {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationOfMatrixes(int[,] array1, int[,] array2){
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    int k = 0;
    int sum = 0;
    for (int i = 0; i < array1.GetLength(0); i++) {
        k = 0;
        while (k < array2.GetLength(1)){
         sum = 0;
         for (int j = 0; j < array1.GetLength(1); j++) {
              sum += array1[i, j] * array2[j, k];  
          }
            array3[i, k] = sum;
            k++;
         }
    }
    return array3;
}

int[,] GenerateRandom2DArray (int m, int n, int minValue, int maxValue) {
  int[,] array = new int[m, n];
  for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        array[i, j] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
  return array;
}

int GetNumberAmount(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows1 = GetNumberAmount("Введите желаемое количество строк первой матрицы: ");
int columns1 = GetNumberAmount("Введите желаемое количество столбцов первой матрицы: ");
int rows2 = GetNumberAmount("Введите желаемое количество строк второй матрицы: ");
int columns2 = GetNumberAmount("Введите желаемое количество столбцов второй матрицы: ");
if (columns1 == rows2) {
   Console.WriteLine("Сгенерированная матрица 1: ");
   int[,] matrix1 = GenerateRandom2DArray (rows1, columns1, 0, 9);
   Console.WriteLine("Сгенерированная матрица 2: ");
   int[,] matrix2 = GenerateRandom2DArray (rows2, columns2, 0, 9);
   int[,] matrix3 = GetMultiplicationOfMatrixes(matrix1, matrix2);
   Console.WriteLine("Результат перемножения матриц: ");
   PrintResultMatrix(matrix3);
 }
 else {
    Console.WriteLine("Количество столбцов первой матрицы не совпадает с числом строк второй матрицы. Невозможно выполнить перемножение матриц");
 }