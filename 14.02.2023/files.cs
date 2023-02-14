using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Text Document.txt";
            FileReader(path);
            FileWriter(path); 
            FileReader(path);
            NumNumeration();
            LineAppender();
        }

        // Task 1 ("Reading the file" message was written before)
        static void FileReader(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
        }

        // Task 2
        static void FileWriter(string path)
        {
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(Environment.NewLine + "Adding a new piece of information.");
                }
            }
        }

        // Task 3
        static void NumNumeration()
        {
            string path = @"D:\num.txt";

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 1; i <= 1000; i++)
                {
                    if (i != 1000)
                    {
                        sw.Write($"{i}, ");
                    }
                    else
                    {
                        sw.Write($"{i}");
                    }
                }
            }

            FileReader(path);
        }

        // Task 4
        static void LineAppender()
        {
            string path = @"D:\lines.txt";

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }

            string[] array = { "red", "green", "blue", "white", "black" };

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string item in array)
                {
                    sw.WriteLine(item);
                }
            }

            FileReader(path);
        }
    }
}