using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
  //sealed so cannot be instanciated and objet creation in derived classes
  public sealed class SingleTon
  {
    private SingleTon() {
      //to stop instanciated from outside this class
    }

    private static SingleTon Instance = null;

    public static SingleTon GetInstance {
      //will return one instance depending upon whether instance is null or not
      get {
        if (Instance == null)
          Instance = new SingleTon();
        return Instance;
      }
    }
  }
}
