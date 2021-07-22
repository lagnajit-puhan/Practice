using System;

namespace Practice
{
  public class FibonaciRecursive
  {
    public int Fib(int n) {
      try {
        if (n <= 1) {
          return n;
        } else {
          return Fib(n - 1) + Fib(n - 2);
        }
      } catch (Exception) {

        throw;
      } 
    }
  }
}
