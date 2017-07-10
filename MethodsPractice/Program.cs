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

            string myBirthMonth = "September";
            string myFriendBirthMonth = "December";
            string myVehicle = Vehicle(myFriendBirthMonth);
            string myFriendvehicle = Vehicle(myFriendBirthMonth)

            Console.WriteLine("My future vehicle is {0} and Jordan's vehicle{1}", myVehicle, myFriendBirthMonth);

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

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!");
        }

        public static void Useless()
        {
            Console.WriteLine("Blah, Blah, Blah");
        }

        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if(birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "HoverBoard";
            }
            else
            {
                vehicleFortune = "Sun";
            }
        }


    }
}
