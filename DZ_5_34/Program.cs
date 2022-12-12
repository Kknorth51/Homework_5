// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
CreateArrRandNumbs(num);
Console.WriteLine("Сгенерированный массив: ");
PrintArr(num);
int c = 0;

for (int i = 0; i < num.Length; i++)
if (num[i] % 2 == 0)
c++;

Console.WriteLine($"{num.Length} чисел, {c} из них чётные");

void CreateArrRandNumbs(int[] num)
{
    for(int j = 0; j < num.Length; j++)
    {
        num[j] = new Random().Next(100,1000);
    }
}
void PrintArr(int[] numb)
{
    for(int z = 0; z < numb.Length; z++)
    {
        Console.Write(numb[z] + " ");
    }
    Console.WriteLine();
}