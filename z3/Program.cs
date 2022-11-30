//Задача 29: Напишите программу, которая задаёт массив из 8 случайных
// целых чисел и выводит отсортированный по модулю массив.
//-2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19] 6, 1, -33 -> [1, 6, -33]

// метод 
void Zadacha39()
{
   
    int size = 6;
    int[] array = new int[size];
    Fill(array);
    Print(array);

    for (int i = 0; i < size-1; i++)
    {
        for (int j = 0; j < size - 1 -i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j+1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j+1] = temp;
            }
        }
        
    }
    Print(array);
}





// Fill array
void Fill(int[] massive)
{
    Random rand = new Random();
    int size = massive.Length;
    for (int i = 0; i < size; i++)
    {
        massive[i] = rand.Next(-5, 10);
    }
}
// Print
void Print(int[] massive1)
{

    for (int i = 0; i < massive1.Length; i++) Console.Write(" " + massive1[i]);

    Console.Write("\n");
}

Zadacha39();
