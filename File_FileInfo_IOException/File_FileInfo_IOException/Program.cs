using System;
using System.IO;

namespace File_FileInfo_IOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"D:\file1.txt";
            string TargePath = @"D:\file2.txt";

            try {

                FileInfo fielInfo = new FileInfo(SourcePath);
                fielInfo.CopyTo(TargePath);
                string[] lines = File.ReadAllLines(SourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e){
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }




        }
    }
}
