// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateArrRandNumbs(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 1; i < numbers.Length; i+=2)
    sum = sum + numbers[i];
    Console.WriteLine($"Всего {numbers.Length}; сумма элементов, стоящих на нечётных позициях равна {sum}");

void CreateArrRandNumbs(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = new Random().Next(1,100);
        }
}
void PrintArray(int[] numbers)
{
    for(int x = 0; x < numbers.Length; x++)
        {
            Console.Write(numbers[x] + " ");
        }
    Console.WriteLine();
}