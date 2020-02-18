// Dalyno Puffer CIS 340 4:30PM Mini Project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Mini_Project
{
    class MiniProject
    {
        static void Main(string[] args)
        {
            // intitated arrays for names and scores
            // numberOfScores set respectively
            string[] names = new string[3];
            int[] score1;
            int[] score2;
            int[] score3;
            int numberOfScores = 0;

            //Prompts user to select the amount of scores per student
            // Converts then stores the scores
            // arrays length assigned by number of inputted scores
            Write("How many scores per student? ");
            numberOfScores = Convert.ToInt32(ReadLine());
            WriteLine();
            score1 = new int[numberOfScores];
            score2 = new int[numberOfScores];
            score3 = new int[numberOfScores];

            // loop runs once to prompt user to enter the students name
            // runs another for loop based on the length of the scores
            // quiz amount is incremented appropiately and scores are converted and stored
            for (int i = 0; i < 1; i++)
            {
                Write("Enter name for student {0}: ", (i + 1));
                names[i] = ReadLine().ToUpper();
                WriteLine("\nEntering scores for {0}", names[i]);

                for (int j = 0; j < score1.Length; j++)
                {

                    Write("Quiz {0}: ", (j + 1));
                    score1[j] = Convert.ToInt32(ReadLine());  
                }
                WriteLine();
            }
            
            //same concept are used for the other scores while index is + 1
            for (int i = 0; i < 1; i++)
            {
                Write("Enter name for student {0}: ", (i + 2));
                names[i+1] = ReadLine().ToUpper();
                WriteLine("\nEntering scores for {0}", names[i+1]);

                for (int j = 0; j < score2.Length; j++)
                {

                    Write("Quiz {0}: ", (j + 1));
                    score2[j] = Convert.ToInt32(ReadLine());
                }
                WriteLine();
            }

            for (int i = 0; i < 1; i++)
            {
                Write("Enter name for student {0}: ", (i + 3));
                names[i+2] = ReadLine().ToUpper();
                WriteLine("\nEntering scores for {0}", names[i+2]);

                for (int j = 0; j < score3.Length; j++)
                {

                    Write("Quiz {0}: ", (j + 1));
                    score3[j] = Convert.ToInt32(ReadLine());
                }
                WriteLine();
            }

            //clears console
            Console.Clear();

            //Calls the menu from a method
            //Prompts user to select a choice based on the menu option
            string choice = "";
            do
            {
                WriteLine();
                WriteLine();
                ShowMenu();
                Write("\nEnter choice number (1-3), or x to exit: ");
                choice = ReadLine().ToUpper();
             
            //Switch statement based on the choice of the user
            //Case calls the methods respectively
            switch (choice)
            {
                case "1":
                    MiniProject.ClassAverage(names, score1, score2, score3);
                    break;
                case "2":
                    MiniProject.StudentAverage(names, score1, score2, score3);
                    break;
                case "3":
                    MiniProject.QuizAverage(names, score1, score2, score3);
                    break;
                case "X":
                    break;
                default:
                    break;
            }
                ReadKey();
            }
            // Menu keeps displaying until the user prompts to exit out of the console
            while (choice != "X");           
        }
        
        //Method to determine the class average
        //Calls the appropiate arrays for the method
        static double ClassAverage(string[] names, int[] score1, int[] score2, int[] score3)
        {
            //initiated variables in order to successfully calculate 
            double total1 = 0.0;
            double total2 = 0.0;
            double total3 = 0.0;
            double average = 0.0;
            double sumOfAll = 0.0;

            //for loop for each score to add up the total
            for (int i = 0; i < score1.Length; i++)
            {
                    total1 = score1[i] + total1;                           
            }

            for (int i = 0; i < score1.Length; i++)
            {
                    total2 = score2[i] + total2;
            }

            for (int i = 0; i < score1.Length; i++)
            {
                    total3 = score3[i] + total3;                
            }

            // totals are added to the sumOfAll variable
            // which is then divided by 15 based on the number of scores
            // console then displays the correct class average for the scores
            // method then returns the average 
            sumOfAll = total1 + total2 + total3;
            average = (double)sumOfAll / 15 ;
            WriteLine("Class average for all quizes is {0:f2}", average);
            WriteLine();
            Write("Press any key to continue...");
            return average;

        }

        //Method used to find the student average calling the correct arrays
        static double StudentAverage(string[] names, int[] score1, int[] score2, int[] score3)
        {
            //variables used to appropiately execute the function
            //added a bool variable to run if loop for student position
            string studentName = "";
            bool nameFound = false;
            double total = 0.0;
            double average = 0.0;
            int index = 0;
            
            //Prompts used to enter name they want to calculate average for
            WriteLine("\nCalculating average by student.");
            Write("Enter student name: ");
            studentName = ReadLine().ToUpper();    

            //Runs for loop to ensure that the inputed student name matches the names of arrays
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == studentName.ToUpper())
                {
                    nameFound = true;
                    index = i;
                }
            }

            //run if statements to calculate the correct average of the score for the selected student
            // ran if loop to see if studentName matches the correct stored name in the array
            if (nameFound == true)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (studentName == names[i])
                    {
                        Write("{0} scores are: ", studentName);

                        for (int j = 0; j < score1.Length; j++)
                        {
                            Write("{0} ", score1[j]);
                            total = total + score1[j];
                            average = (double)total / score1.Length;
                        }
                        WriteLine();
                        WriteLine("{0}'s average is {1:f2}", studentName, average);
                    }
                }
            }
            
            // same concept used for each for loop 
            for (int i = 0; i < 1; i++)
                {
                    if (studentName == names[i+1])
                    {
                        Write("{0} scores are: ", studentName);

                        for (int j = 0; j < score2.Length; j++)
                        {
                            Write("{0} ", score2[j]);
                            total = total + score2[j];
                            average = (double)total / score2.Length;
                        }
                    WriteLine();
                    WriteLine("{0}'s average is {1:f2}", studentName, average);
                    }
                }

            // same concept
            for (int i = 0; i < 1; i++)
            {
                if (studentName == names[i + 2])
                {
                    Write("{0} scores are: ", studentName);

                    for (int j = 0; j < score3.Length; j++)
                    {
                        Write("{0} ", score3[j]);
                        total = total + score3[j];
                        average = (double)total / score3.Length;
                    }
                    WriteLine();
                    WriteLine("{0}'s average is {1:f2}", studentName, average);
                }
            }

            // if name is true continue running program
            // else, student not found.
            // returns average
            if (nameFound == true)
            {

            }
            else
            {
                WriteLine("Sorry, student not found.");
            }
            WriteLine();
            Write("Press any key to continue...");
            return average;

        }

        //Method to calculate a specific quiz average calling the appropiate arrays
        static double QuizAverage(string[] names, int[] score1, int[] score2, int[] score3)
        {
            //initiated the correct variables to execute the method
            int quizNumber = 0;
            double total = 0.0;
            double average = 0.0;

            //Prompts user to enter the quiz number they wish to find average for
            //converts and stores
            WriteLine("Calculating average by Quiz Number");
            Write("Enter Quiz number: ");
            quizNumber = Convert.ToInt32(ReadLine());
            
            //runs 3 for loops to capture all the correct quiz numbers from the score arrays
            // adds the totals of those scores then divides by 3
            for (int i = 0; i < score1.Length; i++)
            {
                for (int j = 0; j < score2.Length; j++)
                {
                    for (int k = 0; k < score3.Length; k++)
                    {
                        total = total + score1[i] + score2[j] + score3[k];
                        average = (double)total / 3;
                    }
                }
            }
            // displays the final result with the correct quiz number and average
            // returns average
            Write("Quiz {0} average is {1:f2} ", quizNumber, average);
            WriteLine();
            Write("Press any key to continue...");
            return average;
        }

        //menu used to display the choices the user can use to execute the methods
        static void ShowMenu()
        {
            WriteLine("\t\t\t Menu");
            WriteLine("1. Class Average");
            WriteLine("2. Student Average");
            WriteLine("3. Quiz Average");
        }
        
    }
}
