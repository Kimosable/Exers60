// Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
class Program
{
    static void Main(string[] args)
    {

        int[,,] arr = new int[10, 10, 10];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    int num = rnd.Next(10, 100);

                    while (Array.IndexOf(arr, num) != -1)
                    {
                        num = rnd.Next(10, 100);
                    }

                    arr[i, j, k] = num;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine("arr[{0}, {1}, {2}] = {3}", i, j, k, arr[i, j, k]);
                }
            }
        }

        Console.ReadLine();
    }
}