Console.Clear();

int EnterMessage(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

var CreateArray = (int num) => new int[num];

void PrintArray(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ResultingArray(string[] arr_1, string[] arr_2)
{
    for(int i = 0; i < arr_1.Length; i++)
    {
        if(arr_1[i] <= 3)
        {
            arr_2[i] = arr_1[i]; 
        }
    }
}

void FillArray(string[] arr)
{
    string str = String.Empty;

    for(int i = 0; i < arr.Length; i++)
    {
        str = Console.ReadLine();
        arr[i] = str;
    }
}

//=======================================================================================================

int sizeArray = EnterMessage("Какой размер первоначального массива вы хотите создать ? : ");
string[] arr_1 = CreateArray(sizeArray);
string[] arr_2 = {};


