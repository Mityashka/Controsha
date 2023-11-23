/*//Задача: 
Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.//*/

Console.WriteLine("Введите массив через пробел: ");
string massive = Console.ReadLine();
string[] FirstArray = massive.Split(' ');
Console.WriteLine("Наш изначальный массив: " + string.Join(", ", FirstArray));

string[] Filter(string[] FirstArray, int maximum)
{
    int counter = 0;
    for (int i = 0; i < FirstArray.Length; i++){
        if (FirstArray[i].Length <= maximum){
            counter++;
        }
    }
    string[] SecondArray = new string[counter];
    
    int index = 0;
    for (int i = 0; i < FirstArray.Length; i++){
        if (FirstArray[i].Length <= maximum){
            SecondArray[index] = FirstArray[i];
            index++;
        }
    }
    return SecondArray;
}
