using System;
using System.IO;

namespace SolutionFileSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                Console.WriteLine("Folder information is missed.");
            else
            {
                if(Directory.Exists(args[0]))
                {
                    string[] slnFileNames = System.IO.Directory.GetFiles(args[0], "*.sln", SearchOption.AllDirectories);
                    using(StreamWriter sWriter = new StreamWriter(args[1]))
                    {
                        foreach (string slnFileName in slnFileNames)
                        {
                            sWriter.WriteLine(slnFileName);
                        }
                    }
                   
                }
                else
                {
                    Console.WriteLine("No directory found.");
                }
            }
        }
    }
}
