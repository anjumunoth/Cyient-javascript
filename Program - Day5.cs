using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDay5
{
    class Address
    {
        int houseNo, pincode;
        string streetName, city, area;
        public Address(int houseNo, int pincode, string streetName, string city, string area)
        {
            this.houseNo = houseNo;
            this.pincode = pincode;
            this.streetName = streetName;
            this.city = city;
            this.area = area;
        }
        public override string ToString()
        {
            return $"HouseNo: {houseNo},Pincode : {pincode}, StreetName: {streetName},city:{city}, Area:{area}";
        }
    }
    class Author
    {
        int authorId;
        string authorName;
        Address addressDetails;

        public Author(int authorId, string authorName, Address addressDetails)
        {
            this.authorId = authorId;
            this.authorName = authorName;
            this.addressDetails = addressDetails;
        }

        public override string ToString()
        {
            return $"Author Name : {authorName}; AuthorId: {authorId}; Address: {addressDetails}";
        }
    }
    class Employee
    {
        int empId;
        public string empName;
        float salary;

        public Employee(int empId, string empName, float salary)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
        }
        public Employee(Employee obj)
        {
            this.empName = obj.empName;
            this.empId = obj.empId;
            this.salary = obj.salary;
        }

        public override string ToString()
        {
            return $"Employee Id : {empId}; EmpName : {empName}, Salary : {salary}";
        }
        // overload + operator to add 2 employees
        public static Employee operator+(Employee e1,Employee e2)
        {
            Employee temp = new Employee(e1);
            temp.salary += e2.salary;
            return temp;
        }
    }
    class Program
    {
        static void displayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] marks = new int[5] { 10, 20, 30, 40, 50 };
            int[] marks2 = marks;// reference
            marks2[0] = 100;
            Console.WriteLine("Marks Array");
            displayArray(marks);

            int[] copy1 = new int[marks.Length];
            Array.Copy(marks, copy1, marks.Length);
            Console.WriteLine("Marks Array");
            displayArray(marks);
            Console.WriteLine("Marks Array - Copy1 ");
            displayArray(copy1);

            // Second way of copying -- copy some of the elements
            int[] copy2 = new int[marks.Length];
            Array.Copy(marks, copy2, marks.Length-2);
            Console.WriteLine("Marks Array");
            displayArray(marks);
            Console.WriteLine("Marks Array - Copy2 ");
            displayArray(copy2);

            // Third way of copying -- copy some and place it at a particular location
            int[] copy3 = new int[10];
            Array.Copy(marks,2, copy3,4, 2);
            Console.WriteLine("Marks Array");
            displayArray(marks);
            Console.WriteLine("Marks Array - Copy3 ");
            displayArray(copy3);//[0,0,0,0,0,30,40,0,0,0]

            //int[] copy4 = new int[10];
            //Array.Copy(marks, 3, copy4, 2, 3);// ArgumentException
            //Console.WriteLine("Marks Array");
            //displayArray(marks);
            //Console.WriteLine("Marks Array - Copy4 ");
            //displayArray(copy4);//[0,0,40,50,0,0,0,0,0,0]

            float[] copy5 = new float[10];
            Array.Copy(marks, 2, copy5, 6, 2);
            Console.WriteLine("Marks Array");
            displayArray(marks);
            Console.WriteLine("Marks Array - Copy5 ");
            foreach (var item in copy5)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine();//[0,0,0,0,0,0,30,40,0,0]


            //string[] copy6 = new string[10];
            //Array.Copy(marks, 2, copy6, 6, 2);// Type Mismatch exception
            //Console.WriteLine("Marks Array");
            //displayArray(marks);
            //Console.WriteLine("Marks Array - Copy6 ");
            //foreach (var item in copy6)
            //{
            //    Console.Write(item + " , ");
            //}
            Console.WriteLine();//[]

            // Array of objects;
            int[] arr1 = new int[5];// get automatically initialised
            displayArray(arr1);//[0,0,0,0,0]
            // declared an array of objects
            Employee[] empArr = new Employee[3];// will not get automatically initialised
            // initialise the array of objects
            for(int i=0;i<empArr.Length;i++)
            {
                Console.WriteLine("Enter the name");
                string empName = Console.ReadLine();
                Console.WriteLine("Enter the salary");
                float salary;
                bool result=Single.TryParse(Console.ReadLine(),out salary);
                if(result)
                {
                    empArr[i] = new Employee(i+1, empName, salary);
                }
            }
            Console.WriteLine("Before sorting");
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine(empArr[i]);
            }
            //Array.Sort(empArr);// InvalidOperationException 
            Console.WriteLine("After sorting");
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine(empArr[i]);
            }

            int i1 = 10;
            int j1 = i1;
            Console.WriteLine(j1);//10

            Employee emp1 = new Employee(101, "sara", 678);
            Employee emp2 = emp1;// reference
            Console.WriteLine("Employee 2 details" + emp2);//101,sara,678
            Console.WriteLine("Employee 1 details" + emp1);// 101, sara, 678
            emp2.empName = "priyanka";
            Console.WriteLine("Employee details after changing emp2");
            Console.WriteLine("Employee 2 details" + emp2);//101,priyanka,678
            Console.WriteLine("Employee 1 details" + emp1);// 101,priyanka, 678

            // copy an object into another object
            // constructors -- default, parameterised , static, copy constructor
            Employee emp3 = new Employee(emp1);
            Console.WriteLine("Employee 3 details" + emp3);//101,priyanka,678
            Console.WriteLine("Employee 1 details" + emp1);// 101,priyanka, 678
            emp3.empName = "Jack";
            Console.WriteLine("Employee details after changing emp3");
            Console.WriteLine("Employee 3 details" + emp3);//101,Jack,678
            Console.WriteLine("Employee 1 details" + emp1);// 101,priyanka, 678

            i1 = 20;j1 = 30;
            if(i1<j1)
            {
                Console.WriteLine("i1 is lesser than j1");
            }
            else
            {
                Console.WriteLine("i1 is greater than j1");
            }

            Employee emp4 = emp1 + emp3;// operator +(emp1,emp3);
            Console.WriteLine("Employee 4 details"+emp4);// 101,Priyanka,1356
            Address addressObj1 = new Address(23, 600017, "ramanujam street", "Chennai", "T.Nagar");
            Author a1 = new Author(101, "Paul Coelho", addressObj1);
            Console.WriteLine(a1);
            Console.Read();

        }
    }
}


/*
 * Limitations of an array:
 * 1. Array is always of a fixed size
 * 2. All the elements have the same data type
 * 3. Adding or removing an element is difficult
 * 
 * To overcome these limitations -- collections 
 * Collections -- Generic collections and non-generic collections
 * Inheritance - IS A relationship
 * HAS A relationship -- Author has an address
 */

/*
 *Assignments
 *1. Return an array which has all the positions of the search element in the given int array
 *No normal for loop; make maximum usage of inbuilt functions
 *int arr1=[10,20,30,10,20,34,20];
 *int[] res=FindAllPos(arr1,10);//[0,3];
 *res=FindAllPos(arr1,20);//[1,4,6];
 *res=FindAllPos(arr1,100);//[];
 *
 * Declare an array of objects of employee class
 *2. Employee emp=Find(empArr,103);//emp will hold the empDetails of employee for whom the employee Id is 103;
 *Employee emp=Find(empArr,999);//emp should be null ;999 is not there as any empId
 *
 *3.
 *Employee empArr1=FindEmpIdBySalary(empArr,234);//all the employees will hold the empDetails of employee for whom the salary is 234;
 *
 *
 */