using System;
using System.Globalization;
using System.Linq;
using static ConsoleHelper_50.Helper_50;

class Program_5_3_2
{
    public static void Main(string[] args)
    {

        var arr1 = new int[] { 1, 2, 3 };
        int value = 9;
        BigDataOperation(arr1, ref value);

        //Console.WriteLine("arr[0] = {0}", arr1[0]);
        //WriteLn("value = " + value);

        int arrBaseSize = 1;
        var baseArray = GetArrayFromConsole(ref arrBaseSize);
        WriteLn("In the start we got next array", ConsoleColor.Green);
        PushArrayToConsole(baseArray);

        var tmpArray = new int[baseArray.Length];
        Array.Copy(baseArray, tmpArray, baseArray.Length);
        SortArray(ref tmpArray, out int[] sortedDesc, out int[] sortedAsc);
        WriteLn("Base array:", ConsoleColor.DarkYellow);
        PushArrayToConsole(baseArray);
        BubbleSort(ref tmpArray);
        WriteLn("Array after bubble sort:");
        PushArrayToConsole(tmpArray);
    }

    static void BigDataOperation(int[] metArr, ref int newValue)
    {
        newValue = 3;
        metArr[0] = newValue;
    }

    static int[] GetArrayFromConsole(ref int arrSize)
    {
        arrSize = 6;
        var arr = new int[arrSize];
        WriteLn("Введите массив размера (" + arrSize + ") (каждое значение с новой строки)");
        for (int i = 0; i < arrSize; i++) 
        {
            arr[i] = int.Parse(ReadLn());
        }
        return arr;
    }
    static void PushArrayToConsole(int[] arr)
    {
        Write("You array now is: { ");
        foreach (var element in arr)
        {
            Write(element.ToString(), ConsoleColor.White);
            Write(" ");
        }
        WriteLn(" }");
    }

    static void SortArray (ref int[] array, out int[] sortedDesc, out int[] sortedAsc)
    {
        WriteLn("Array in 1st param (tmpArray):", ConsoleColor.DarkYellow);
        PushArrayToConsole(array);
        WriteLn("Start sorting Desc");
        sortedDesc = SortArrayDesc(array);
        WriteLn("Sorted Desk (по убыванию)", ConsoleColor.Magenta);
        PushArrayToConsole(sortedDesc);
        WriteLn("");

        WriteLn("Array in 1st param (tmpArray):", ConsoleColor.DarkYellow);
        PushArrayToConsole(array);
        WriteLn("Start sorting Asc");
        sortedAsc = SortArrayAsc(array);
        WriteLn("Sorted Ask (по возрастанию)", ConsoleColor.Magenta);
        PushArrayToConsole(sortedAsc);
        WriteLn("");
    }
    static int[] SortArrayAsc (int[] array)
    {
        int size = array.Length;
        int temp = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }
    static int[] SortArrayDesc(int[] array)
    {
        int size = array.Length;
        int temp = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }
    static void BubbleSort(ref int[] arr)
    {
        int arrSize = arr.Length;
        int tmp = 0;
        bool flag;
        do
        {
            flag = false;
            for (int i = 0; i < arrSize - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    flag = true;
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                }
            }
        } while (flag);
    }
}