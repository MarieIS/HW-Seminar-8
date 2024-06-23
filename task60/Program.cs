// See https://aka.ms/new-console-template for more information
void PrintResultMatrix(int[,,] arrayToPrint){
    for (int i = 0; i < arrayToPrint.GetLength(0); i++) {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++) {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++){
              Console.Write($"Элемент с индексами {i}, {j} и {k} -> {arrayToPrint[i, j, k]} ");
            }
            Console.WriteLine(); 
        }   
    }
}

int GetANumber(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] Generate3DArray () {
  int x = 2, y = 2, z = 2;
  int[,,] array3D = new int[x, y, z];

  int[] temp = new int[x * y * z];
  int number;
  for (int i = 0; i < temp.GetLength(0); i++){
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++){
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int k = 0; k < array3D.GetLength(0); k++){
    for (int l = 0; l < array3D.GetLength(1); l++)
    {
      for (int m = 0; m < array3D.GetLength(2); m++)
      {
        array3D[k, l, m] = temp[count];
        count++;
      }
    }
  }
    return array3D;
  }

int[,,] new3DArray = Generate3DArray();
PrintResultMatrix(new3DArray);