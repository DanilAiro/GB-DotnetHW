//Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b,
//введенные из командной строки, и выводящую результат выполнения на экран.

using HW1;

internal class Program
{
  private static void Main(string[] args)
  {
    double arg1;
    double arg2;

    if (args.Length == 0)
    {
      Console.Write("Напишите уравнение: ");
      try
      {
        args = Console.ReadLine().Split();
      }
      catch (NullReferenceException e)
      {

      }
    }

    if (args.Length < 3)
    {
      Console.WriteLine("В программу передано мало аргументов. Необходимо 3 аргумента!");
      Console.ReadKey();
      return;
    }
    else if (args.Length > 3)
    {
      Console.WriteLine("В программу передано много аргументов. Необходимо 3 аргумента!");
      Console.ReadKey();
      return;
    }
    else
    {
      if (!double.TryParse(args[0], out arg1))
      {
        Console.WriteLine($"{args[0]} не является числом. Повторите!");
        Console.ReadKey();
        return;
      }

      if (!double.TryParse(args[2], out arg2))
      {
        Console.WriteLine($"{args[2]} не является числом. Повторите!");
        Console.ReadKey();
        return;
      }
    }

    try
    {
      Console.WriteLine($"Результат: {arg1} {args[1]} {arg2} = {MyMath.CalculateArgs(arg1, args[1], arg2)}");
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }

    Console.ReadKey();
  }
}