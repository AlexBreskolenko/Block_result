Console.Clear();

int EnterMessage(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

var CreateArray = (int num) => new int[num];

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ResultingArray(int[] arr_1, int[] arr_2)
{
    for(int i = 0; i < arr_1.Length; i++)
    {
        if(arr_1[i] <= 3)
        {
            arr_2[i] = arr_1[i]; 
        }
    }
}

int sizeArray = EnterMessage("Какой размер первоначального массива вы хотите создать ? : ");
int[] arr_1 = CreateArray(sizeArray);
int[] arr_2 = {};


