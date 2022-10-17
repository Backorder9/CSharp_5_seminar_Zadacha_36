/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void OddIndexSum()
{
int n = new Random().Next(10, 15); // Размер массива задан случайно
int [] num = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
    {
        num[i] = new Random().Next(1, 100);
        if (i % 2 != 0) sum = sum + num[i];
    }

Console.WriteLine();
Console.WriteLine("Создан массив случайных чисел: " + String.Join(", ", num) + ".");
Console.WriteLine();
Console.WriteLine($"Созданный массив соодержит {n} элементов.");
Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях: {sum}.");
Console.WriteLine();
}
OddIndexSum();