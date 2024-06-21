// See https://aka.ms/new-console-template for more information
void PrintReorderedRandom2DArray(int[,] arrayToPrint){
    for (int i = 0; i < arrayToPrint.GetLength(0); i++) {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++) {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReorderRandom2DArray(int[,] arrayToReorder){ 
    for (int i = 0; i < arrayToReorder.GetLength(0); i++) {
        int temp = 0;
        for (int j = 0; j < arrayToReorder.GetLength(1)-1; j++) {
            if (arrayToReorder[i, j] < arrayToReorder[i, j+1]){
                temp = arrayToReorder[i, j];
                arrayToReorder[i, j] = arrayToReorder[i, j+1];
                arrayToReorder[i, j+1] = temp;
            }
        }
    }
    PrintReorderedRandom2DArray(arrayToReorder);
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

int rows = GetNumberAmount("Введите желаемое количество строк: ");
int columns = GetNumberAmount("Введите желаемое количество столбцов: ");
Console.WriteLine("The generated array: ");
int[,] resultArray = GenerateRandom2DArray (rows, columns, 0, 9);
Console.WriteLine("The reordered array: ");
ReorderRandom2DArray(resultArray);