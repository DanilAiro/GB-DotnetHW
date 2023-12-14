//Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b,
//введенные из командной строки, и выводящую результат выполнения на экран.

namespace HW1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      if (args.Length == 0) 
      {
        Console.WriteLine("В программу не были переданы аргументы. Необходимо 3 аргумента!");
        return;
      }
      else if (args.Length < 3) 
      {
        Console.WriteLine("В программу передано мало аргументов. Необходимо 3 аргумента!");
        return;
      }
      else if (args.Length > 3)
      {
        Console.WriteLine("В программу передано много аргументов. Необходимо 3 аргумента!");
        return;
      }

      if (!double.TryParse(args[0], out double arg1))
      {
        Console.WriteLine($"{args[0]} не является числом. Повторите!");
        return;
      }

      if (!double.TryParse(args[2], out double arg2))
      {
        Console.WriteLine($"{args[2]} не является числом. Повторите!");
        return;
      }


      double result;
      switch (args[1])
      {
        case "+":
          result = arg1 + arg2;
          break;

        case "-":
          result = arg1 - arg2;
          break;

        case "*":
          result = arg1 * arg2;
          break;

        case "/":
          if (arg2 != 0)
          {
            result = arg1 / arg2;
          }
          else
          {
            Console.WriteLine("На ноль делить нельзя.");
            return;
          }
          break;

        default:
          Console.WriteLine("Операция не определена. Повторите!");
          return;
      }

      Console.WriteLine(result);
    }
  }
}
