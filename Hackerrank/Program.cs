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
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        var lastAnswer = 0;
        List<int> results = new List<int>();
        List<List<int>> sequenceArray = new List<List<int>>( new List<int> [n]);


        foreach (var query in queries)
        {
            int index = (query[1] ^ lastAnswer) % n;
            if (query[0] == 1)
            {
                if (sequenceArray[index] != null)
                {
                    sequenceArray[index].Add(query[2]);
                }
                else
                {
                    List<int> myList = new List<int>();
                    myList.Add(query[2]);
                    sequenceArray[index] = myList;
                }

            }
            else
            {
                int e = query[2] % n;
                lastAnswer = sequenceArray[index][e];
                results.Add(lastAnswer);
            }
        }

        return results;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        /*      string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

              int n = Convert.ToInt32(firstMultipleInput[0]);

              int q = Convert.ToInt32(firstMultipleInput[1]);

              List<List<int>> queries = new List<List<int>>();

              for (int i = 0; i < q; i++)
              {
                  queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
              }

              List<int> result = Result.dynamicArray(n, queries);

              Console.WriteLine(String.Join("\n", result));*/

        //   textWriter.Flush();
        //   textWriter.Close();
        int n = 2;
      //  int q = 5;
        List<int> q1 = new List<int> { 1, 0 ,5 };
        List<int> q2 = new List<int> { 1, 1, 7 };
        List<int> q3 = new List<int> { 1, 0, 3 };
        List<int> q4 = new List<int> { 2, 1, 0 };
        List<int> q5 = new List<int> { 2, 1, 1 };

        List<List<int>> queries = new List<List<int>> {q1,q2,q3,q4,q5};
        List<int> result = Result.dynamicArray(n, queries);
        Console.WriteLine(String.Join("\n", result)); 

    }
}
