using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {
        List<int> result = new List<int>();
        List<int> result2 = new List<int>();
        int count = arr.Count;
        int index = -1;

        for(int i=0; i<count; i++)
        {
            result.Add(0);
        }

        for(int i=0; i<count; i++)
        {
            index = arr[i];
            result[index] += 1;
        }

        for(int i=0; i<100; i++)
        {
            result2.Add(result[i]);
        }

        return result2;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        List<int> arr = new List<int>();
        List<string> arrStr = new List<string>();

        arrStr = Console.ReadLine().TrimEnd().Split(' ').ToList();

        int c = arrStr.Count;

        for(int i=0; i<c; i++)
        {
            arr.Add(Convert.ToInt32(arrStr[i]));
        }

        List<int> result = Result.countingSort(arr);

        Console.WriteLine("\n\n");

        Console.WriteLine(String.Join(" ", result));

        //textWriter.WriteLine(String.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
