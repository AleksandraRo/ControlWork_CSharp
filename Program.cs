// Итоговая контрольная работа по основному блоку.
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// 1. Задаю исходные данные: массивы строк,  максимальная длина строк нового массива

string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
int max = 3;     


// 2. Назначаю функцию для подсчёта количества элементов в массиве с длиной строк не больше заданной (max)
int CountItemsMaxLength(string[] arr, int max) 
{
    int count = 0;                                      // инициируется счетчик
    for (int i = 0; i < arr.Length; i++)                // назначается цикл по элементам массива
    {             
        if (arr[i].Length <= max)                       // проверяется длина элементов не больше max
        {                     
            count++;                                    // увеличивается счетчик
        }
    }
    return count;                                       // возвращается результат
}

// 3. Cоздаю новый массив и заполняю его элементами с длиной строк не больше заданной (max)
string[] NewArray(string[] arr, int max) {

    int newArrayLenght = CountItemsMaxLength(arr, max);  // узнаем, сколько элементов массива меньше заданной длинны
    string[] newArray = new string[newArrayLenght];     // создаем новый массив полученной длины
    int newArrayIndex = 0;                              // инициируется счетчик индексов нового массива
    for (int i = 0; i < arr.Length; i++) {              // перебираем исходный массив
        if (arr[i].Length <= max) {                     // проверяем, подходит ли элемент массива заданным условиям        
            newArray[newArrayIndex] = arr[i];           // копируем элемент в новый массив
            newArrayIndex++;                            // увеличиваем индекс - переходим к проверке след. элемента
        }
    }
    return newArray;                                    // возвращаем полученный массив
}

// 4. Метод вывода массива в консоль
void PrintArray(string[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        Console.Write('"');
        Console.Write(array[i]);
        Console.Write('"');
        if (i < array.Length - 1) {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

// 5. Вывожу итоговый результат
void Solving(string[] arr, int max) {
    string[] newArray = NewArray(arr, max);
    PrintArray(arr);
    Console.Write(" --> ");
    PrintArray(newArray);
    Console.WriteLine();
}
