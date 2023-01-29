/*
Итоговая проверочная работа.
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
1.	Создать репозиторий на GitHub
2.	Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3.	Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4.	Написать программу, решающую поставленную задачу
5.	Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум 
этапы 2,3 и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"] ["Russia", "Denmark", "Kazan"] -> []
*/


//Метод принуждения к вводу целого числа >0:
static int NumberPlus()
{
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
    {
        Console.WriteLine($"Вы ввели не целое число или не положительное число! Введите целое положительное число");
    }
    return number;
}

//Метод заполнения массива строк с клавиатуры
string [] FillingArrayKeyboard (string [] GetArray)
{
    for (int i = 0; i < GetArray.Length; i++)
    {
        Console.WriteLine($"Ведите значение элемента массива с индексом {i}");
        GetArray [i] = Console.ReadLine();
    }
    return GetArray;
}
//Метод исключения из массива длинных элементов

string [] DeleteLongItem (string [] GetArray, int MaxLen)
{
    string [] FinalArray = new string[0];
    int k = 0;
    for (int i = 0; i < GetArray.Length; i++)
    {        
        int L = GetArray[i].Length;
        if (L<=MaxLen)
        {
            Array.Resize(ref FinalArray, FinalArray.Length + 1);
            FinalArray [k] = GetArray[i];
            k++;
        }
    }
    return FinalArray;

}

//Метод печати массива
void PrintArray (string [] GetArray)
{
    Console.WriteLine($"[{string.Join(", ", GetArray)}]");
}

// Алгоритм программы

Console.WriteLine("Введите число элементов массива :");
int LenArray = Convert.ToInt32(NumberPlus());
string [] array1 = new string[LenArray];
array1 = FillingArrayKeyboard (array1);
Console.WriteLine("Исходный массив:");
PrintArray (array1);
Console.WriteLine("Введите максимальную длину элемента:");
int MaxLength = Convert.ToInt32(NumberPlus());
string [] array2 = DeleteLongItem (array1, MaxLength);
Console.WriteLine($"Полученный массив c элементами не длиннее {MaxLength} символов:");
PrintArray (array2);
