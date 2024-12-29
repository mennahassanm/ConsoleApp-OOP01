namespace ConsoleApp_OOP01
{
    // Class
    // Struct 
    // Interface 
    // Enum


    internal class Program
    {
        static void Main(string[] args)
        {

            #region Struct

            // Struct : Value Types : STACK 

            // Employee 
            // Id , Name , Salary 

            // Point

            //Point P01;
            // Declare For Object From Type 'Point'
            // P01 : Object 
            // Allocate UnInitialized 8 Bytes at STACK

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01.X = 12;
            //P01.Y = 12;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01 = new Point(1, 2);

            ////new : Used For Select The Constructor

            ////Console.WriteLine(P01.X); // 0
            ////Console.WriteLine(P01.Y); // 0

            ////Console.WriteLine(P01.X); // 1
            ////Console.WriteLine(P01.Y); // 2

            ////Console.WriteLine(P01); //ConsoleApp_OOP01.Point

            ////P01.PrintPoint();

            //Console.WriteLine(P01.ToString());//ConsoleApp_OOP01.Point

            //Console.WriteLine(P01); // (1 , 2)

            #endregion

            #region OOP Overview

            // OOP : Object Oriented Programming 
            // Programming Paradigm
            // OOP : The Paradigm Use For Build Any Business

            // Class  : BluePrint Of The Object
            // Object : Specific Instance From Class

            // 4 Pillars
            //=============
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Ploymorphism  
            // 4. Abstraction 

            //object O01;

            //O01 = 1;
            //O01 = 1.5;
            //O01 = 1.5f;
            //O01 = 'A';
            //O01 = "Menna";

            #endregion

            #region 1. Encapsulation

            // 1. Encapsulation : 
            // Class Or Struct 
            // Seperate The Data (Attributes) Definition From Its Use 
            // [ Setter Getter Method - Properties ]

            // Employee
            // Id , Name , Slaray 

            // 1. End User Access Data Itself 
            // 2. No Data Validation 
            // 3. No Read Only Filed 


            // Apply Encapsulation :
            // 1. Make All Data ()
            // 2. Access Data Through :
            // 2.1. Setter Getter Method
            // 2.2. Properties 

            //Employee E01 = new Employee(1, "Menna", 50000);
            //Console.WriteLine(E01);

            //// Id : Read Only Attributes

            //E01.GetId ();

            //E01.Id = 1;
            //E01.name = "Menna";
            //E01.salary = "50000";

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);


            //E01.SetId(1);
            //E01.SetName ("Menna");
            //E01.SetSalary(-50000);

            ////Console.WriteLine(E01.GetId());
            ////Console.WriteLine(E01.GetName());
            ////Console.WriteLine(E01.GetSalaty());

            ////Console.WriteLine(E01);

            //Employee E01 = new Employee();

            //E01.Id = 12;
            //E01.Name = "Menna Hassan";
            //E01.Salary = 50000;
            //E01.Address = "Cairo";

            //Console.WriteLine(E01.Id);      // 12 
            //Console.WriteLine(E01.Name);    //  Menna Hassan
            //Console.WriteLine(E01.Salary);  // 50000
            //Console.WriteLine(E01.Address); // Cairo

            #endregion

            #region Indexer

            // Indexer : Special Property
            //          1. Name this

            // Phonebook : 

            //PhoneBook phoneBook = new PhoneBook(3);

            //phoneBook.AddPerson("Menna", 111, 0);
            //phoneBook.AddPerson("Youssef", 222, 1);
            //phoneBook.AddPerson("Ali", 333, 2);

            ////Console.WriteLine(phoneBook.GetNumber("Menna")); //111
            ////Console.WriteLine(phoneBook.GetNumber("Ahmed")); //-1

            ////phoneBook.UpdateNumber("Menna", 555);
            ////Console.WriteLine(phoneBook.GetNumber("Menna")); //555

            //Console.WriteLine(phoneBook["Menna"]); // long ==> 111

            //phoneBook["Menna"] = 555; // long

            //Console.WriteLine(phoneBook["Menna"]); // long ==> 555

            //Console.WriteLine(phoneBook[222]); // string ==> Youssef

            #endregion

            #region Class - Internal Constructor 

            //// Class : Reference Type : HEAP

            //// Car : Id Model Speed 

            //Car C01;

            //// Decaler For Refernce (Pointer) From Type 'Car'
            //// C01 : Can Refer To Object From Type 'Car' Or Any Class Inherited From Car
            //// C01 : Refer To Null 

            ////Console.WriteLine(C01);

            //// 8 Bytes Will Be Allocated At STACK For The Reference 'C01'
            //// 0 Bytes Will Be Allocated At HEAP

            ////C01 = new Car(1);
            ////C01 = new Car(1 , 200);
            //C01 = new Car(1, 200, "XYZ");



            ////new 
            //// 1. Allocate The Number Of Required Bytes At HEAP For The Object  
            //// 2. Initailized The Allocated Bytes With The Value Of The DataTypes
            //// 3. Call User-Defined Constructor If Exists
            //// 4. Assign The Object To The Reference

            ////Console.WriteLine(C01.Id);
            ////Console.WriteLine(C01.Modle);
            ////Console.WriteLine(C01.Speed);

            //Console.WriteLine(C01); // ConsoleApp_OOP01.Car 

            #endregion

        }

    }
}
