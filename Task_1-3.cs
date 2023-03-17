// Урок 5. Функции и одномерные массивы

// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.WriteLine("Задайте длину массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// RandonNumbers(numbers);
// Console.WriteLine("В массиве: ");
// PrintArray(numbers);

// void RandonNumbers(int[] numbers)
// {
//     for (int i = 0; i < size; i++)
//     {
//         numbers[i] = new Random().Next(100, 1000);
//     }
// }

// int count = 0;

// for (int x = 0; x < numbers.Length; x++)
// {
//     if (numbers[x] % 2 == 0)
//         count++;
// }
// Console.WriteLine($"В этом массиве из {numbers.Length} чисел, {count} четных");

// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Console.WriteLine("Задайте длину массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"В массиве {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76