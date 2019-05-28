using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeMethods pm = new PracticeMethods();
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var thWords = pm.FindThWords(words);
            foreach (var word in thWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var singleNames = pm.EliminateDoubles(names);
            foreach (var name in singleNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };
            var average = pm.GradeAverages(classGrades);
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
