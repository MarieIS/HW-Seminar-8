// See https://aka.ms/new-console-template for more information
int FindRow (int[,] array){
  int minindex = 0, sum = 0, minsum = 0;
  for (int k = 0; k <array.GetLength(1); k++) {
    minsum += array[0, k];
  }

  for (int i = 0; i < array.GetLength(0); i++){ 
    for (int j = 0; j < array.GetLength(1); j++){
      sum += array[i, j]; 
    }
    if (sum < minsum) {
        minindex = i;
    }
    sum = 0;
  }
  return minindex;
}

void PrintRandom2DArray(int[,] arrayToPrint){
    for (int i = 0; i < arrayToPrint.GetLength(0); i++) {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++) {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GenerateRandom2DArray (int m, int n) {
  int[,] genarray = new int[m, n];
  for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        genarray[i, j] = new Random().Next(0, 10);
    }
  }
  return genarray;
}

int GetNumberAmount(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetNumberAmount("Введите желаемое количество строк: ");
int columns = GetNumberAmount("Введите желаемое количество столбцов: ");
int[,] resultArray = GenerateRandom2DArray (rows, columns);
PrintRandom2DArray(resultArray);
int index = FindRow(resultArray);
Console.WriteLine($"Индекс строки с наименьшей суммой: {index}");