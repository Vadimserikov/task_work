// Написать программу, 
// которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// Лучше пользоваться массивами, а не коллекциями.

string [] firstArray = new string[3] {"hello", "2", "world" };
string [] secondArray = new string[firstArray.Length];

void SecondArr(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}
