// Revers array
/*
int[] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
        array[i]=new Random().Next(minValue, maxValue+1);
    return array;
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
        Console.Write(array[i] + " ");
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
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);
*/
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= i+j;
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);
*/
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

int[,] FindChetnie ( int[,] array)
{
    for (int i=0; i<array.GetLength(0); i+=2)
        for (int j=0; j<array.GetLength(1); j+=2)
        {
            array[i,j]*=array[i,j];
        }
    return array;    
}   

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);

int[,] changedArray =FindChetnie(myArray);
Show2dArray(changedArray);
*/
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int GetSumma (int[,] array)
{
    int sum=0;
    for (int i=0; i<array.GetLength(0); i++)
        sum+=array[i,i];
    return sum;
}
int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);
int result = GetSumma(myArray);
Console.WriteLine(result);
*/
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dDoubleArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    double[,] array=new double [rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1)+ Math.Round((new Random().NextDouble()),2);
    return array;
}

void Show2dArray (double[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

double[,] myArray= CreateRandom2dDoubleArray();
Show2dArray(myArray);
*/
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int SearchElement ( int[,] array)
{
    Console.WriteLine("Просьба ввести номер строки элемента: ");
    int x =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Просьба ввести номер столбца элемента: ");
    int y =Convert.ToInt32(Console.ReadLine());
    int res =-1;

    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            if (i==x && j==y) res=array[i,j];
    return res;
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);
int result =SearchElement(myArray);

if (result==-1) Console.WriteLine("Числа c такими индексами в массиве нет");
else Console.WriteLine("Значение элемента: " + result);
*/

