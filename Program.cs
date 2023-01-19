// Revers array
/*
int[] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
}

void ReversArray (int[] array)
{
   for (int i=0, j=array.Length-1; i<j; i++, j--)
   {
     int Tempor=array[i];
     array[i]=array[j];
     array[j]=Tempor;
   }
}

void ShowArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of elements: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of elements: ");
int max =Convert.ToInt32(Console.ReadLine());

int[] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);
ReversArray(newArray);
ShowArray(newArray);
*/
// Fibonacci numbers
/*
int [] FibonArray (int size, int a, int b)
{
    int [] array= new int[size];
    for (int i =2; i<size; i++)
    {
        array[0]=a;
        array[1]=b;
        array[i]=array[i-2]+array[i-1];
    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a first elements: ");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second elements: ");
int y =Convert.ToInt32(Console.ReadLine());

int[] newArray = FibonArray(m, x, y);
ShowArray(newArray);
*/
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[ ] CreateArray (int size)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        Console.Write($"Просьба ввести число номер {i+1} - ");
        int elements=Convert.ToInt32(Console.ReadLine());
        array[i]=elements;
    }
    return array;
}

int ZeroCount (int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i ++)
    {
        if (array[i]==0) count=count+1;
    } 
    return count;
}

Console.WriteLine("Укажите количество чисел: ");
int m =Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateArray(m);
int result=ZeroCount(newArray);
Console.WriteLine("Количество нулей: " + result);
*/
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double FindX( double k1, double b1, double k2, double b2)
{
    double x=(b2-b1)/(k1-k2);
    return x; 
}

double FindY( double k1, double b1, double k2, double b2)
{
    double y=(k1*(b2-b1)/(k1-k2))+b1;
    return y;
}

Console.WriteLine("Необходимо найти точку пересечения прямых: y = k1 * x + b1, y = k2 * x + b2 ");
Console.WriteLine("Укажите чисело k1: ");
double k1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите чисело b1: ");
double b1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите чисело k2: ");
double k2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите чисело b2: ");
double b2 =Convert.ToInt32(Console.ReadLine());

double x=FindX(k1,b1,k2,b2);
Console.WriteLine(x);
double y=FindY(k1,b1,k2,b2);
Console.WriteLine(y);
Console.WriteLine($"Кординаты пересечения прямых: ({x},{y})");
*/




