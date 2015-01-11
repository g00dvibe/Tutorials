//Write a program that concatenates two text files into another text file.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Merge2txtFiles
{
    class Task2
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../txt1.txt", Encoding.GetEncoding("windows-1251"));
            StreamReader secondReader = new StreamReader("../../txt2.txt", Encoding.GetEncoding("windows-1251")); 
            using (reader)
            {

            }
        }
    }
}
