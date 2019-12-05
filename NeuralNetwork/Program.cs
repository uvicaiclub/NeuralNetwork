//Neural Network
//Author: Debrah Wyatt
//Created on Dec 4th 2019

/*
 * This is a neural network factory designated
 * for use by the UVic AI Club.
 */

using System;
using System.IO;

namespace NeuralNetwork
{
    class Program
    {
        /*////////////////////*/
        /*//Local Functions///*/
        /*////////////////////*/
        
        //The write file function
        public static void Write(string filename, string content){
            //System.IO.File.WriteAllLines(@filename, content);
            System.IO.File.WriteAllText(@filename, content);
        }

        //The read file function
        public static string Read(string filename){
            //Initialize the string to be stored
            string content = "";

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    //Reads the whole file
                    content = sr.ReadToEnd();
                }
            }
            catch (Exception e){
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return content;
        }

        /*////////////////////*/
        /*////Main Sequence///*/
        /*////////////////////*/
        static void Main(string[] args)
        {

            //string[] am = { "hah" };
            //Write("test.csv", "am");

            //string temp = Read("test.csv");
            //Console.WriteLine(temp);

            //Now that we can store variables long term,
            //lets set up some of our neural network.

            int N = 2; //x1 & x2
            int L = 2; //l1 & l2
            int M = 1; //y

            /* A visual representation of our net
             
                x1-\-O-\
                x2-/-O--y

            */

            //Lets make a weight array in csv format to represent the centre layers of this net
            //Here are some test variables, we want to back propogate the layer weights.
            /*
            double[] layers2 = { 0.5, 0.4 };
            double[] X2 = { 1, 0 };

            double[] X = new double[N];
            double[] layers = new double[L];
            double[] Y = new double[M];
            
            double[][] weights = new double[2][];
            double[] final_weights = new double[2];
            */

            //We'll say this is {{ x1->l1, x1->l2 }, {x2->l1, x2->l2}}
            double[,] weights = new double[,] { { 0.1, 0.2 }, { 0.3, 0.4 } };
            Console.WriteLine(weights[0,1]);

            //This is { l1->y, l2->y }
            double[] final_weights = new double[] { 0.5, 0.6 };


        }
    }
}
