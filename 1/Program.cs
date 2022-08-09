



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Ввидите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());


Console.Write("Ввидите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());


  int max = a;
  {
    if(b > a) max = b;
    if(c > b) max = c;
    System.Console.WriteLine(max);
  } 
