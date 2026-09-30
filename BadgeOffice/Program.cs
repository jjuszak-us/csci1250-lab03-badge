/*
*Name: Joseph Juszak
*Course: CSCI 1250 Section 001
*Assignment: Lab 2, Trip Calculator
*Date: September 30, 2026
*Description: Builds a student badge from a name, two random assignments, and the walking distance to a first class.
*/

// using System.Diagnostics;
// Console.WriteLine("===== Part One =====");
// //the initial user name entry and formatting for badge 

// string fullName, firstName, lastName;

// Console.WriteLine("What is your full name? (Only give first and last name please) ");
// fullName = Console.ReadLine();


// fullName = fullName.Trim();
// int spacePosition = fullName.IndexOf(" ");
// firstName = fullName.Substring(0, spacePosition);
// lastName = fullName.Substring(spacePosition + 1);

// string firstNameFinal = firstName.ToUpper();
// string lastNameFinal = lastName.ToUpper();

// string username;
// char firstChar;
// firstChar = firstName[0];

// username = (firstChar + lastName).ToLower();

// char lastChar;
// lastChar = lastName[0];

// char upperFN = char.ToUpper(firstChar);
// char upperLN = char.ToUpper(lastChar);

// Console.WriteLine($"Name on badge:{firstNameFinal} {lastNameFinal}");
// Console.WriteLine($"Username is: {username} ");
// Console.WriteLine($"Initials are: {upperFN}.{upperLN}. ");
// Console.WriteLine($"Letters in last name are: {lastName.Length}");


// Console.WriteLine("===== Part Two =====");
// //assigns the student an ID number and locker number

// Random rnd = new Random();

// int userID = rnd.Next(100000, 1000000);

// int lockerID = rnd.Next(1, 501);

// Console.WriteLine($"Your student ID number is : {userID} ");
// Console.WriteLine($"Your locker number is: {lockerID} ");


Console.WriteLine("===== Part 3 =====");
//calculates how far a student has to walk to their first class as well as how long it will tkae them to arrive
double x1, y1, x2, y2, xTemp, yTemp, distance;

Console.WriteLine("What are your dorms cooridinates? ");
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What are your first class' coordinates? ");
x2 = Convert.ToDouble(Console.ReadLine());
y2 = Convert.ToDouble(Console.ReadLine());

xTemp = (x2 - x1);
yTemp = (y2 - y1);

distance = Math.Sqrt(Math.Pow(xTemp, 2) + Math.Pow(yTemp, 2));

Console.WriteLine("What is your walking spped in feet per minute? ");
double speed = Convert.ToDouble(Console.ReadLine());

double minutes = Math.Floor(((distance / speed)) /60); 
double seconds = Math.Floor((distance % speed) * 10);

Console.WriteLine($"Distance: {distance.ToString("F1")} feet");
Console.WriteLine($"Walk Time: {minutes} minutes {seconds} seconds ");


Console.WriteLine("===== Part Four =====");




