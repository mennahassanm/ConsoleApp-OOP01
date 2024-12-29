﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_OOP01
{
    internal struct Employee
    {
        private int id;
        private string name; // NULL
        private double salary;
        //private string address;
        // Address






        #region Apply Encapsulation User Setter Getter Method

        //// Apply Encapsulation User Setter Getter Method


        //// Setter Id
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //// Getter Id 
        //public int GetId ()
        //{
        //    return id;
        //}

        //// Setter Name
        //public void SetName(string name)
        //{
        //    if (name.Length >= 8 && name.Length <= 20) 
        //    this.name = name;
        //}

        //// Getter Name 
        //public string GetName()
        //{
        //    return name;
        //}

        //// Setter Salary
        //public void SetSalary(double salary)
        //{
        //    if (salary > 0) 
        //    this.salary = salary;
        //}

        //// Getter Salary 
        //public double GetSalaty()
        //{
        //    return salary;
        //}

        #endregion


        // Apply Encapsulation User Properties : [Recommended]
        // 1. Full Property


        //Id

        //public int Id
        //        {
        //            // set
        //            // get

        //            set
        //            {
        //                id = value;
        //            }

        //            get
        //            {
        //                return id;
        //            }

        //        }

        //// Name 

        //public string Name
        //{
        //    // set
        //    // get

        //    set
        //    {
        //        if (value.Length >= 8 && value.Length <= 20)
        //            name = value;
        //    }

        //    get
        //    {
        //        return name;
        //    }

        //}

        //// Salary 

        //public double Salary
        //{
        //    // set
        //    // get

        //    set
        //    {
        //        if (value > 0)
        //            salary = value;
        //    }

        //    get
        //    {
        //        return salary;
        //    }

        //}

        // Address

        //public string Address
        //{
        //    // set
        //    // get

        //    set
        //    {
        //            address = value;
        //    }

        //    get
        //    {
        //        return address;
        //    }

        //}


        // 2. Automatic Property
         
        public string Address { set; get; }

        // 3. Special Property [Indexer]



        //public Employee (int Id , string Name , double Salary)
        //{
        //   //SetId(Id);
        //    SetName(Name);
        //    SetSalary(Salary);
        //}

        //public override string ToString()
        //{
        //    return $"Id : {id} :: Name : {name} :: Salary : {salary} ";
        //}

    }
}
