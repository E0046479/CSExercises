using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            int[] markArray = new int[] {63,29,75,82,55};
            string[] nameArray = new string[] {"John","Venkat","Mary","Victor","Betty"};

            Console.WriteLine("Before Sort"); // close for test code
            PrintArrayData(markArray, nameArray);  // close for test code

            Console.WriteLine("After Sort By Marks Descending Order!");  // close for test code
            SortByMark(ref markArray, ref nameArray);
            PrintArrayData(markArray, nameArray);

            Console.WriteLine("After Sort By Name Alphabatically Order!");  // close for test code
            SortByName(ref markArray, ref nameArray);
            PrintArrayData(markArray, nameArray);
        }

        public static void SortByMark(ref int[] markArray, ref string[] nameArray){
            for (int greenArrow = 0; greenArrow < markArray.Length-1; greenArrow++)
            {
                for (int redArrow = greenArrow + 1; redArrow < markArray.Length; redArrow++)
                {
                    if (markArray[redArrow] > markArray[greenArrow])
                    {
                        int tempMark = markArray[redArrow];
                        markArray[redArrow] = markArray[greenArrow];
                        markArray[greenArrow] = tempMark;

                        string tempName = nameArray[redArrow];
                        nameArray[redArrow] = nameArray[greenArrow];
                        nameArray[greenArrow] = tempName;
                    }
                }
            }
        }

        public static void SortByName(ref int[] markArray, ref string[] nameArray)
        {
            for (int greenArrow = 0; greenArrow < markArray.Length - 1; greenArrow++)
            {
                for (int redArrow = greenArrow + 1; redArrow < markArray.Length; redArrow++)
                {
                    if (nameArray[redArrow].CompareTo(nameArray[greenArrow]) < 0)
                    {
                        int tempMark = markArray[redArrow];
                        markArray[redArrow] = markArray[greenArrow];
                        markArray[greenArrow] = tempMark;

                        string tempName = nameArray[redArrow];
                        nameArray[redArrow] = nameArray[greenArrow];
                        nameArray[greenArrow] = tempName;
                    }
                }
            }
        }

        public static void PrintArrayData(int[] markArray, string[] nameArray)
        {
            Console.WriteLine("*******START*******");  // close for test code
            Console.WriteLine("Name\t\tMarks");  // close for test code
            for (int i = 0; i < markArray.Length; i++)
            {
                Console.WriteLine("{0}\t\t{1}", nameArray[i], markArray[i]);
            }
            Console.WriteLine("*******END*******");  // close for test code
        }
    }
}
