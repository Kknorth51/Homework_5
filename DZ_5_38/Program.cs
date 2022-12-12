// Задача 38: Задайте массив случайных вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
CreateArrRandNumbs(numbers);
Console.WriteLine("Сгенерированный массив вещественных чисел: ");
PrintArr(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
    {
        max = numbers[j];
    }
    if (numbers[j] < min)
    {
        min = numbers[j];
    }
}

Console.WriteLine($"всего {numbers.Length}. Max = {max}, Min = {min}");
Console.WriteLine($"Разница между Max и Min значением = {max - min}");

void CreateArrRandNumbs(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random(  ).Next(100,1000)) / 10;
        }
}
void PrintArr(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}