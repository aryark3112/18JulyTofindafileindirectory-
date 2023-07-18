using System;
using System.IO;

namespace _18JulyDirectoryEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fFolder = "D:\\";
            string newDir;
            Console.WriteLine("Enter New Directory Name ");
            newDir = Console.ReadLine();
            string fPath = fFolder + newDir;
            DirectoryInfo directoryInfo = new DirectoryInfo(fPath);
            if(directoryInfo.Exists)
            {
                Console.WriteLine($"Directory {newDir} already exist");
            }
            else
            {
                directoryInfo.Create();
                Console.WriteLine($"Directory {newDir} craetion on {fPath} success");
            }
            Console.ReadKey();
        }
    }
}
