using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice
{
  public class DelegatesExample
  {

    // when we search a file in windows that runs in one thread and the main window is in another, and evertime it finds a match it shows in the window and keep adding the matching files 

    public static void Main() {
      SomeClass objsomeClass = new SomeClass();
      objsomeClass.sender += Receiver;
      //objsomeClass.sender = null; // possible in delegate but not in events

      Thread thread = new Thread(new ThreadStart(objsomeClass.LongProcess));
      thread.Start();

      Console.WriteLine("hello");
      Console.ReadLine();
    }
    public static void Receiver(int i) {
      Console.WriteLine(i);
    }
  }

  public class SomeClass
  {
    public delegate void Sender(int i);

    //public Sender sender = null;

    //Event is an encapsulation of delegate
    public event Sender sender = null;
    public void LongProcess() {
      for (int i = 0; i < 1000; i++) {
        sender(i);
        Thread.Sleep(5000);
      }
    }
  }
}
