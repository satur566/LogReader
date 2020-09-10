using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fullLog = File.ReadAllLines(args[0]);
            string reqDate = Console.ReadLine();
            for (int i = 0; i < fullLog.Length; i++)
            {
                if (fullLog[i].Contains(reqDate))
                {
                    Console.WriteLine(fullLog[i]);
                } 
            }
        }
    }
}
