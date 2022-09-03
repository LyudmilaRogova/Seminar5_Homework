int [] CreateRandomArray(int size, int min, int max){
   int[] array = new int[size];
   for(int i=0; i<size; i++){
       array[i] = new Random().Next(min, max + 1);
    }
 return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}


//Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int EvenNumber(int[] array){
//     int count = 0;
//     for(int i=0; i<array.Length; i++){
//         if (array[i] % 2 == 0) count += 1;
//     }
//     return count;
// }


// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateRandomArray(size, 100, 999);
// ShowArray(arr);
// Console.WriteLine();
// Console.WriteLine($"Количество чётных чисел в массиве {EvenNumber(arr)} ");



//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int SumOfElements(int[] array){
//     int sum = 0;
//     for(int i=1; i<array.Length; i += 2){
//         sum += array[i];
//     }
//     return sum;
// }


// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите max: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] arr = CreateRandomArray(size, min, max);
// ShowArray(arr);
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumOfElements(arr)} ");



//Задайте массив чисел. Найдите разницу между максимальным и минимальным элементами массива.

int MaxEl(int[] array){
    int max = array[0];
    for(int i=1; i<array.Length; i++){
        if (array[i] > max) max = array[i];
    }
    return max;
}

int MinEl(int[] array){
    int min = array[0];
    for(int i=1; i<array.Length; i++){
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, min, max);
ShowArray(arr);
Console.WriteLine();

int diff = MaxEl(arr) - MinEl(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {diff}");

