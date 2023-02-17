/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();

//Ввод числа 
int EnterNum(string str)
{
    int num = Convert.ToInt32(str);
    return num;
}

Console.Write("Введите число : ");
string str = Console.ReadLine();

int finishNum = EnterNum(str);

int startNum = 1;

while (startNum <= finishNum)
{
    if (startNum % 10 == 1
    )
    {
        Console.WriteLine();
    }
    Console.Write(startNum * startNum * startNum + " ,");
    startNum++;
}
