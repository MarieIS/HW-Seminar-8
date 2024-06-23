// See https://aka.ms/new-console-template for more information
void PrintResultMatrix(int[,] arrayToPrint){
    for (int i = 0; i < arrayToPrint.GetLength(0); i++) {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++) {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetANumber(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateSpiral2DArray () {
  int row = 4, col = 4;
  int[,] newArray = new int[row, col];
  int minRow = 0, maxRow = row - 1, minCol = 0, maxCol = col - 1;
  int count = 0;
  int max = row * col;
  while (count < max) {
    for (int k = minCol; k <= maxCol; k++){
        newArray[minRow, k] = GetANumber("Введите ваше целое число: ");
        count++;
    }
    minRow = minRow + 1;
    for (int k = minRow; k <= maxRow; k++){
        newArray[k, maxCol] = GetANumber("Введите ваше целое число: ");
        count++;
    }
    maxCol = maxCol - 1;
    for (int k = maxCol; k >= minCol; k--){
        newArray[maxRow, k] = GetANumber("Введите ваше целое число: ");
        count++;
    }
    maxRow = maxRow - 1;
    for (int k = maxRow; k >= minRow; k--){
        newArray[k, minCol] = GetANumber("Введите ваше целое число: ");
        count++;
    }
    minCol = minCol + 1;
    }
    return newArray;
  }

int[,] spiralArray = GenerateSpiral2DArray();
PrintResultMatrix(spiralArray);