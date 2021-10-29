// declare variables -- var, let, const
// const -- value cant be changed once assigned
// var -- function scope
// let -- cant redeclare it in the same scope; block scope

var i=10;
var i=20;
let j=20;
//let j=30;// error
// weakly typed language
i=10;// number
i="hello";//string
i='c';//string
i="g";//string
i='hello'
i=true;// boolean
i=10.5;// number 


//type inference
var num1=10;
console.log(num1);//10
var num2;
console.log("Num2 : "+num2);//undefined 
//console.log(num4);//reference error 
console.log("Num3 :"+num3);//;undefined
var num3;// declaration hoisting

console.log("Num5 :"+num5);// ud; 
var num5=1000;// declarations hoisting


//array data type -- collection of values 
var arr1=[1,2,3,4,5];
var arr2=[1,"geeta",true];
console.log("Array 1",arr1);
console.log("Array 1: "+arr1);
console.log("First element",arr1[0]);
for(let k=0;k<arr1.length;k++)
{
    console.log(arr1[k]);
}
for(let index in arr1)
{
    console.log(arr1[index]);
}
for(let item of arr1)
{
    console.log(item);
}

//es2015
//arr1.forEach()

// objects
var emp={empId:101,empName:"sara",salary:5678};
console.log("Employee details",emp);
emp.empId=999;
console.log("Employee Id ",emp.empId);
emp["empName"]="ganga";
console.log("Employee Name ",emp.empName);
var fieldName="salary";
emp[fieldName]=1000;// change the salary to 1000
console.log("Employee Salary ",emp.salary);
emp.deptId="d1";// add a new field called as deptId
emp.fieldName=2000;//add a new field called as fieldName;
emp["location"]="bangalore";
console.log("Object after changes",emp);

const PI=3.14;
//PI=3.1423;// error

const obj1={empId:101,empName:"sara"};
obj1.empId=1000;
console.log("Obj1",obj1);//{1000,"sara"}
//obj1={empId:102,empName:"danny"};//error
obj1.salary=567;
console.log("Obj1",obj1);//
console.log("bye");

var arr=[10,20,30,40,50];
var arr1=arr;// reference
arr1[0]=1000;
console.log("Arr : ",arr);//[10,20,30,40,50];[1000,20,30,40,50]
console.log("Arr1: ",arr1);//[1000,20,30,40,50]

// Copy of an array -- write the code for it -- multiple ways

var emp1={empId:101,empName:"sara"};
var emp2=emp1;// reference 
emp2.empId=777;
console.log("Emp1",emp1);//{empId:777,empName:"sara"};
console.log("Emp2",emp2);//{empId:777,empName:"sara"};

// Copy of an object

// functions

function myFunc1(p1,p2)
{
    //console.log("Sum of p1: "+p1+" and p2: "+p2 + "is" +(p1+p2));
    console.log(`Sum of p1: ${p1} and p2: ${p2} is ${p1+p2}`)
}

myFunc1(10,20);// 30

myFunc1(10,"hello");//"10hello"; 
myFunc1(10,"20");//"1020" 
myFunc1("10","hello");//"10hello"
myFunc1("10",123);//"10123"; 

console.log(10+20+"30");//"3030"
console.log("10"+20+"30");//"102030"
console.log("10"+20+30);//"102030"

myFunc1();//NaN
myFunc1(10);//NaN
myFunc1(10,20);//30
myFunc1(10,20,30);//30
myFunc1(10,20,30,40,50);//30

myFunc1("diksha");//"dikshaundefined"

function myFunc2(p1,p2)
{
    var sum1=0;
    for(let i=0;i<myFunc2.arguments.length;i++)
    {
        sum1+=myFunc2.arguments[i];
    }
    console.log(sum1);
}
myFunc2();//0
myFunc2(10);//10
myFunc2(10,20);//30
myFunc2(10,20,30);//60
myFunc2(10,20,30,40,50);//150

// ES6 feature -- rest paramater -- variable number of arguemnets in the function call
function myFunc3(...p1)
{
    var sum1=0;
    for(let i=0;i<p1.length;i++)
    {
        sum1+=p1[i];
    }
    console.log(sum1);
}
myFunc3();//0
myFunc3(10);//10
myFunc3(10,20);//30
myFunc3(10,20,30);//60
myFunc3(10,20,30,40,50);//150
// Rules for rest paramater
//1. Only one rest parameter
//2. Always the rest parameter should be the last parameter
/* function myFunc4(...p1,...p2)
{
    console.log("Rest param p1",p1);
    console.log("Rest param p2",p2);
    var sum1=0;
    for(let i=0;i<p1.length;i++)
    {
        sum1+=p1[i];
    }
    console.log(sum1);
}
myFunc4();//error
myFunc4(10);//error
myFunc4(10,20);//error
myFunc4(10,20,30);//error
myFunc4(10,20,30,40,50);//error
 */

// 

/* arr1=[10,20,30,40,50];
//array, position after which i want to insert,any number of elements to add
myFunc5(arr1,2,35);//[10,20,30,35,40,50]
arr1=[10,20,30,40,50];
myFunc5(arr1,1,56,55,77,88);//[10,20,56,55,77,88,30,40,50]

//array, position after which i want to insert/deletion,deleteCount,any number of elements to add
arr1=[10,20,30,40,50,60,70];
myFunc6(arr1,2,2,100,200);//[10,20,30,100,200,60,70]

arr1=[10,20,30,40,50,60,70];
myFunc6(arr1,4,1,99,98,97,96);//[10,20,30,40,50,99,98,97,96,70]

arr1=[10,20,30,40,50,60,70];
myFunc6(arr1,0,3);//[10,50,60,70]

arr1=[10,20,30,40,50,60,70];
myFunc6(arr1,0,0,55,66);//[55,66,10,20,30,40,50,60,70]

//4.
arr=[10,20,30,40,50];
findIndex(arr,30);//2
findIndex(arr,300);//-1
 */
arr1=[10,20,30,40,50];
var arrCopy1=Array.from(arr1);
arr1[0]=100;
console.log(arrCopy1);
console.log(arr1);

var arrCopy2=arr1.concat();
arr1[0]=2000;
console.log(arrCopy2);
console.log(arr1);

var arrCopy3=arr1.slice(0,arr1.length);
arr1[0]=2000;
console.log(arrCopy3);
console.log(arr1);

var testArr=[1,2,3];
var a=testArr.slice();
console.log(a);
console.log(testArr);

// COPY OF AN OBJECT
var obj2={empId:101,empName:"sara"};
var objCopy1=Object.assign({},obj2);
obj2.empId=999;
console.log("Obj2",obj2);
console.log("ObjCopy1",objCopy1);

var obj2={empId:101,empName:"sara"};
let objCopy2InString=JSON.stringify(obj2);
objCopy2=JSON.parse(objCopy2InString);
obj2.empId=5555;
console.log("Obj2",obj2);
console.log("ObjCopy2",objCopy2);

// spread operator ...

















