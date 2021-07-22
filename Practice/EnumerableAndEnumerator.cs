using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
  internal class EnumerableAndEnumerator
  {
    public static void Main() {


      List<int> listNumbers = new List<int>();

      listNumbers.Add(1);
      listNumbers.Add(2);
      listNumbers.Add(3);
      listNumbers.Add(2);
      listNumbers.Add(1);
      listNumbers.Add(4);
      var uniqueNumbers= new List<int>();
      var  s = string.Empty;
      
      foreach (var item in listNumbers) {

        if( listNumbers.FindAll(n => n == item).Count > 1) {
          uniqueNumbers.Add(item);
        }
      }

      IEnumerable<int> ienum = (IEnumerable<int>)listNumbers;
      foreach (var item in ienum) {
        Console.WriteLine(item);
      }

      //x is of type IEnumerator
      var x = ienum.GetEnumerator();

      IEnumerator<int> ienumerator = listNumbers.GetEnumerator();
      while (ienumerator.MoveNext()) {
        Console.WriteLine(ienumerator.Current);
      }
      //IEnumerbale doesnt remember the state means, current position. but IEnumerator rembers the current index position
    }
  }

  class Node
  {
    public int value;
    public Node node ;
    public Node(int n) {
      value = n;
      node = null;
    }
  }
}
