using System;
using System.Threading;

namespace CSExercises
{
    //The marks of students are stored in a two dimensional array with 
    //the subjects represented in columns and the students in the rows. 
    //That is Row 1 would pertain to Student 1 and the scores that this student 
    //has obtained is stored in various columns in row 1.  Assuming that there are 
    //12 students in a class and 4 subjects, write a program that would do the following:
    //  a.Compute the total marks obtained each student.
    //  b.Compute the class average and standard deviation* of Marks for each subject.
    //  c.Determine the overall average of marks for the whole class for each subjects.

    //Note:   
    //calculation of standard deviation is not required for first time exercise 
    //you may only compute the average – those needing additional practice 
    //may compute standard deviation)

    //Standard Deviation is square root of variance where Variance is given by:
    //	VARIANCE = { [SUM OF(Xi - M)2] / N }; i = 1 to N
    //      N is number of data elements(Xi) and
    //      M is mean(average). 

    public class ExF3
    {
        public static void Main(string[] args)
        {
            int [,] marks = new int[,]
            {
                {56,84,68,29},
                {94,73,31,96},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}
            };

            int[] total = CalculateTotalMarks(marks);
            double[] avg = CalculateStudentAverage(marks);
            double[] avgPerSubject = CalculateSubjectAverage(marks);


            for (int row = 0; row < 12; row++)
            {
                Console.WriteLine("Total marks for student {0}: {1}",row,total[row]);
                Console.WriteLine("Avg marks for student {0}: {1}", row, avg[row]);
            }

            for (int col = 0; col < 4; col++)
            {
                Console.WriteLine("Avg marks for subject {0}: {1:0}", col, avgPerSubject[col]);
            }

        }

        public static int[] CalculateTotalMarks(int[,] marks)
        {
            int[] total = new int[12];
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    total[i] = total[i] + marks[i,j];
                }
            }
                return total;
        }

        public static double[] CalculateStudentAverage(int[,] marks)
        {
            double[] avg = new double[12];
            int[] total = CalculateTotalMarks(marks);
            for (int i = 0; i < avg.Length; i++)
            {
                avg[i] = total[i] / marks.GetLength(1);
            }
                return avg;
        }

        public static double[] CalculateSubjectAverage(int[,] marks)
        {
            double[] avgPerSubject = new double[4];

            double[] total = new double[4];
            for (int i = 0; i < marks.GetLength(1); i++)
            {
                for (int j = 0; j < marks.GetLength(0); j++)
                {
                    total[i] = total[i] + marks[j, i];
                }
            }
            for (int i = 0; i < total.Length; i++)
            {
                avgPerSubject[i] = total[i] / marks.GetLength(0);
            }
            return avgPerSubject;
        }

        public static double[] CalculateVariance(int[,] marks)
        {
            //	VARIANCE = { [SUM OF(Xi - M)2] / N }; i = 1 to N
            //      N is number of data elements(Xi) and
            //      M is mean(average). 

//            For a finite set of numbers, the standard deviation is found by taking the square root of the average of the squared deviations of the values from their average value. For example, the marks of a class of eight students (that is, a population) are the following eight values:

//{\displaystyle 2,\ 4,\ 4,\ 4,\ 5,\ 5,\ 7,\ 9.} 2,\ 4,\ 4,\ 4,\ 5,\ 5,\ 7,\ 9.
//These eight data points have the mean (average) of 5:

//{\displaystyle {\frac {2+4+4+4+5+5+7+9}{8}}=5.} {\frac {2+4+4+4+5+5+7+9}{8}}=5.
//First, calculate the deviations of each data point from the mean, and square the result of each:

//{\displaystyle {\begin{array}{lll}(2-5)^{2}=(-3)^{2}=9&&(5-5)^{2}=0^{2}=0\\(4-5)^{2}=(-1)^{2}=1&&(5-5)^{2}=0^{2}=0\\(4-5)^{2}=(-1)^{2}=1&&(7-5)^{2}=2^{2}=4\\(4-5)^{2}=(-1)^{2}=1&&(9-5)^{2}=4^{2}=16.\\\end{array}}} {\begin{array}{lll}(2-5)^{2}=(-3)^{2}=9&&(5-5)^{2}=0^{2}=0\\(4-5)^{2}=(-1)^{2}=1&&(5-5)^{2}=0^{2}=0\\(4-5)^{2}=(-1)^{2}=1&&(7-5)^{2}=2^{2}=4\\(4-5)^{2}=(-1)^{2}=1&&(9-5)^{2}=4^{2}=16.\\\end{array}}
//The variance is the mean of these values:

//{\displaystyle {\frac {9+1+1+1+0+0+4+16}{8}}=4.} {\frac {9+1+1+1+0+0+4+16}{8}}=4.
//and the population standard deviation is equal to the square root of the variance:

//{\displaystyle {\sqrt {4}}=2.} {\sqrt {4}}=2.

            double[] variance = new double[12];
            double[] M = CalculateSubjectAverage(marks);
            double[] subtract = new double[12];

            for (int student = 0; student < marks.GetLength(0); student++)
            {
                for (int subject = 0; subject < marks.GetLength(1); subject++){
                    subtract[student] = Math.Pow(marks[student, subject] - M[subject],2);
                }
            }

                return variance;
        }
    }
}
