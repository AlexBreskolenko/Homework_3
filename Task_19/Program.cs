/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Clear();

//Ввод числа
int EnterNum(string str)
{
    int num = Convert.ToInt32(str);
    return num;
}

//Проверка числа(на пятизначность)
bool CheckNum(int num)
{
    if (num > 9999 && num < 100000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Проверка на палиндром
bool CheckPalindrome(int num)
{
    int onePart = num / 1000;
    int a = num % 10;
    int b = (num / 10) % 10;
    int twoPart = (a * 10) + b;

    if (onePart == twoPart)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите пятизначное число : ");
string str = Console.ReadLine();

//Вводим число
int number = EnterNum(str);

//Проверяем на ввод 
if (CheckNum(number))
{
    if (CheckPalindrome(number))
    {
        Console.WriteLine("Число являеться палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не являеться палиндромом.");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число !");
}



