using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO.Pipelines;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Timers;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Question 01 : A junior developer wrote this code to build a commaseparated list of 5,000 product IDs:
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            //Console.WriteLine(productList);
            //Tasks:
            //(a)Explain why this code is inefficient.Reference what happens in
            //memory.
            //(b) Rewrite this code using StringBuilder to be more efficient.
            //(c) Add timing code(using Stopwatch) to both versions and report
            //the time difference.
            //===============================
            // A : this code is inefficient because he use string in loop and is immutable and in locatin with every iteration
            //the string is created a new string in memory and garbage collector will delete the okd string
            // B : 
            //StringBuilder productList = new StringBuilder("");
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList.Append("PROD-" + i + ",");
            //}
            // C : a take 3.5 seconds and b take 0.01 seconds
            #endregion

            #region Question 2            
            //Write a program for a cinema ticket pricing system with these rules:
            //Condition Price
            //Age < 5 Free
            //Age 5 - 12 30 LE
            //Age 13 - 59 50 LE
            //Age 60 + 25 LE
            //Weekend(Fri / Sat) Add 10 EGP to any non - free ticket
            //Student with valid ID 20 % discount(applied after weekend surcharge)
            //Tasks:
            //(a)Implement using if-else if-else statements
            //(b) The program should ask for: age, day of week(1 - 7, where
            //6 = Fri, 7 = Sat), and whether they have a student ID(yes / no)
            //(c) Display the final price with a breakdown of how it was calculated


            //================================
            //int age;
            //Console.WriteLine("please enter your age : ");
            //int.TryParse(Console.ReadLine(), out age);
            //double price = 0;
            //Console.WriteLine("please enter the day");
            //string day = Console.ReadLine()!;
            //Console.WriteLine("are you student ?  yes : no ");
            //string student = Console.ReadLine()!;
            //if (age< 5)
            //{
            //    Console.WriteLine($"your age is : {age} so your ticket is free");
            //}
            //else if(age >=5 && age <= 12)
            //{
            //    price = 30;
            //    if (day == "friday" || day == "saturday")
            //    {
            //        price += 10;
            //        Console.WriteLine($"the day is {day} so the price incress 10 EGP");
            //    }
            //    if (student.ToLower() == "yes")
            //    {
            //        price = price - ((price*20)/100);
            //        Console.WriteLine("you are a student so tou have discount by 20%");
            //    }
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    price = 50;
            //    if (day == "friday" || day == "saturday")
            //    {
            //        price += 10;
            //        Console.WriteLine($"the day is {day} so the price incress 10 EGP");
            //    }
            //    if (student.ToLower() == "yes")
            //    {
            //        price = price - ((price * 20) / 100);
            //        Console.WriteLine("you are a student so tou have discount by 20%");
            //    }
            //}
            //else if (age >= 60)
            //{
            //    price = 25;
            //    if (day == "friday" || day == "saturday")
            //    {
            //        price += 10;
            //        Console.WriteLine($"the day is {day} so the price incress 10 EGP");
            //    }
            //    if (student.ToLower() == "yes")
            //    {
            //        price = price - ((price * 20) / 100);
            //        Console.WriteLine("you are a student so tou have discount by 20%");
            //    }
            //}
            //Console.WriteLine($"your ticket's price = {price}");

            #endregion

            #region Question 3
            //(a)A traditional switch statement
            //(b) A switch expression
            //string fileExtension = ".pdf";
            //string fileType;
            //if (fileExtension == ".pdf")
            //    fileType = "PDF Document";
            //else if (fileExtension == ".docx" || fileExtension == ".doc")
            //    fileType = "Word Document";
            //else if (fileExtension == ".xlsx" || fileExtension == ".xls")
            //    fileType = "Excel Spreadsheet";
            //else if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".gif")
            //    fileType = "Image File";
            //else
            //    fileType = "Unknown File Type";
            //===========================================
            string fileExtension = ".pdf";
            string fileType;
            //switch (fileExtension)
            //    {
            //    case ".pdf":
            //        fileType = "PDF Document"; ;
            //        break;
            //    case ".docx":
            //    case ".doc":
            //        fileType = "Word Document";
            //        break;
            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;
            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}
            // B : 
            //fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //};
            #endregion

            #region Question 4
            //Rewrite the following using only ternary operators (no if statements):
            //int temperature = 35;
            //string weatherAdvice;
            //if (temperature < 0)
            //    weatherAdvice = "Freezing! Stay indoors.";
            //else if (temperature < 15)
            //    weatherAdvice = "Cold. Wear a jacket.";
            //else if (temperature < 25)
            //    weatherAdvice = "Pleasant weather.";
            //else if (temperature < 35)
            //    weatherAdvice = "Warm. Stay hydrated.";
            //else
            //    weatherAdvice = "Hot! Avoid sun exposure.";
            //====================================

            //weatherAdvice = temperature < 0 ? "Freezing! Stay indoors." :
            //                temperature < 15 ? "Cold. Wear a jacket." :
            //                temperature < 25 ? "Pleasant weather." :
            //                temperature < 35 ? "Warm. Stay hydrated." :
            //                "Hot! Avoid sun exposure.";

            // in this case is not more readable use if in nested if condation
            #endregion

            #region Q5 
            //Create a password validation program with these requirements:
            //Password Rules:
            //● Minimum 8 characters
            //● At least one uppercase letter
            //● At least one digit
            //● No spaces allowed
            //Program Behavior:
            //● Use a do -while loop to keep asking until a valid password is
            //entered
            //● After each invalid attempt, tell the user which specific rules they
            //violated
            //● Limit attempts to 5.After 5 failed attempts, display "Account
            //locked" and exit
            //● On success, display "Password accepted!"
            //Hint: Use foreach to iterate through characters and check conditions.

            //================================
            // مش لازم  for each 

            //bool flag = false;
            //int counter = 1;
            //do
            //{
            //    bool istrue = false;
            //    Console.WriteLine("please enter a valid password");
            //    string password = Console.ReadLine()!;
            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("password must have Minimum 8 characters");
            //    }
            //    for (int i = 0; i < password.Length; i++)
            //    {
            //        if (password[i] == password.ToUpper()[i])
            //        {
            //            istrue = true;
            //            flag = false;
            //        }
            //    }
            //    if (istrue == false)
            //    {
            //        Console.WriteLine("the password must have At least one uppercase letter");
            //        flag = true;
            //    }
            //    istrue = false;
            //    for (int i = 0; i < password.Length; i++)
            //    {
            //        if (password[i] == '1' || password[i] == '2' || password[i] == '3' || password[i] == '4' || password[i] == '5' ||
            //            password[i] == '6' || password[i] == '7' || password[i] == '8' || password[i] == '9' || password[i] == '0')
            //        {
            //            istrue = true;
            //            flag = false;
            //        }
            //    }
            //    if (istrue == false)
            //    {
            //        Console.WriteLine("the password must have At least one digit");
            //        flag = true;
            //    }
            //    istrue = true;
            //    for (int i = 0; i < password.Length - 2; i++)
            //    {
            //        if (password[i] == ' ')
            //        {
            //            istrue = false;
            //            flag = true;
            //        }
            //    }
            //    if (istrue == false)
            //    {
            //        Console.WriteLine("No spaces allowed");

            //    }
            //    if (flag == false)
            //    {
            //        Console.WriteLine("Password accepted!");
            //    }
            //    if (counter == 5)
            //    {
            //        Console.WriteLine("Account locked");
            //        break;
            //    }
            //    else
            //    {
            //        counter++;
            //    }
            //}
            //while (flag);


            #endregion

            #region Q6
            //Given an array of exam scores:
            //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };
            //Using loops(your choice of for, foreach, while), write code to:
            //(a)Find and display all failing scores(below 50)
            //(b) Find the first score above 90 and stop searching immediately
            //(c) Calculate the class average, excluding any scores below 40
            //(considered absent)
            //(d) Count how many students scored in each grade range:
            //○ A: 90-100
            //○ B: 80-89
            //○ C: 70-79
            //○ D: 60-69
            //○ F: Below 60

            //================================

            // A :
            //foreach (var item in scores)
            //{
            //    if (item < 50)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //// B :
            //foreach (var item in scores)
            //{
            //    if (item < 90)
            //    {
            //        Console.WriteLine(item);
            //        break;
            //    }
            //}

            //// C :
            //int sum = 0;
            //int count = 0;
            //int average = 0;
            //for (int i =0; i < scores.Length; i++)
            //{
            //    if (scores[i] > 40)
            //    {
            //        sum += scores[i];
            //        count++;
            //    }
            //}
            //average = sum / count;
            //Console.WriteLine(average);

            //// D :
            //int countA = 0;
            //int countB = 0;
            //int countC = 0;
            //int countD = 0;
            //int countF = 0;
            //for(int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] >= 90 && scores[i] <= 100)
            //    {
            //        countA++;
            //    }
            //    else if (scores[i] >= 80 && scores[i] <= 89)
            //    {
            //        countB++;
            //    }
            //    else if (scores[i] >= 70 && scores[i] <= 79)
            //    {
            //        countC++;
            //    }
            //    else if (scores[i] >= 60 && scores[i] <= 69)
            //    {
            //        countD++;
            //    }
            //    else if (scores[i] < 60)
            //    {
            //        countF++;
            //    }
            //}


            #endregion
        }
    }
}
