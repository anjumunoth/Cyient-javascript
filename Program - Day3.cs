using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Shape
    {
        public int x, y, z;// fields
        static public int objectCtr;// class variable; static variable
        //public static int objectCtr;
        //static constructor
        static Shape()
        {
            objectCtr = 0;
            Console.WriteLine("Static constructor is called");
        }
         public Shape(int p1,int p2,int p3)
        {
            objectCtr++;
            x = p1;
            y = p2;
            z = p3;
            Console.WriteLine("Constructor to define a shape with 3 sides is called");
        }
        public Shape(int p1):this(p1,p1,p1)
        {
            //chaining of constructor
            Console.WriteLine("Constructor to define a cube is called");
            //x = p1;y = p1;z = p1;
        }
        public Shape(int p1,int p2):this(p1,p2,p2)
        {
            Console.WriteLine("Shape constructor with 2 equal sides");

        }

        public Shape():this(0)
        {
            //x = 0;
            //y = 0;
            //z = 0;
            Console.WriteLine("Default constructor of Shape called");
        }

        public static void displayCtrStatic()
        {
            // x=100;
            Console.WriteLine("Object Ctr:" + objectCtr);
        }
        public static int addToCtrStatic(int p1)
        {
            objectCtr += p1;
            return objectCtr;
        }
    }
    class Student
    {
        public int studId;
        public string studName;
        public float[] marks;
        public void displayMarks(float[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public Student()
        {
            studId = 0;
            studName = "";
            marks = new float[5];
            displayMarks(marks);//[0,0,0,0,0]
            marks = new float[5] { 10, 20, 30, 40, 50 };
            displayMarks(marks);//[10,20,30,40,50]

            marks = new float[5] { 10, 20, 30, 40,50 };
            displayMarks(marks);//[10,20,30,40,50]

            marks = new float[] { 10, 20, 30, 40, 50,60,70 };
            displayMarks(marks);//[10,20,30,40,50,60,70]
            Console.WriteLine(marks.Length);

            marks = new float[5];
            marks[2] = 25;
            displayMarks(marks);//[0,0,25,0,0];


        }
        //parameterised constructor
        public Student(string studName,int studId,float[] marks)
        {
            this.studName = studName;
            this.studId = studId;
            this.marks = marks;
        }
        public void calcAverage()
        {
            float average = 0,sum1=0;
            foreach (var item in marks)
            {
                //sum1 = sum1 + item;
                sum1 += item;
            }
            average = sum1 / marks.Length;
            Console.WriteLine($"Average = {Math.Round(average,2)}");
        }

        public void calcAverage(float[] weightage)
        {
            float average = 0, sum1 = 0;
            int i = 0;
            foreach (var item in marks)
            {
                //sum1 = sum1 + item;
                sum1 += (item *weightage[i]);//sum1=(100*.25)+(23*.25)+(34*.30)
                i++;
            }
            average = sum1 / marks.Length;
            Console.WriteLine($"Average = {Math.Round(average, 2)}");
        }

        private double calcAverage(float weightage)
        {
            //invoke another method inside a method
            this.calcAverage();
            return 10;
        }

        private void calcAverage(int newMark)
        {

        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            float[] marksArr = new float[] { 12, 23, 34 };
            Student stud2 = new Student("sara", 102, marksArr);
            Console.WriteLine("Student2 details");
            Console.WriteLine("Student2 details {0}",stud2.studId);
            Console.WriteLine("Student2 details : {0}",stud2.studName);
            
            stud2.marks[0] = 100;
            stud2.displayMarks(stud2.marks);
            stud1.calcAverage();
            stud2.calcAverage();
            float[] weightage = new float[] { .25f, .25f, .30f };
            // weightage taken into consideration
            Console.WriteLine("Average based on the weightage");
            stud2.calcAverage(weightage);

            //Shape s1 = new Shape(10);// 3 sides; cube
            //Console.WriteLine($"Cube sides : {s1.x} {s1.y} {s1.z} ");
            //Console.WriteLine("Number of objects:" + Shape.objectCtr);//1
            //Console.WriteLine("New shape object");
            //Shape s2 = new Shape();// 3 constructors 
            //Console.WriteLine("Number of objects:" + Shape.objectCtr);//2
            ////Console.WriteLine("Number of objects:" + s2.objectCtr);//syntactical error
            Console.WriteLine("Now only going to access the static var");
            Shape.objectCtr = 100;
            Shape.objectCtr++;
            Console.WriteLine("Number of objects:" + Shape.objectCtr);
            Shape.displayCtrStatic();

            Console.Read();
        }
    }
}

/*
 * Method overloading -- same name but different param signatures
 * different param signatures -- number or parameters or order or type of parameters
 * access modifier -- can be the same or can be different; cannot overload on basis of access modifier 
 * return data type -- can be same or can be different ; cannot overload on basis of return data type
 * Depending upon the method call, the corresponding overloaded method will be called
 * 
 */

/*
 * static variable -- all the objects of that class will share the same variable
 * Access the static variable --> className.staticvarname
 * share the data among the different objects
 * 
 * Static Constructor -- should add static modifier; should not have any access modifiers ; cannot access any non static fields within the static constructor; only initialise the static members;cannot do constructor chaining; static constructor should be parameterless; cannot overlaod a static constructor with another static constructor; will be called only once during the entire lifecycle of the application;will be called just before the first object is created or just before the static var is accessed
 * 
 * can we overload a static constructor with another static constructor -- no
 * can a static constructor be paramterised --no
 * 
 * Can a static variable be modified inside a normal constructor/method -yes
 * 
 * Static method --  a method inside a class with the static modifier, can access the static variables; can call the static method using the class method classname.staticmethodname(); it can return values or return nothing; can be parameterless or parameterised;  ususally has the various utility fucntions of that class
 * 
 * Can a static method be overloaded by a non static method
 * Can a static method be overloaded by a static method
 * Can a static method be called by an object
 * can a static method be private
 * Can a static method access a non static field
 * For a local variable can any access specifiers be added
 * For a local variable can static be added
 * 
 * How to declare a constant at the class level
 * 
 * Private constructor -- purpose -- confidential info; abstraction; no object can be created
 * List down atleast 10 static in built methods
 * 
 * 
 * Min and Max-- static methods 
 * Math.Min(10,20);
 * Math.Max(10,20);
 * 
 * CompareTo -- non static method
 * "hello".CompareTo("good");
 * 
 * 
 * 
 * 
 */


