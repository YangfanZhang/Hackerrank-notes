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

class Solution
{

    // Complete the luckBalance function below.
    static int luckBalance(int k, int[][] contests)
    {
        List<int> ImportantList = new List<int>();
        List<int> UnimportantList = new List<int>();
        int sumI = 0;
        int sumU = 0;
        int sumPositive = 0;
        int sumNegtive = 0;
        for (int i = 0; i < contests.Length; i++)
        {
            if (contests[i][1] == 1)
            {
                ImportantList.Add(contests[i][0]);
                sumI = sumI + contests[i][0];
            }
            else
            {
                UnimportantList.Add(contests[i][0]);
                sumU = sumU + contests[i][0];
            }
        }
        ImportantList.Sort();
        sumPositive = sumI + sumU;
        for (int j = 0; j < (ImportantList.Count - k); j++)
        {
            sumNegtive = sumNegtive + ImportantList[j];
        }
        int result = sumPositive - 2 * sumNegtive;
        return result;
    }

    static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);
        int[][] contests = new int[n][];
        for (int i = 0; i < n; i++)
        {
            contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        }
        int result = luckBalance(k, contests);
        Console.WriteLine(result);
    }
}
