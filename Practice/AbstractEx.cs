using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
  public abstract class AbstractEx
  {
    public AbstractEx() {
      Console.WriteLine("ctor");
    }
    public void Add(int x, int y) {
      Console.WriteLine(x + y);
    }
    public abstract void Mul(int x, int y);
  }
  public class ChildClass : AbstractEx
  {
    public override void Mul(int x, int y) {
      Console.WriteLine(x * y);
    }

    public static void Main() {
      ChildClass c = new ChildClass();
      c.Add(2, 3);
      c.Mul(4, 5);
      AbstractEx a = c;
      a.Mul(5, 6);
      a.Add(4, 5);
    }
  }
  class MyClassTest
  {
    public void Method() {
      int i = 0;
      Method1(ref i);

      int j;
      Method2(out j);

    }
    public void Method1(ref int i) {
      Console.WriteLine(i);
    }
    public void Method2(out int i) {
      i = 1;
      Console.WriteLine(i);
    }

  }

}
