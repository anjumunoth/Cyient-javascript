var arr1=[10,20,30,40,50];
// copy of an array ES6 -- spread operator

var arrCopy1=[...arr1];
arr1[0]=1000;
console.log("Arr1",arr1);
console.log("ArrCopy1",arrCopy1);

arr1=[10,20,30,40,50];
var arrUpdated2=[...arr1,60,70];
console.log(arrUpdated2);[10,20,30,40,50,60,70]

var arrUpdated3=[5,7,...arr1,60,70];
console.log(arrUpdated3);[5,7,10,20,30,40,50,60,70]

// Spread operator with object
var obj1={empId:101,empName:"sara"};
var objCopy1={...obj1};
objCopy1.empId=777;
console.log("Obj1 ",obj1);
console.log("ObjCopy1 ",objCopy1);

var objUpdated2={...obj1,salary:456};
console.log(objUpdated2);//{empId:101,empName:"sara",salary:456};
obj1={empId:101,empName:"sara"};
var objUpdated3={...obj1,empId:777};
console.log(objUpdated3);//{empId:777,empName:"sara"};

var objUpdated4={empName:"geeta",...obj1};
console.log(objUpdated4);//{empId:101,empName:"sara"}
//{empId:101,empName:"geeta"};
//{empId:101,empName:"sara"} --- correct
//{empName:"geeta",empId:101,empName:"sara"}
//{empName:"geeta",empId:101}
//{empName:"geeta",empId:777}


// Anonymous function: function without a name

//1. IIFE Immediately invoked function expression
(function (p1,p2)
{
    console.log( p1+p2);
})(10,20)

// 2. Calling an anonymous function
// f1 is a reference to the anonymous function
var f1=function (str1)
{
    console.log("Substr " ,str1.substr(0,5));
}

f1("beautiful");

var f2=function(str,startingPos,endingPos)
{
    return str.substring(startingPos,endingPos);
}
var result=f2("beautiful",4,7);//tif
console.log("Result of substring",result);//tif

function f3(str,startingPos,endingPos)
{
    return str.substring(startingPos,endingPos);
}

// Use cases of anonymous function

let obj={
    empName:"Upendra",
    empId:60608,
    display:function (){
        console.log("Emp Id",this.empId);
        console.log("Emp Name",this.empName);
    }
}
obj.empName="Upendra Koppineni";
obj.display();
obj.empId=101;
//obj.60608=101;cannot access obj.value
//obj.printDetails();// cannot access obj.value


// Second use case of anonymous function
// to pass a function as a parameter to another function
function myFunc1(p1)
{
    var result=p1();// call the function
    //var result=generateRandomNumber();
    var pinNumber=Math.floor(result*10000);// 4 digit pin number
    console.log("Pin Number to be sent to the mobile",pinNumber);
}
// myFunc1(10)
// myFunc1("hello")
// myFunc1([10,20,30]);
// myFunc1({empId:101,empName:"sara"})
myFunc1(function (){
    return Math.random();//generate a random number in the range 0 to 1
})

var num1=100;
function myFunc2(a1=100)
{
    console.log(a1*2);//400
}
myFunc2(num1*2);// 400
myFunc2();//200

// rest param and spread operator
//function myFunc3(...p1)// rest param
//var obj={...obj1};//spread opearator

// default paramaters:
// substr,substring,slice
function myFunc5(str1,startingPos=0,endingPos=str1.length)
{
    return str1.slice(startingPos,endingPos);
}

var result=myFunc5("beautiful",2,6);
console.log(result);//auti

var result=myFunc5("beautiful");
console.log(result);//"beautiful"

var result=myFunc5("beautiful",5);
console.log(result);// iful;
// 0 1 2 3 4 5 6 7 8
// b e a u t i f u l
//-9-8-7-6-5-4-3-2-1
var result=myFunc5("beautiful",-7,9);
console.log(result);// autiful; 

var result=myFunc5("beautiful",3,-4);
console.log(result);// ut










