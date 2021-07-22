using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Practice
{
  class Program
  {

    static void Main(string[] args) {

      //int[] mArray = { 0, 3, 6, 0, 3, 9, 5, 2, 0 };
      //Movearrayelements movearrayelements = new Movearrayelements();
      //movearrayelements.moveAllZerosElementToEndOfArray(mArray);


      //FibonaciRecursive fibonaciRecursive = new FibonaciRecursive();
      //int n = 8;
      //Console.Write(fibonaciRecursive.Fib(n));


      //Console.WriteLine("Hello World!");
      //A1 objA1 = new classA();
      //A2 objA2 = new classA();


      //List<Student> lstStd = new List<Student>();
      //var x = lstStd.SelectMany(s => s.Habits);


      //Gen<string> gen = new Gen<string>();
      //Child ch = new Child();


      //Program p = new Program();
      //p.print(2, 3, 8);
      //int[] arr = { 2, 11, 15, 20 };
      //p.print(arr);
      //Console.ReadLine();

      //ExtensionMethod extensionMethod = new ExtensionMethod();
      //extensionMethod.NewMethod();

      //foreach (var item in Nums()) {
      //  Console.WriteLine(item);
      //}
      ClassTest objsomeClass = new ClassTest();
      objsomeClass.DisplayEvent += Receiver;
      objsomeClass.DisplayEvent += Receiver;

      objsomeClass.Display();

      dynamic x = 10;
      x = "hi";


      // A obj = new A();
      //obj.Show();
      B b = new B();
      b.Show();
      A a = new B();
      a.Show();
      //B objb = new A();
      //objb.show();
    }

    public static void Receiver(int i) {
      Console.WriteLine(i);
    }
    public static void Receiver2(int i) {
      Console.WriteLine("Now at" +i);
    }
    public void print(params int[] b) {
      foreach (int i in b) {
        Console.WriteLine(i);
      }
    }

    //The yield keyword performs custom and stateful iteration and returns each element of a collection one at a time without the need of creating temporary collections
    public static IEnumerable<int> Nums() {
      yield return 1;

      yield return 2;

      yield return 3;
    }
  }

  public class ClassTest
  {
    public delegate void DelDisplay(int i);

    public event DelDisplay DisplayEvent = null;

    public void Display() {
      for (int i = 0; i < 1000; i++) {
        DisplayEvent(i);
        Thread.Sleep(5000);
      }
    }

  }

  #region Multiple Interface Implementation
  public interface A1
  {
    public void GetData();
    public int MyProperty { get; set; }
    public abstract void testc();
  }

  interface A2
  {
    void GetData();
  }

  public class classA : A1, A2
  {
    public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void testc() {
      throw new NotImplementedException();
    }

    void A2.GetData() {
      Console.WriteLine("sql data");
    }

    void A1.GetData() {
      Console.WriteLine("oracle data");
    }
  }
  #endregion

  class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public List<string> Habits { get; set; }
  }

  public class Gen<T>
  {
    public T MyProperty { get; set; }
  }



  #region Inheritance
  public class Parent
  {
    static Parent() {
      Console.WriteLine("This is static parent");
    }

    public Parent() {
      Console.WriteLine("This is parent");
    }
  }

  public class Child : Parent
  {
    static Child() {
      Console.WriteLine("This is static child");
    }

    public Child() {
      Console.WriteLine("This is child");
    }
  }
  #endregion

  public class A
  {
    public A() {
      Console.WriteLine("Default Ctor A");

    }
    static A() {
      Console.WriteLine("Static Ctor A");
    }

    private A(int x) {
      Console.WriteLine("private ctor A");

    }
    public void Show() {
      Console.WriteLine("Show A");
    }
  }


  public class B : A
  {

    public B() {
      Console.WriteLine("Default ctor B");

    }

    public void Show() {
      Console.WriteLine("B");
    }

    public void Show2() {
      Console.WriteLine("B");
    }
    public void Show3() {
      Console.WriteLine("B");
    }
  }

  public abstract class MyClass
  {
    public void Show() { }
  }
}
