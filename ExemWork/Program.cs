
//Метод возращает колличество подходящих под условие элементов.
int ArrayСheck(string[] array, int workLengthElemet)
{
    //счётчик элементов полходящих под условие.
    int length = 0;
    foreach (string item in array)
    {
        if (item.Length <= workLengthElemet)
        {
            length++;
        }
    }
    return length;
}

//Метод возвращает новый массив,
//отсортированный согласно условию.
string[] CreateSortArray(string[] array, int lengthArray, int workLengthElemet)
{
    int length = array.Length;
    string[] newArray = new string[lengthArray];
    for (int i = 0, j = 0; i < length; i++)
    {
        if (array[i].Length <= workLengthElemet)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

//Создаём массив строк, с заданными в нём значениями.
string[] arrayString = { "Hello", "2", "world", ":-)", "1567", "1234", "-2", "computer science" };

//Условие, ограничивающее длину элемента.
int lengthElementArray = 3;

//Создаём новый массив и записываем в него элементы из первого массива, подошедшие по условию.
string[] sortArrayString = CreateSortArray(arrayString,
                            ArrayСheck(arrayString, lengthElementArray),
                            lengthElementArray);

//Вывод на консоль
Console.Write($"[ {string.Join(", ", arrayString)} ]");
Console.Write(" → ");
Console.Write($"[ {string.Join(", ", sortArrayString)} ]");

