// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели и проверяет является ли этот день выходным

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7)");
int a = int.Parse(Console.ReadLine()!);
if(a == 6 || a == 7) 
{
    Console.WriteLine("Этот день выходной");
}
  else if (a < 1 || a > 7) 
    {
        Console.WriteLine("Это вообще не день недели");
    }
else 
{
    Console.WriteLine("Этот день не выходной");
}