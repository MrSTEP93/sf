using System;

class MainClass
{
    public static void Main(string[] args)
    {

        var arr = new int[] { 1, 2, 3 };
        int value = 9;
        BigDataOperation(arr, ref value);

        Console.WriteLine("arr[0] = {0}", arr[0]);
        WriteLn();
        Console.ReadKey();

    }

    static void BigDataOperation(int[] metArr, ref int newValue)
    {
        newValue = 9;
        metArr[0] = newValue;
    }

}