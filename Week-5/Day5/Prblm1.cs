using System;
using System.IO;

namespace FileStreamDemo
{
    internal class Prblm1
    {
        static void Main()
        {
            Console.WriteLine("Enter log message:");
            string message = Console.ReadLine();
            string filePath = "log.txt";

            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine(message);
                writer.Close();  
                fs.Close();      
                Console.WriteLine("Message written successfully!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied to file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}