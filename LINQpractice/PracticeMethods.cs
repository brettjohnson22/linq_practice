using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQpractice
{
    public class PracticeMethods
    {

        public IEnumerable<string> FindThWords(List<string> words)
        {
            var thWords = words.Where(w => w.Contains("th"));
            return thWords;
        }
        public IEnumerable<String> EliminateDoubles(List<string> words)
        {
            var singleWords = words.Distinct();
            return singleWords;
        }
        public double GradeAverages(List<string> grades)
        {
            var listofAverages = new List<double>();
            foreach (string originalGrades in grades)
            {
                var newGrades = originalGrades.Split(',').Select(s => int.Parse(s)).ToList();
                var lowestRemoved = newGrades.FindAll(g => g != newGrades.Min());
                double individualAverage = lowestRemoved.Average();
                listofAverages.Add(individualAverage);
            }
            double finalAverage = listofAverages.Average();
            return finalAverage;
        }
    }
}
