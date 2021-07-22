using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
  public class ExtensionMethod
  {
    public string Display() {
      return ("I m in Display");
    }

    public string Print() {
      return ("I m in Print");
    }
  }

  public static class ExtentionCaller
  {
    public static void NewMethod(this ExtensionMethod ob) {
      Console.WriteLine("Hello I m extended method");
    }
  }

}
