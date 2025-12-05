using System;
using System.Collections.Generic;
using System.Text;

namespace GPACalculatorWithCredit.Evaluation
{
    public class Grades
    {


        private int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        private int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
        private int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        private int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
        private int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
        private int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        private int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        private int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

        public int[] GetScore(string name)
        {
            return name switch
            {
                "Sophia" => sophiaScores,
                "Andrew" => andrewScores,
                "Emma" => emmaScores,
                "Logan" => loganScores,
                "Becky" => beckyScores,
                "Chris" => chrisScores,
                "Eric" => ericScores,
                "Gregor" => gregorScores,
                _ => throw new ArgumentException("Unknown student")
            };
        }
    }
}