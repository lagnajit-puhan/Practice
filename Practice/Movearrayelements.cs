namespace Practice
{
  public class Movearrayelements
  {
    // index           0, 1, 2, 3, 4, 5, 6, 7, 8
    //int[] mArray = { 0, 3, 6, 0, 3, 9, 5, 2, 0 };

    public void moveAllZerosElementToBegningOfArray(int[] arr) {
      int i = arr.Length - 1;
      int j = arr.Length - 1;
      while (i >= 0) {
        if (arr[i] != 0) {
          arr[j--] = arr[i];
        }
        i--;
      }
      while (j >= 0)
        arr[j--] = 0;

    }
    public void moveAllZerosElementToEndOfArray(int[] arr) {
      int i = 0;
      int j = 0;
      while (i < arr.Length) {
        if (arr[i] != 0) {
          arr[j++] = arr[i];
        }
        i++;
      }
      while (j < arr.Length)
        arr[j++] = 0;

    }
  }


}
