using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Examples
{
    class Employee
    {
        int empId;
        public string empName;
        protected double salary;
        public Employee() 
        {
            empId = -1;
            empName = " NA";
            salary = 0;
            
        }

        public Employee(int empId,string empName,double salary)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
        }

        
        public Employee(int empId, double salary)
        {
            Console.WriteLine("public Employee(int empId,double salary)");
            this.empId = empId;
            this.salary = salary;
            
        }
        public Employee(double salary,int empId)
        {
            Console.WriteLine("public Employee(double salary,int empId)");
            this.empId = empId;
            this.empName = "";
            this.salary = salary;
        }
        //public Employee(int empId, int salary)
        //{
        //    Console.WriteLine("public Employee(int empId,int salary)");
        //    this.empId = empId;
        //    this.empName = "";
        //    this.salary = salary;
        //}
        public Employee(int empId, long salary)
        {
            Console.WriteLine("public Employee(int empId,long salary)");
            this.empId = empId;
            this.empName = "";
            this.salary = salary;
            
        }
        public Employee(long empId, int salary)
        {
            Console.WriteLine("public Employee(long empId,int salary)");
            this.empId = (int)empId;
            this.empName = "";
            this.salary = salary;
        }


        public void Display()
        {
            //empName is equiavalent this.empName
            // this -- refer to object on which the function has been called
            Console.WriteLine($"EmpId : {empId}");
            Console.WriteLine($"EmpName : {empName}");
            Console.WriteLine($"Salary : {salary}");
        }
        // constructor -- initialise the data 
    }

    class Student
    {
        int studId;
        string studName;
        int[] marks;
    }
    class Program
    {
       static void Main(string[] args)
        {
            Employee emp1 = new Employee();// calling the function - constructor
            //Console.WriteLine($"Emp Id : {mary.empId}");
            emp1.empName = "Mary";
            //emp1.salary = 678;
            emp1.Display();
            Console.WriteLine("Employee 2 details");
            Employee emp2 = new Employee(101, "sara", 567);
            emp2.Display();// 101, sara 567
           // Employee emp3 = new Employee(100, 100);//public Employee(int empId,int salary)
            Employee emp4 = new Employee(100, 100.56);//public Employee(int empId,double salary)
            short s1 = 100, s2 = 100;
            //Employee emp5 = new Employee(s1, s2);//public Employee(int empId,int salary)
            int i = 100;
            long l = 200;
            Employee emp6 = new Employee(i,l);//public Employee(int empId,long salary)
            //Employee emp7 = new Employee(s1,s2);//compilation error -- ambiguous calls

            Employee emp8 = new Employee(100, 100.56);//emp8 will not have empName
            Console.WriteLine(emp8.empName);//null
            Console.Read();
        }
    }
}

/*
 * constructor -- special member function
 * -- Will have the same name as the class name
 * -- can have multiple constructors for the same class
 * -- will not return anything explicitly
 * -- will not mention the return data type
 * 
 * If there is no constructor, the CLR will inject the built in default constructor(constructor with no args) and execute it and it will initialise the various fields in the class  with the default valus based on their types
 * default access modifier -- private
 * private access modifier -- only accessible within the class
 * public access modifier -- accessible in the entire namespace
 * protected access modifier -- accessible within the class, derived classes
 */

/*
 * Abstraction -- hiding the irrelevant details and show only the relevant details
 * Encapsulation -- Logical collection under a single name
 * Polymorphism -- multiple behaviour of the same object
 * Inheritance -- inherit some of the charactersticks from the parent; can also have individual charactersticks
 * 
 * .net -- Object oriented language - OOP
 * 1. class -- blue print of an entity
 * 2. object -- store the data about the entity; instance of the class; data; behaviour of entity
 * 4 pillars of OOPs
 * abstraction -- access modifiers 
 * encapsulation -- by the definition of the class 
 * polymorphism -- constructor overloading; function overloading, overriding
 * inheritance -- single, multi level inheritance , multiple (not supported)
 * 
 * Overloading -- parameter list should be different -- number of parameters or order of parameters or type of parameters
 * 
 * 1. look for an exact match
 * 2. look for the nearest type which it can type cast to( no ambiguity)
 * 
 * 
 * 
 */


/*
 * 1. What does a constructor return; overloaded constructors
 * 2. 10 inbuilt functions for the string data type
 * 3. 5 inbuilt functions for numeric data type
 */