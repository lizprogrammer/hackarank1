using System;

namespace hackarank1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many grades are there?  ");
            
            string numberOfGrades = Console.ReadLine();
            int num = Int32.Parse(numberOfGrades);

            int [] myGrades = new int[num]; 
            
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter a grade: ");
                string grade = Console.ReadLine();
                myGrades[i] = Int32.Parse(grade);
            }
            
            for(int i = 0; i < num; i++)
            {
                if(myGrades[i] > 40)
                {
                    if (myGrades[i] > 40 && myGrades[i] < 50)
                    {
                        myGrades[i] = 50;
                    }
                    else if (myGrades[i] > 50 && myGrades[i] < 60)
                    {
                        myGrades[i] = 60;
                    }
                    else if (myGrades[i] > 60 && myGrades[i] < 70)
                    {
                        myGrades[i] = 70;
                    }
                    else if (myGrades[i] > 70 && myGrades[i] < 80)
                    {
                        myGrades[i] = 80;
                    }                    
                    else if (myGrades[i] > 80 && myGrades[i] < 90)
                    {
                        myGrades[i] = 90;
                    }
                    else if (myGrades[i] > 90 && myGrades[i] < 100)
                    {
                        myGrades[i] = 100;
                    }
                    
                }    
                Console.Write("{0} ", myGrades[i]);
            }
            Console.WriteLine();
        }
    }
}


/*
HackerLand University has the following grading policy:

Every student receives a  in the inclusive range from  to .
Any  less than  is a failing grade.
Sam is a professor at the university and likes to round each student's  according to these rules:

If the difference between the  and the next multiple of  is less than , round  up to the next multiple of .
If the value of  is less than , no rounding occurs as the result will still be a failing grade.
For example,  will be rounded to  but  will not be rounded because the rounding would result in a number that is less than .

Given the initial value of  for each of Sam's  students, write code to automate the rounding process.

Function Description

Complete the function gradingStudents in the editor below. It should return an integer array consisting of rounded grades.

gradingStudents has the following parameter(s):

grades: an array of integers representing grades before rounding
Input Format

The first line contains a single integer, , the number of students. 
Each line  of the  subsequent lines contains a single integer, , denoting student 's grade.

Constraints


Student  received a , and the next multiple of  from  is . Since , the student's grade is rounded to .
Student  received a , and the next multiple of  from  is . Since , the grade will not be modified and the student's final grade is .
Student  received a , and the next multiple of  from  is . Since , the student's grade will be rounded to .
Student  received a grade below , so the grade will not be modified and the student's final grade is .
*/