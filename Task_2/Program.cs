// Написать программу, которая принимает на вход три числа и выдает
// максимальное из этих чисел 2,3,7=>7; 44 5 78=>78; 22 3 9=>22

int a=44;
int b=5;
int c=78;
int max =a;
if (b>a) max=b;
if (c>b) max=c;

Console.Write("max= ");
Console.WriteLine(max);