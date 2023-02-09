// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string [] array = {"Russia", "Denmark", "Kazan", "Ufa"};
string [] newArray = new string [array.Length];

void PrintArray (string [] array)       // метод, который выводит массив строк на экран
{
   for (int i = 0; i < array.Length; i++)
   {
    Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
   Console.WriteLine("-->");
}

void ResArray (string [] array, string [] newArray)   // метод, который находит элементы строк, длина которых меньше или равна 3 симв.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

void PrintNewArray (string [] newArray)       // метод, который выводит новый массив строк на экран
{
   //int count = array.Length;
   for (int i = 0; i < newArray.Length; i++)
   {
    Console.Write($"{newArray[i]} ");
   }
   Console.WriteLine();
}

PrintArray(array);
ResArray(array, newArray);
PrintNewArray(newArray);






