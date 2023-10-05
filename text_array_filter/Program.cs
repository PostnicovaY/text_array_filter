// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = {"Russia", "Denmark", "Kazan"};
string[] newArray = textArrayFilter(array);

string[] textArrayFilter(string[] array){
    int count = 0;
    int maxLength = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength){
            count++;
        }
    }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength){
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.Write("[" + String.Join(", ",newArray) + "]");