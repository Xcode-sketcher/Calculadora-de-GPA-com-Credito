using System;
using System.Collections.Generic;
using System.Text;
using GPACalculatorWithCredit.Evaluation;

namespace GPACalculatorWithCredit.Evaluation
{
    public class CalculateGrade
    {
        public static void CalculateAverage()
        {
            int examAssignments = 5;
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
            Grades students = new Grades();
            

            foreach (string name in studentNames)
            {
                string currentStudent = name;
                int[] studentScores = students.GetScore(currentStudent);

                int sumAssignmentScores = 0;
                decimal currentStudentGrade = 0;
                int gradedAssignments = 0;

                foreach (int score in studentScores)
                {
                    gradedAssignments += 1;
                    if (gradedAssignments <= examAssignments)
                        sumAssignmentScores += score;
                    else
                        sumAssignmentScores += score / 10;
                }
                

                currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

                string letter = GetLetterGrade(currentStudentGrade);
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{letter}");
            }
        }

        private static string GetLetterGrade(decimal grade)
        {
            var letterGradeValues = new (decimal grade, string letter)[]
            {
                (97, "A+"),
                (93, "A"),
                (90, "A-"),
                (87, "B+"),
                (83, "B"),
                (80, "B-"),
                (77, "C+"),
                (73, "C"),
                (70, "C-"),
                (67, "D+"),
                (63, "D"),
                (60, "D-"),
                (0, "F")
            };

            foreach (var t in letterGradeValues)
            {
                if (grade >= t.grade)
                {
                    return t.letter;
                }
            }
            return "F";
        }
    }
}