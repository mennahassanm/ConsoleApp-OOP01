using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Xml.Linq;
using Assignment_OOP01;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Q1

            //1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates
            //the distance between them.

            //Console.Write("Enter Cordintaes For Point 1 : ");
            //var P1 = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            //Console.Write("Enter Cordintaes For Point 2 : ");
            //var P2 = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            //Console.Write($"The Distance Between The Two Point Is : {P1.Distance (P2)} ");

            //Enter Cordintaes For Point 1 : 500
            //141
            //Enter Cordintaes For Point 2 : 415
            //56
            //The Distance Between The Two Point Is: 120.20815280171308

            #endregion

            #region Q2

            //2.Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user
            //and displays the name and age of the oldest person.

            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    int age;
            //    while (true)
            //    {
            //        Console.Write("Age: ");
            //        if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid age. Please enter a non-negative integer.");
            //        }
            //    }
            //    persons[i] = new Person(name, age);
            //}
            //Person oldestPerson = persons[0];
            //foreach (var person in persons)
            //{
            //    if (person.Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person;
            //    }
            //}
            //Console.WriteLine($"The oldest person is : {oldestPerson.Name}, Age : {oldestPerson.Age}");

            //Enter details for person 1:
            //Name: Menna
            //Age: 21
            //Enter details for person 2:
            //Name: Youssef
            //Age: 23
            //Enter details for person 3:
            //Name: Malak
            //Age: 7
            //The oldest person is : Youssef, Age : 23

            #endregion

            #endregion

            #region Part 02

            #region Q1

            //1.Design and implement a Class for the employees in a company:
            //Notes:
            //    Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //    We need to restrict the Gender field to be only M or F[Male or Female]
            //    Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //    We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [Use String.Format() Function].

            //try
            //{
            //    Employee employee = new Employee(
            //        id: 1,
            //        name: "Menna Hassan",
            //        gender: "F",
            //        securityLevel: SecurityLevel.Developer,
            //        salary: 50000,
            //        hireDate: new DateTime(2020, 2, 4)
            //    );

            //    Console.WriteLine(employee.ToString());
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine($"Error: {E.Message}");
            //}

            //Employee ID: 1
            //Name: Menna Hassan
            //Gender: Female
            //Security Level: Developer
            //Salary: $50,000.00
            //Hire Date: February 04, 2020

            #endregion

            #region Q2

            //2.Develop a Class to represent the Hiring Date Data:
            //Consisting of fields to hold the day, month and Years.

            //try
            //{
            //    HiringDate hireDate = new HiringDate(4, 2, 2020);

            //    Console.WriteLine($"Hire Date: {hireDate.ToString()}");

            //    DateTime dateTime = hireDate.ToDateTime();
            //    Console.WriteLine($"DateTime Representation: {dateTime:MMMM , dd, yyyy}");
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine($"Error: {E.Message}");
            //}

            //Hire Date: 04 / 02 / 2020
            //DateTime Representation: February , 04, 2020

            #endregion

            #region Q3

            //3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Notes:
            //    Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //    Define all the Necessary Constructors for the Class
            //    Allow NO RUNTIME errors if the user inputs any data
            //    Write down all the necessary Properties(Instead of setters and getters)

            //try
            //{
            //    Employee[] EmpArr = new Employee[3];

            //    EmpArr[0] = new Employee(
            //        id: 1,
            //        name: "Menna",
            //        gender: "F",
            //        securityLevel: SecurityLevel.DBA,
            //        salary: 50000,
            //        hireDate: new DateTime(2020, 2, 4)
            //    );

            //    EmpArr[1] = new Employee(
            //        id: 2,
            //        name: "Youssef",
            //        gender: "M",
            //        securityLevel: SecurityLevel.Guest,
            //        salary: 50000,
            //        hireDate: new DateTime(2021, 3, 4)
            //    );

            //    EmpArr[2] = new Employee(
            //        id: 3,
            //        name: "Ahmed",
            //        gender: "M",
            //        securityLevel: SecurityLevel.SecurityOfficer,
            //        salary: 40000,
            //        hireDate: new DateTime(2022, 4, 4)
            //    );

            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp.ToString());
            //        Console.WriteLine("=============================");
            //    }
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine($"Error: {E.Message}");
            //}

            //Employee ID: 1
            //Name: Menna
            //Gender: Female
            //Security Level: DBA
            //Salary: $50,000.00
            //Hire Date: February 04, 2020
            //=============================
            //Employee ID: 2
            //Name: Youssef
            //Gender: Male
            //Security Level: Guest
            //Salary: $50,000.00
            //Hire Date: March 04, 2021
            //=============================
            //Employee ID: 3
            //Name: Ahmed
            //Gender: Male
            //Security Level: SecurityOfficer
            //Salary: $40,000.00
            //Hire Date: April 04, 2022
            //=============================

            #endregion

            #region Q4

            //4.Sort the employees based on their hire date then Print the sorted array.
            //While sorting(how many times Boxing and Unboxing process has occurred)

            //try
            //{
            //    Employee[] EmpArr = new Employee[3];

            //    EmpArr[0] = new Employee(
            //        id: 1,
            //        name: "Menna",
            //        gender: "F",
            //        securityLevel: SecurityLevel.DBA,
            //        salary: 50000,
            //        hireDate: new DateTime(2022, 2, 4)
            //    );

            //    EmpArr[1] = new Employee(
            //        id: 2,
            //        name: "Youssef",
            //        gender: "M",
            //        securityLevel: SecurityLevel.Guest,
            //        salary: 50000,
            //        hireDate: new DateTime(2019, 3, 4)
            //    );

            //    EmpArr[2] = new Employee(
            //        id: 3,
            //        name: "Ahmed",
            //        gender: "M",
            //        securityLevel: SecurityLevel.SecurityOfficer,
            //        salary: 40000,
            //        hireDate: new DateTime(2017, 4, 4)
            //    );

            //    int boxingUnboxingCount = 0;
            //    Array.Sort(EmpArr, (x, y) =>
            //    {
            //        boxingUnboxingCount += 2;
            //        return x.HireDate.CompareTo(y.HireDate);
            //    });

            //    Console.WriteLine("Sorted Employees by Hire Date:");
            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp.ToString());
            //        Console.WriteLine("=============================");
            //    }

            //    Console.WriteLine($"Total Boxing and Unboxing Operations: {boxingUnboxingCount}");
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine($"Error: {E.Message}");
            //}

            //Sorted Employees by Hire Date:
            //Employee ID: 3
            //Name: Ahmed
            //Gender: Male
            //Security Level: SecurityOfficer
            //Salary: $40,000.00
            //Hire Date: April 04, 2017
            //=============================
            //Employee ID: 2
            //Name: Youssef
            //Gender: Male
            //Security Level: Guest
            //Salary: $50,000.00
            //Hire Date: March 04, 2019
            //=============================
            //Employee ID: 1
            //Name: Menna
            //Gender: Female
            //Security Level: DBA
            //Salary: $50,000.00
            //Hire Date: February 04, 2022
            //=============================
            //Total Boxing and Unboxing Operations: 6

            #endregion

            #endregion

        }
    }
}
