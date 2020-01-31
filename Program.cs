using System;

namespace pcarillo_conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // collect score from user
            Console.WriteLine("Enter score:");

            // try statement to make sure user enters an integer
            try
            {
                // Create a string variable and get user input from the keyboard and store it in the variable
                int score = Convert.ToInt32(Console.ReadLine());

                // Print the letter grade of the variable (score), which will vary according to the score
                
                if (score < 60) // in case score is less than 60
                {
                    Console.WriteLine("Letter grade is: F"); // print "Letter grade is: F"
                }
                else if (score >=60 && score <= 61) // in case score is between 60 and 61
                {
                    Console.WriteLine("Letter grade is: D-"); // print "Letter grade is: D-"
                }
                else if (score >= 61 && score <= 68) // in case score is between 61 and 68
                {
                    Console.WriteLine("Letter grade is: D"); // print "Letter grade is: D"
                }
                else if (score >= 68 && score <= 69) // in case score is between 68 and 69
                {
                    Console.WriteLine("Letter grade is: D+"); // print "Letter grade is: D+" 
                }
                else if (score >= 70 && score <= 71) // in case score is between 70 and 71
                {
                    Console.WriteLine("Letter grade is: C-"); // print "Letter grade is: C-"
                }
                else if (score >= 72 && score <= 77) // in case score is between 72 and 77
                {
                    Console.WriteLine("Letter grade is: C"); // print "Letter grade is: C"
                }
                else if (score >= 78 && score <= 79) // in case score is between 78 and 79
                {
                    Console.WriteLine("Letter grade is: C+"); // print "Letter grade is: C+"
                }
                else if (score >= 80 && score <= 81) // in case score is between 80 and 81
                {
                    Console.WriteLine("Letter grade is: B-"); // print "Letter grade is: B-"
                }
                else if (score >= 82 && score <= 87) // in case score is between 82 and 87
                {
                    Console.WriteLine("Letter grade is: B"); // print "Letter grade is: B"
                }
                else if (score >= 88 && score <= 89) // in case score is between 88 and 89
                {
                    Console.WriteLine("Letter grade is: B+"); // print "Letter grade is: B+"
                }
                else if (score >= 90 && score <= 91) // in case score is between 90 and 91
                {
                    Console.WriteLine("Letter grade is: A-"); // print "Letter grade is: A-"
                }
                else if (score >= 92 && score <= 97) // in case score is between 92 and 97
                {
                    Console.WriteLine("Letter grade is: A"); // print "Letter grade is: A"
                }
                else if (score >= 98 && score <= 100) // in case score is between 98 and 100
                {
                    Console.WriteLine("Letter grade is: A+"); // print "Letter grade is: A+"
                }
                else if (score < 0) // in case score is less than 0
                {
                    Console.WriteLine("You entered a negative score. Please, enter a number betwen 0 and 100"); // print a warning message
                }
                else if (score > 100) // in case score is greater than 100
                {
                    Console.WriteLine("You entered a score greater than 100. Please, enter a number betwen 0 and 100"); // print a warning message
                }
            }
            // catch statement to deal with exception
            catch
            {
                Console.WriteLine("You didn't enter an integer. Please, enter an integer"); // print a warning message
            }
        }
    }
}