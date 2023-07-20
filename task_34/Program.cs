// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] threeDigitNumbers = new int[size];
GetArrayRandomNumbers(threeDigitNumbers);
Console.WriteLine("Вывод массива с случайными положительными трёхзначными числами : ");
PrintArray(threeDigitNumbers);
int count = 0;

for (int i = 0; i < threeDigitNumbers.Length; i++)
if (threeDigitNumbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {threeDigitNumbers.Length} чисел, {count} из массива - чётные");

void GetArrayRandomNumbers(int[] threeDigitNumbers)
{
    for(int i = 0; i < threeDigitNumbers.Length; i++)
    {
        threeDigitNumbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] threeDigitNumbers)
{
    Console.Write("[ ");
    for(int i = 0; i < threeDigitNumbers.Length; i++)
    {
        Console.Write(threeDigitNumbers[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
