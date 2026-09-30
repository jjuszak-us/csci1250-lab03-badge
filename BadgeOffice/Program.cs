/*
*Name: Joseph Juszak
*Course: CSCI 1250 Section 001
*Assignment: Lab 2, Trip Calculator
*Date: September 30, 2026
*Description: A school ID badge generator
*/

using System.Diagnostics;
Console.WriteLine("===== Part One =====");
string fullName, firstName, lastName;

Console.WriteLine("What is your full name? (Only give first and last name please) ");
fullName = Console.ReadLine();


fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
firstName = fullName.Substring(0, spacePosition);
lastName = fullName.Substring(spacePosition + 1);

string firstNameFinal = firstName.ToUpper();
string lastNameFinal = lastName.ToUpper();

string username;
char firstChar;
firstChar = firstName[0];

username = (firstChar + lastName).ToLower();

char lastChar;
lastChar = lastName[0];

char upperFN = char.ToUpper(firstChar);
char upperLN = char.ToUpper(lastChar);

Console.WriteLine($"Name on badge:{firstNameFinal} {lastNameFinal}");
Console.WriteLine($"Username is: {username} ");
Console.WriteLine($"Initials are: {upperFN}.{upperLN}. ");
Console.WriteLine($"Letters in last name are: {lastName.Length}");

Console.WriteLine("===== Part Two =====");



