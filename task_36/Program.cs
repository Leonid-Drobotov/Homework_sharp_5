// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] RandomNumbers = new int[size];
GetArrayRandomNumbers(RandomNumbers);
Console.WriteLine("Текущий массив: ");
PrintArray(RandomNumbers);
int sum = 0;

for (int i = 0; i < RandomNumbers.Length; i+=2)
    sum = sum + RandomNumbers[i];

    Console.WriteLine($"всего {RandomNumbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void GetArrayRandomNumbers(int[] RandomNumbers)
{
    for(int i = 0; i < RandomNumbers.Length; i++)
        {
            RandomNumbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] RandomNumbers)
{
    Console.Write("[ ");
    for(int i = 0; i < RandomNumbers.Length; i++)
        {
            Console.Write(RandomNumbers[i] + ", ");
        }
    Console.Write("]");
    Console.WriteLine();
}
