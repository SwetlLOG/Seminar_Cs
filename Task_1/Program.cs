// Напишите программу, которая принимает на вход два числа и выдвет
// какое больше, какое меньшее а= 5, 2, -9; в= 7, 10, -3.

int a=-9;
int b=-3;
int max;
int min;
if (a>b)
{
  max=a; min=b;
}
else
{
  max=b; min=a;
}
Console.Write("max= ");
Console.WriteLine( max );
Console.Write("max= ");
Console.WriteLine( min );