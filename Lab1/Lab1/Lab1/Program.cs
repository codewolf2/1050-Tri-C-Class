﻿namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            #region Part1
            //getting the name section    
            System.Console.Write("What is your first name?");
            System.Console.WriteLine(); //fun little extra line for aesthetics
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial?");
            System.Console.WriteLine();
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            System.Console.WriteLine();
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("Your full name is " + fullName);
            System.Console.WriteLine();

            System.Threading.Thread.Sleep(5000);
            #endregion

            #region Part2
            //getting the height section
            System.Console.WriteLine();
            const double multiplier = 2.54;
            const int inchesInFoot = 12; 
            // above are just some constants to use later on instead of the numbers themselves

            System.Console.Write("How tall are you in feet while rounding down to the whole number?");
            System.Console.WriteLine();
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches over that nearest foot are you?");
            System.Console.WriteLine();

            heightInches = int.Parse(System.Console.ReadLine());

            totalHeightCM = heightFeet * inchesInFoot + heightInches * multiplier;
            System.Console.Write("Your total height in CM is " + totalHeightCM);
            System.Console.WriteLine();

            System.Threading.Thread.Sleep(5000);
            #endregion

            #region Part3
            // learning if the user can vote
            System.Console.WriteLine();
            System.Console.Write("How many years old are you?");
            System.Console.WriteLine();
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen of the United States?");
            System.Console.WriteLine();
            System.Console.Write("Please answer as either 'true' or 'false'.");
            System.Console.WriteLine();
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = age > 17 && isCitizen;
            System.Console.Write("The fact that you are able to vote is " + canVote);
            System.Console.WriteLine();

            System.Threading.Thread.Sleep(5000);
            #endregion

        }
    }
}
