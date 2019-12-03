using System;
using System.IO;

namespace NeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Syntax
            Console.WriteLine("Hello World!");
            int a = 1;
            Console.WriteLine(a);

            string[] lines = { "First line", "Second line", "Third line" };

            string [] temp = Read("WriteLines.txt");

            Write("test.csv", temp);

        }

        //The write file function
        public static void Write(string filename, string [] content){
            System.IO.File.WriteAllLines(@filename, content);
        }  
        
        //The read file function
        public static string [] Read(string filename){
            
            string [] content = { };

            try
            {
                using (StreamReader sr = new StreamReader("WriteLines.txt"))
                {
                    string line;
                    int a = 0;
                    while ((line = sr.ReadLine()) != null){
                        content[a++] = line;
                    }
                }
            }
            catch (Exception e){
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return content;
        }

    }
}
