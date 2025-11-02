Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int[a];

Console.WriteLine("Введите элементы массива");
for (int i = 0; i < Arr.Length; i++){
    Arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(string.Join(" ", Arr));

Console.WriteLine();

Console.WriteLine("Введите размер массива");
int b = Convert.ToInt32(Console.ReadLine());
int k = 0;
int j = 0;
int[] Arr2 = new int[b];
Console.WriteLine("");
Console.WriteLine("Введите элементы массива");

for (int i = 0; i < Arr2.Length; i++){
    if (i % 2 == 0){
        Arr2[Arr2.Length - 1 - k] = Convert.ToInt32(Console.ReadLine());
        k++;
    }
    else if (i % 2 == 1){
        Arr2[j] = Convert.ToInt32(Console.ReadLine());
        j++;
    }
}
//
Console.WriteLine("Массив в правильном порядке:");
Console.WriteLine(string.Join(" ", Arr2));

Console.WriteLine();

int[,] Arr2D = new int[10, 10];

for (int row = 0; row < 10; row++)
{
    int sum = 0;
    for (int col = 0; col < 10; col++)
    {

        sum += Arr2D[row, col] = row + col;
        Console.Write(Arr2D[row, col] + " ");

    }
    Console.Write("Сумма элементов строки = " + sum);
    Console.WriteLine();

}

for (int row = 0; row < 10; row++)
{
    long compose = 1;
    for (int col = 0; col < 10; col++)
    {

        compose *= Arr2D[col, row];

    }
    Console.WriteLine("Произведение столбца " + row + " = " + compose);
}




