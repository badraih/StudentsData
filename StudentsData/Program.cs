using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentsData
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\Users\beedo\source\repos\StudentsData\StudentsData\StudentData.txt";

            if (File.Exists(file))
            {
                //Sort By descending
                Console.WriteLine("Sort By descending!");
                StreamReader Textfile = new StreamReader(file, Encoding.ASCII);
                string line;
                // Reads file line by line
                while ((line = Textfile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }


                //To search about Bjorn in text file
                List<List<string>> students = new List<List<string>>();
                List<string> current = null;
                foreach (var lines in File.ReadAllLines(file))
                {
                    if (lines.Contains("Bjorn") && current == null)
                        current = new List<string>();
                  
                    if (current != null)
                    {
                        current.Add(lines);
                        Console.WriteLine("yes it is contain: "+lines);
                        current = null;
                    }
                       

                    
                }

                Console.ReadLine();
            }
        }
    }
}
