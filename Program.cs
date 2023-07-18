using System;
using System.IO;

namespace _18JulyDirectoryEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating folder in directory
            //string fFolder = "D:\\";
            //string newDir;
            //Console.WriteLine("Enter New Directory Name ");
            //newDir = Console.ReadLine();
            //string fPath = fFolder + newDir;
            //DirectoryInfo directoryInfo = new DirectoryInfo(fPath);
            //if(directoryInfo.Exists)
            //{
            //    Console.WriteLine($"Directory {newDir} already exist");
            //}
            //else
            //{
            //    directoryInfo.Create();
            //    Console.WriteLine($"Directory {newDir} craetion on {fPath} success");
            //}
            //Console.ReadKey();

            //To find a file from Directory
            string fpath;        // in output screen copy paste the paste from file folder
            Console.WriteLine("Enter Directory Path");
            fpath = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(fpath);
            foreach (FileInfo fi in di.GetFiles())
            {
                Console.WriteLine("File Name:\t"+fi.FullName);
                Console.WriteLine("\t File Length "+fi.Length);
                Console.WriteLine("\t File creation Time"+ fi.CreationTime);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
