/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

//Ввод
double EnterNum(string str)
{
    double num = Convert.ToDouble(str);
    return num;
}

string str;

Console.WriteLine("Введите координаты точки A : ");
double x_1, y_1, z_1;

str = Console.ReadLine();
x_1 = EnterNum(str);

str = Console.ReadLine();
y_1 = EnterNum(str);
 
str = Console.ReadLine();
z_1 = EnterNum(str);


Console.WriteLine("Введите координаты точки B : ");
double x_2, y_2, z_2;

str = Console.ReadLine();
x_2 = EnterNum(str);

str = Console.ReadLine();
y_2 = EnterNum(str);
 
str = Console.ReadLine();
z_2 = EnterNum(str);

double result = Math.Sqrt(Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2) + Math.Pow(z_2 - z_1, 2));

Console.WriteLine("Расстояние между ними = " + result);