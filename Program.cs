// See https://aka.ms/new-console-template for more information
//Camel Case 
//Pascal Case 
//Hungarian Case

/*
 * primitive Data Types
 * Get values from the console
 * Operators
 * for loop
*/



//string intNumber
//string IntNumber
//string strIntNum
/*
Console.WriteLine("Please input Your FirstName");
string firstName = Console.ReadLine();
Console.WriteLine("Please input your LastName");
string lastName = Console.ReadLine();

Console.WriteLine("Your firstName is " + firstName + ", your lastname is " + lastName + ".");

Console.WriteLine("Welcome to this year Competition");
Console.WriteLine("Age should be above 18");
Console.WriteLine("Pls input your age");

int ageInput = Convert.ToInt32(Console.ReadLine());
if (ageInput < 18)
{
    Console.WriteLine("You are not qualified to register");
}
else
{
    Console.WriteLine("You registration is complete");
}
*/
/*Operators
Arithmetic Operators + 
prefix a++
postfix ++a
Logiacl Operators && ||
Assignment Operators = += -= *= /= 
Comparison Operators < > >= <= == !=
Bitwise Operators & |
*/

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//int a = 20;
//int b = ++a;

//int c = 20;
//int d = c++;

//Console.WriteLine(d);

//for (int i = 0; i <= 20; i++)
//{
//    if (i % 2 == 1)
//    {
//        double num = i + 0.5;
//        Console.WriteLine(num);
//    }
//}

//Console.WriteLine("Enter your Firstname: ");
//string firstName = Console.ReadLine();
//Console.WriteLine("Enter your Lastname: ");
//string lastName = Console.ReadLine();
//Console.WriteLine("Enter Your Year Of Birth: ");
//int yearOfBirth = Convert.ToInt32(Console.ReadLine());
//int currentYear = 2023;
//int age = currentYear - yearOfBirth;

//Console.WriteLine("Your first name is " + firstName + ", your last name is " + lastName + ". And Your age is " + age);

/*DataTypes
primitive types
 * 
Integral Types
real number 
character
Boolean

* refrence types


*/
// Real Numbers
//float firstNumber = 23.039475678930f;
//decimal secondNumber = 30.0946579856399876543212m;
//double thirdNumber = 30.4332345609839876543212;
//Console.WriteLine("This is the float: "+ firstNumber);
//Console.WriteLine("This is the decimal: " + secondNumber);
//Console.WriteLine("This is the double: " + thirdNumber);

//Console.WriteLine("This is decimal maxvalue: " + decimal.MaxValue);
//Console.WriteLine("This is float maxvalue: " + float.MaxValue);
//Console.WriteLine("This is double maxvalue: " + double.MaxValue);
//string spaceOne = Console.ReadLine();
//Console.WriteLine("This is Decimal minvalue: " + decimal.MinValue);
//Console.WriteLine("This is float minvalue: " + float.MinValue);
//Console.WriteLine("This is double minvalue: " + double.MinValue);


// Integral Numbers
//byte
//sbyte
//int
//long
//ulong
//string spaceThree = Console.ReadLine();
//Console.WriteLine("This is byte maxValue: " + byte.MaxValue);
//Console.WriteLine("This is sByte maxvalue: " + sbyte.MaxValue);
//Console.WriteLine("This is int maxValue: " + int.MaxValue);
//Console.WriteLine("This is long maxvalue: " + long.MaxValue);
//Console.WriteLine("This is ulong maxvalue: " + ulong.MaxValue);
//string spaceTwo = Console.ReadLine();
//Console.WriteLine("This is byte minvalue: " + byte.MinValue);
//Console.WriteLine("This is sbyte minvalue: " + sbyte.MinValue);
//Console.WriteLine("This is int minvalue: " + int.MinValue);
//Console.WriteLine("This is long minvalue: " + long.MinValue);
//Console.WriteLine("This is ulong minvalue: " + ulong.MinValue);


//Char
//char letter = 'T';
//Console.WriteLine(letter);
//Console.WriteLine(char.MinValue);
//Console.WriteLine(char.MaxValue);


//Boolean
//bool yes = true;
//bool no = false;


// datatypes redeclaration
//int numOne; //Initialise
//numOne = 2; // Assign

//int numTwo = 30;
//numTwo = 40;

//Constant // standard way to declare a constant is Pascal Case
//const int Constant = 20;

// How not to declare a variable
//int first Number = 10;  You cant declare a variable with space in it
//int 1first = 20; You cant declare a variable with a number at the biginning
//var while = 20; You cant use a reserved keyword

//for(int i = 20; i > 20; ++i)
//{
//    Console.WriteLine(i);
//}


//int num = 20;

//if (!(!(!(num != 20))))
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}


//for (int i = 0; i <= 20; i++)
//{
//    if (i % 2 == 0)
//    {
//        double rend = i + 0.5;
//        Console.WriteLine(num);
//    }
//}

// Assignment



//Console.Write("Enter the total numbers of value you wish to enter: ");
//int totalNumber = Convert.ToInt32(Console.ReadLine());

//int MaxValue = int.MinValue;
//int MinValue = int.MinValue;

//for (int i = 0; 0 <= totalNumber ; i++)
//{
//    Console.Write("Input Value " + i +": ");
//    int currentValue = Convert.ToInt32(Console.ReadLine());
//    if( currentValue > MaxValue)
//    {
//        MaxValue = currentValue;
//    }
//    if(currentValue < MinValue)
//    {
//        MinValue = currentValue;
//    }
//    Console.Write("Maximum value:" + MaxValue);
//    Console.Write("Minimum value:" + MinValue);
//}

//int numOne = 20;
//int numTwo;
//int numThree;



//int a;
//int b;
//int bage;


//Console.WriteLine("Please input your no b");
//int secondName = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please input your no");
//bool tryt = int.TryParse(Console.ReadLine(), out bage);
//if (tryt == false)
//{
//}

//int num;
//Console.WriteLine("Please input the number");
//bool tryt = int.TryParse(Console.ReadLine(), out num);

//do
//{
//    tryt = int.TryParse(Console.ReadLine(), out num);
//    Console.WriteLine("Enter your number again");
//} while (tryt == false);

//Console.Write("Enter the total number of values: ");
//int totalCount = int.Parse(Console.ReadLine());

//int maxValue = int.MaxValue;
//int minValue = int.MinValue;

//for (int i = 1; i <= totalCount; i++)
//{
//    Console.Write($"Enter value {i}: ");
//    int currentValue = int.Parse(Console.ReadLine());

//    if (currentValue < maxValue)
//    {
//        maxValue = currentValue;
//    }

//    if (currentValue > minValue)
//    {
//        minValue = currentValue;
//    }
//}



//Console.WriteLine($"Maximum value: {maxValue}");
//Console.WriteLine($"Minimum value: {minValue}");

//scope
//try parse
//$


/*
 * Create a new console application.
 * Prompt the user to enter the total number of values they want to input
 * Use a loop to iterate through the numbers of values specified by the user.
 * Inside the loop, prompt the user to enter each value and store it in a variable
 * Use an if statement to compare the current value with the maximum and minimum values encountered so far.
   (cont.) Update the maximum and minimum variables accordingly
 * After the loop ends, display the maximum and minimum values entered by the user.

   Example:
    Enter the total number of values: 5;
    Enter value 1: 10
    Enter value 2: 5;
    Enter value 3: 8;
    Enter value 4: 2;
    Enter value 5: 15;

    Maximum value:15
    Minimum value:2
 */

//Console.Write("Enter the Total number of values: ");
//int totalNumber = Convert.ToInt32(Console.ReadLine());
//if(totalNumber > 10)
//{
//    Console.WriteLine("number cant be above 10");
//}
//else
//{
//    int MaxValue = -10;
//    int MinValue = 10;

//    for (int i = 1; i < totalNumber; i++)
//    {
//        Console.Write($"Input value {i}: ");
//        int values = Convert.ToInt32(Console.ReadLine());

//        if (MaxValue < values)
//        {
//            MaxValue = values;
//        }

//        if (MinValue > values)
//        {
//            MinValue = values;
//        }
//    }

//    Console.WriteLine("Maximum value " + MaxValue);
//    Console.WriteLine("Minimum value " + MinValue);
//}




//Console.WriteLine(int.MinValue);
//Console.WriteLine(int.MaxValue);






using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

;
//*
// *Create a new console application.
// * Prompt the user to enter the total number of values they want to input
// * Use a loop to iterate through the numbers of values specified by the user.
// * Inside the loop, prompt the user to enter each value and store it in a variable
// * Use an if statement to compare the current value with the maximum and minimum values encountered so far.
//   (cont.) Update the maximum and minimum variables accordingly
// * After the loop ends, display the maximum and minimum values entered by the user.

//   Example:
//    Enter the total number of values: 5;
//Enter value 1: 10
//    Enter value 2: 5;
//Enter value 3: 8;
//Enter value 4: 2;
//Enter value 5: 15;

//Maximum value:15
//    Minimum value:2
// */





//int num;
//Console.WriteLine("Pls input a number");
//bool @try = int.TryParse(Console.ReadLine(), out num);



/*
Write a program that prompts the user to enter their age as a string.
The program should then use int.TryParse() to convert the input to an integer.
If the conversion is successful, the program should display a message indicating the user's
age. If the conversion fails, the program should display an error message.*/

//int num;
//string age = "24";
//Console.WriteLine("Enter Your name as a string");
//bool name = int.TryParse(age, out num);

//if (name)
//{
//    Console.WriteLine("Consversion Successfull");
//    Console.WriteLine($"Your converted age is: {num} ");
//}
//else
//{
//    Console.WriteLine("Conversion not successfull");
//}









// * Prompt the user to enter the total number of values they want to input
// * Use a loop to iterate through the numbers of values specified by the user.
// * Inside the loop, prompt the user to enter each value and store it in a variable
// * Use an if statement to compare the current value with the maximum and minimum values encountered so far.
//   (cont.) Update the maximum and minimum variables accordingly
// * After the loop ends, display the maximum and minimum values entered by the user.


Console.WriteLine("Enter the total number of value: ");
int totalValue = Convert.ToInt32(Console.ReadLine());
if (totalValue > 10)
{
    Console.WriteLine("Please re-try, and input a value below ten.");
}
else
{
    int MinValue;
    int MaxValue;

    string numOne = "-209384";
    string numTwo = "20303";

    bool testOne = int.TryParse(numOne, out MinValue);
    bool testTwo = int.TryParse(numTwo, out MaxValue);

    int maxValue = MinValue;
    int minValue = MaxValue;

    for(int i = 1; i <= totalValue; i++)
    {

        Console.WriteLine($"Enter value {i}");
        int value = Convert.ToInt32(Console.ReadLine());

        if (maxValue < value)
        {
            maxValue = value;
        }
        if (minValue > value)
        {
            minValue = value;
        }
    }
        Console.WriteLine($"The maximum value is {maxValue}");
        Console.WriteLine($"The minimum value is {minValue}");
        //int totalVal;
        //string totalSumOfNumbers = "1000";
        //bool num = int.TryParse(totalSumOfNumbers, out totalVal);


        //int ageNum;
        //string age = "34";
        //bool ages = int.TryParse(age, out ageNum);
        //if (num && ages)
        //{
        //    Console.WriteLine("You're good to go.");
        //}
        //else
        //{
        //    Console.WriteLine("Try again!!");
        //}
        //Console.WriteLine();

        //if (totalValue > 10) ;
}




//Exercise 1:
//Write a program using a while loop that counts from 1 to 10 and prints each number.
//Exercise 2:
//Write a program using a do-while loop that asks the user to enter a password until they enter the correct one.
//Exercise 3:
//Write a program using a while loop that prints all even numbers between 1 and 20.
//Exercise 4:
//Write a program using a do-while loop that asks the user to guess a number between 1 and 100 until they guess it correctly.
//Exercise 5:
//Write a program using a while loop that calculates the sum of numbers from 1 to 50.
//Exercise 6:
//Write a program using a do-while loop that asks the user to enter a series of numbers and stops when they enter a negative number.
//Exercise 7:
//Write a program using a while loop that finds the factorial of a given number entered by the user.
//Exercise 8:
//Write a program using a do-while loop that asks the user to enter a series of integers and calculates their average.
//Exercise 9:
//Write a program using a while loop that checks if a given number entered by the user is a prime number.
//Exercise 10:
//Write a program using a do-while loop that asks the user to enter a positive number and keeps asking until a valid input is given.



















//Console.WriteLine("Enter total number of values: ");
//int totalNumOfValues;
//bool test = int.TryParse(Console.ReadLine(), out totalNumOfValues);
//if (totalNumOfValues > 10)
//{
//    Console.WriteLine("Error! You cannot input a value above 10");
//}
//else
//{
//    int minValue = 3;
//    int maxValue = -10;

//    for (int i = 1; i <= totalNumOfValues; i++)
//    {
//        Console.Write($"Enter value {i}: ");
//        int value = Convert.ToInt32(Console.ReadLine());

//        if (maxValue < value)
//        {
//            maxValue = value;
//        }

//        if (minValue > value)
//        {
//            minValue = value;
//        }
//    }

//    Console.WriteLine($"Maximum value is: {maxValue}");
//    Console.WriteLine($"Minimum value is: {minValue}");
//}













Console.ReadLine();