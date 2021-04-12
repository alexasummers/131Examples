using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working with directories

            string rootPath = @"F:\JCCC Classes\GAME131Spring2021\FileSystem"; //path of file

            //  string[] dirs = Directory.GetDirectories(rootPath,"*", SearchOption.AllDirectories); //create string array of all the directories in this path

            //  foreach (string dir in dirs) //accessing substrings of the string array
            //  {
            //    Console.WriteLine(dir); //print all the directories in the path
            //}

            //Working with files

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            // {
            // Console.WriteLine(file);
            //  Console.WriteLine(Path.GetFileName(file));
            // Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            // Console.WriteLine(Path.GetDirectoryName(file));


            //Information about files



            //  var info = new FileInfo(file);

            //  Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");
            // }

            //string newPath = @"F:\JCCC Classes\GAME131Spring2021\FileSystem\SubFolderC\SubSubFolderD";
            //Directory.CreateDirectory(newPath);

            //bool directoryExists = Directory.Exists(newPath);

            //if (directoryExists)
            //{
            //    Console.WriteLine("The directory exists");
            //}
            //else
            //{
            //    Console.WriteLine("The directory does not exist");
            //    Directory.CreateDirectory(newPath);
            //}

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"F:\JCCC Classes\GAME131Spring2021\FileSystem\SubFolderA\";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationFolder}{ Path.GetFileName(file) }", true);
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{ i }.txt", false);
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}{ Path.GetFileName(file) }");
            //}

            //Console.ReadLine();
        }
    }
}
