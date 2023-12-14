using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
  internal class MyMath
  {
    public static double CalculateArgs(double arg1, string symbol, double arg2)
    {
      double result;
      switch (symbol)
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
            throw new DivideByZeroException("На ноль делить нельзя.");
          }
          break;

        default:
          throw new InvalidOperationException("Операция не определена. Повторите!");
      }

      return result;
    }
  }
}
