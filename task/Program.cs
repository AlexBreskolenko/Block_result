Console.Clear();

int EnterMessage(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

var CreateArray = (int sizeArray) => new string[sizeArray];

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string[] ResultingArray(string[] arr_1)
{
    string[] arr_2 = new string[arr_1.Length];

    for (int i = 0; i < arr_1.Length; i++)
    {
        if (arr_1[i].Length <= 3)
        {
            arr_2[i] = arr_1[i];
        }
    }
    return arr_2;
}

void FillArray(string[] arr)
{
    string str = String.Empty;
    Console.WriteLine($"Заполните массив из {arr.Length} элементов : ");
    for (int i = 0; i < arr.Length; i++)
    {
        str = Console.ReadLine();
        arr[i] = str;
    }
}

//=======================================================================================================

int sizeArray = EnterMessage("Какой размер первоначального массива вы хотите создать ? : ");
string[] arr_1 = CreateArray(sizeArray);
FillArray(arr_1);

Console.WriteLine();

PrintArray(arr_1);
Console.WriteLine();

Console.WriteLine("==========================================================");
string[] arr_2 = ResultingArray(arr_1);
PrintArray(arr_2);

