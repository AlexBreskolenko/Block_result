﻿Console.Clear();

int EnterMessage(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

var CreateArray = (int num) => new int[num];

