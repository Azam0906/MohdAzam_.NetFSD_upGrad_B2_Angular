using System;
using System.IO;

namespace FileStreamsDemo
{
    internal class Prblm4
    {
        static void Main()
        {
            Console.WriteLine("Enter root directory path:");
            string path = Console.ReadLine();

            try
            {
                if (!Directory.Exists(path))
                {
                    Console.WriteLine("Invalid directory path!");
                    return;
                }

                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo[] subDirs = dir.GetDirectories();
                Console.WriteLine("\nFolder Details:\n");
                foreach (DirectoryInfo subDir in subDirs)
                {
                    FileInfo[] files = subDir.GetFiles();
                    Console.WriteLine("Folder Name: " + subDir.Name);
                    Console.WriteLine("Number of Files: " + files.Length);
                    Console.WriteLine("---------");
                }

                Console.WriteLine("\nTotal Folders: " + subDirs.Length);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied to some folders.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}