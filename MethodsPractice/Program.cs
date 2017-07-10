using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are tools for us to create reusable pieces of code.
            //methods are a way of us collecting a series of instructions and call the,
            //when we need them.

            //methods are ALWAYS part of a class. methods are ALWAYS children of classes.
            //this means a method will NEVER be created inside another method or member of the class
            //however, methods are frequently CALLED inside another class or method

            //Console.WriteLine("Hello, Please enter the first number to be added.");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a second number to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int answer = Add(numberOne, numberTwo);

            //Console.WriteLine("The sum of your two numbers is " + answer);

            //RobotWarning("Will Robinson");
            //Useless();

            //string myBirthMonth = "September";
            //string myFriendBirthMonth = "December";
            //string myVehicle = Vehicle(myBirthMonth);
            //string myFriendvehicle = Vehicle(myFriendBirthMonth);

            //Console.WriteLine("My future vehicle is {0} and Jordan's vehicle{1}", myVehicle, myFriendBirthMonth);

            //favoriteFood("Robert", "Pizza");

            //RetirementCalculator(35);


            //double hoursWorked = 42.3d;
            //double hourlyWage = 12.50d;

            //Console.WriteLine("Your monthly wage is {0}.", wageCalculator(hoursWorked, hourlyWage));
            double hoursDaily = 8d;
            double hourlyWage = 20d;

                Console.WriteLine("Your wage per min is {0}.", wageCalculator(hoursDaily, hourlyWage));  
        }

        //Method header
        //access modifier - return type - method name (in pascal case) - parentheses(sometimes with parameters)
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method body
            //a complete method - header and body - is called a method declaration

            int sum = firstNumber + secondNumber;

            return sum;
            //the  "return" keyword takes whatever value is determined by using this method
            //and sends that value back to where i called my method
        }
        //if you have a method that does not have a return value, you would use the keyword
        //"void". when we have a "void" return type we DONT need to use the keyword "return"


       
    //public static void RobotWarning(string name)
    //{
    //    Console.WriteLine("Danger, " + name + "!!");
    //}

    //public static void Useless()
    //{
    //    Console.WriteLine("Blah, Blah, Blah");
    //}

    //public static string Vehicle(string birthMonth)
    //{
    //    string vehicleFortune;
    //    if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
    //    {
    //        vehicleFortune = "HoverBoard";
    //    }
    //    else
    //    {
    //        vehicleFortune = "Sun";
    //    }
    //    return vehicleFortune;
    //    }
    //    public static void favoriteFood(string name, string food)
    //    {
    //        Console.WriteLine(name +"'s favorite Food is " + food);
    //        }


        //create a method called FavoriteFood
        //it should take two string parameters. one representing a name, and the other representing a fav food
        //the return should concatenate

        //create a method called RetirementCalculator
        //it should take an int as a parameter representing the users age
        //the method should calculate how many more years until the user retires using 65 as the
        //age of retirement
        //the return typs should be void
        //once it calculates rhe users retirement age it should print
        //"the user will retire in x years" where x represents the value that was calculated
        //public static void RetirementCalculator( int Age)
        //{
        //    int retireAge = 65 - Age;
        //    Console.WriteLine("You will retire in {0}years" , retireAge);
        //}


        //public static double wageCalculator(double hoursWorkedWeekly, double hourlyWage)
        //{
        //    //this method should calculate Monthly wage
        //    double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
        //    return monthlyWage;
        //}

        //create two methods of your choosing, at least one method should return have a non-void
        //return type
        //both methods should take atleast one parameter
        //remember when naming your  method that it should represent what your method does
        //you method should only aim to accomplish one thing
        //be creative

        public static double wageCalculator( double hoursWorkedDaily, double hourlyWage)
            {
            double wageMin = (hoursWorkedDaily / hourlyWage) / .60d;
            return wageMin;
        }
       
        
    }
}
