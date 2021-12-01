using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4Examples
{
    class Shape
    {
        public int side1, side2;
        public const double PI=3.14;
        public static int Ctr;
        static Shape()
        {
            Ctr = 0;
        }
        public Shape()
        {
            Console.WriteLine("Default constructor of Shape called");
            side1 = 0;
            side2 = 0;
        }
        public Shape(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public Shape(int side1):this(side1,side1)
        {
           
        }
        public void CalcArea()
        {
            double area = side1 * side2;
            Console.WriteLine($"Area : {area}");
        }
         
        public void CalcVolume()
        {
            double volume = PI*side1*side1* side2;
            Console.WriteLine($"Volume : {volume}");
        }
        public virtual void display()
        {
            // this method can be overridden by the clild class
            Console.WriteLine($"Side 1: {side1}");
            Console.WriteLine($"Side 2: {side2}");
        }
        public override string ToString()
        {
            return $"Side 1: {side1}; Side 2: {side2}";
        }

    }

    class Cuboid : Shape
    {
        public int side3;
        // default constructor
        public Cuboid():base(0)
        {
            side3 = 100;
        }

        public Cuboid(int p1):base(p1)
        {
            side3 = p1;
            Console.WriteLine("Cube created");
        }

        public Cuboid(int p1,int p2,int p3):base(p1,p2)
        {
            side3 = p3;
            Console.WriteLine("Cuboid created");
        }

        public void CalcArea(string type1)
        {
            double area = 0;
            if(type1 =="cube")
            {
                area = side1 * side2 * side3;
            }
            else
            {
                area = side1 * side2 * side3 *PI;
            }
            Console.WriteLine($"Area : {area}");
        }

        public new void CalcVolume()
        {
            double volume = side1 * side2 * side3;
            Console.WriteLine($"Volume of cuboid :{volume}");
        }

        public void CallCalcVolume() 
        {
            CalcVolume();//Derived CalcVolume will be called -- preference to the same class CalcVolume -- same class CalcVolume is hiding the base class CalcVolume

            base.CalcVolume();// explicitly calling the base class CalcVolume
            // object of cuboid.calcVolume; side1=10, side2=20,3.14*10*10*20= 6280
            display();

        }
        public override void display()
        {
            Console.WriteLine($"Side 1: {side1}");
            Console.WriteLine($"Side 2: {side2}");
            Console.WriteLine($"Side 3: {side3}");

        }

        public override string ToString()
        {
            //Multi level inheritance between Cuboid and Object
            // This is overriding the Object's ToString() and not Shape's ToString()
            return $"Side 1: {side1}; Side 2: {side2}; Side 3: {side3}";
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Cuboid c1 = new Cuboid();
            Console.WriteLine($"Cuboid's side3: {c1.side3}");//100
            c1.side1 = 10;
            c1.side2 = 20;
            Console.WriteLine($"Cuboid's side1: {c1.side1}");//
            Console.WriteLine($"Cuboid's side2: {c1.side2}");//
            c1.CalcArea();//200 // base class calcArea is called
            c1.CalcArea("cube");//20000// derived class calcArea is called

            Console.WriteLine("PI value" + Shape.PI);
            Console.WriteLine("PI value" + Cuboid.PI);

            Shape.Ctr = 999;
            Console.WriteLine($"Ctr value {Shape.Ctr}");
            Console.WriteLine($"Ctr value {Cuboid.Ctr}");
            Cuboid.Ctr = 444;
            Console.WriteLine($"Ctr value {Shape.Ctr}");//444; 
            Console.WriteLine($"Ctr value {Cuboid.Ctr}");//444

            Shape s1 = new Shape(25,35);
            s1.CalcVolume();//CalcVolume of Shape will be called

            c1.CalcVolume();//Derived CalcVolume is hiding the base class CalcVolume();
            c1.CallCalcVolume();

            int i = 10;
            Console.WriteLine("i : " + i);// i : 10

            Console.WriteLine(i.ToString());
            Console.WriteLine(i);// this will be implicitly convert the numeric value to string

            Console.WriteLine(s1);
            // Since the toString method is overridden in the Shape class, The corresponding overridden method(in the Shape class) is only invoked when we call s1.ToString();
            // can a object of custom class Shape be converted to string implicitly -- yes
            // Shape is inheriting from Object class
            // Object class -- there is a public method called as toString()
            // So Shape will inherit the public method of the base class Object
            // s1.toString(); -- call the base class Object's toString method
            // customise the toString method -- override the toString method
            Console.WriteLine("Cuboid details" + c1);
            Console.ReadLine();
        }
    }
}

/*
 * Inheritance 
 * All the classes implicitly inherit from the Object class
 * Object class is the root class for all the classes
 * 
 * private members are not inherited
 * Public and protected members are inherited
 * Inherit some (fields, property, methods ) from the parent class
 * Base class default constructor is called implicitly within the child constructor
 * 
 * 
 * Are the constructors inherited -- no; Explicitly call the base class(parent class) constructors
 * the child class can have its own individual elements
 * 
 * Are the const members of the base class inherited -- yes
 * Are the static members of the base class inherited -- yes
 * Is overloading possible among the base class and child class -- yes 
 * 
 * Method Hiding -- 
 * --Inheritance should be there
 * -- same name and same param signature
 * -- derived class member method hides the base class member method
 * -- In the derived class method as a best practice add the new keyword
 * 
 * Overriding : 
 * 1. Inheritance
 * 2. Method with same name in both the derived and base class and they should have same parameter signature
 * 3.In the base class, the method which can be overridden should have the virtual modifier and
 * 4.In the derived class, the method which is going to be overriding, the override modifier should be added 
 * 
 * In the derived class -- how many display methods are there -- only one 
 * 
 * Access modifier
 * return data type
 * 
 */

/*
 * Assignments:
 * 1.Array methods: 7 in built methods of Array class
 * 2. Create a Book class: fields: bookId, bookName, author, price, quantity; constructors; override toString
 * 3. Create 5 objects of Book class and get the details for these books from the user
 * 4. 
 * 
 */
