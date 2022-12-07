void FillNewArray(string[] tempArray, string[] oldArray)
{
    Console.Write("[");
    int i = 0;
    int j = 0;
    {
        for (i = 0; i < oldArray.Length; i++)
        {
            string s = oldArray[i];
            if (s.Length <= 3)
            {
                tempArray[j] = oldArray[i];
                
                Console.Write($"{tempArray[j]}");
                 if (i < tempArray.Length - 1)
                    {
                        Console.Write(", ");
                    }
                j++;

            }
        }
    }
Console.Write("]");
}

Console.Write("Введите размер массива: ");
string inputNumberOfArray = Console.ReadLine();
int numberOfArray = int.Parse(inputNumberOfArray);

string[] arrayOfString = new string[numberOfArray];
int i = 0;
int count = 0;
for (i = 0; i < numberOfArray; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    arrayOfString[i] = Console.ReadLine();
    string s = arrayOfString[i];
    if (s.Length <= 3)
    {
        count++;
    }
}
Console.WriteLine($"Новый массив состоит из {count} элементов ");
string[] newArray = new string[count];
Console.WriteLine();    
FillNewArray(newArray, arrayOfString);
