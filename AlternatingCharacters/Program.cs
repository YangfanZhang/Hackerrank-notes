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

class Solution {

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s) {
        List<char> datalist = new List<char>();
        datalist.AddRange(s);
        int count = 0;
        for(int i=0; i<datalist.Count-1; i++)
        {
            while(datalist[i]==datalist[i+1])
            {
                datalist.Remove(datalist[i+1]);
                count++;
                if(datalist.Count <= i+1)
                {
                    break;
                }
            }
        }
        return count;
    }

    static void Main(string[] args) {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = alternatingCharacters(s);

            Console.WriteLine(result);
        }
    }
}
