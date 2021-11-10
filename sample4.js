var arr=[10,20,30,40,50];

arr.push(60);
console.log(arr);//[10,20,30,40,50,60]

arr.push(70,80);
console.log(arr);//[10,20,30,40,50,60,70,80];

var lastElement=arr.pop();
console.log(lastElement);

var lastElement=arr.pop(2);
console.log(lastElement);//70
// insert an element at the beginning
arr.unshift(-5);//[-5,10,20,30,40,50,60]

var res=arr.shift();//pop the first the element
console.log(res);//-5

//replace an element
arr.fill(90,2,3);
console.log(arr);

// insert an element at a particular position
arr.splice(2,0,25);
console.log(arr);

// delete an element at a particular position
arr.splice(4,1);
console.log(arr);

delete arr[4];//avoid it ; create a hole in the array
console.log(arr);

for(let i=0;i<arr.length;i++)
{
    console.log(arr[i]);
}

arr=[10,24,12,15,17];
arr.sort();
console.log(arr);//[10,12,15,17,24]

arr=[187,24,12,15,17];
arr.sort();
console.log(arr);//[12,15,17,24,101];//[12,15,17,187,24]

function compare(a,b)
{
    if(a>b)
        return 1;
    else
        if(a<b)
            return -1;
        else
            return 0;
}

arr.sort(compare);
console.log(arr);

var empArr=[
    {empId:101,empName:"Asha",salary:1001,deptId:"D1"},
{empId:102,empName:"Saurav",salary:2000,deptId:"D1"},
{empId:103,empName:"Karan",salary:2000,deptId:"D2"},
{empId:104,empName:"Kishan",salary:3000,deptId:"D1"},
{empId:105,empName:"Keshav",salary:3500,deptId:"D2"},
{empId:106,empName:"Pran",salary:4000,deptId:"D3"},
{empId:107,empName:"Gaurav",salary:3800,deptId:"D3"}
]
// sort on the basis of the salaries
function compare(emp1,emp2)
{
    var a=emp1.salary;
    var b=emp2.salary;
    if(a>b)
        return 1;
    else
        if(a<b)
            return -1;
        else
            return 0;
}
empArr.sort(compare);
console.log(empArr);

// sort empArr according to the names
function compareStrings(emp1,emp2)
{
    var a=emp1.empName;
    var b=emp2.empName;
    return a.localeCompare(b)
}

empArr.sort(compareStrings);
console.log(empArr)


arr=[10,20,30,40];
arr.reverse();
console.log(arr);

// fat arrow function or lambda function or arrow function
var f1=function(p1,p2){
    return p1+p2;
}
var res=f1(10,20);
console.log(res);//30

// declare an anonymous function
f1=(p1,p2) => { return p1+p2;}

f1=p1 => {return p1+10}

f1= () => { return "thank u"}

f1 =(p1,p2) => p1+p2

f1= item => item*item

arr=[101,23,205,33,99];
arr.sort();//[101,205,23,33,99]

arr=[101,23,205,33,99];
arr.sort((a,b) => a-b);//[23,33,99,101,205];

// bubble sort
/*
first iteration 
101  > 23
101 >205 => search =205
205 >33
205 >99
[23,101,33,99,205]

function mySort(f1)
{
    for(let i=0;i<arr.length;i++)
    {
        for(let j=i+1;j<arr.length;j++)
        {
            if(f1)
            {
                var res=f1(arr[i],arr[j])
            }
            else
            {
                var res=arr[i].toString().localeCompare(arr[j].toString())
            }
            if(res >0)
            {
                var temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
            }
        }
    }
}

*/

var arr=[10,20,30,40,50,60];
// ES6 new array functions
// map -- iterate through the array and for each array element it will execute the predicate function
// map -- return an array which is of the same size as the array on which map is called
var resArr=arr.map(item => item *item)
/*
first iteration
item =10; return 100; resArr[0]=100
item =20; return 400;resArr[1]=400
...

*/
console.log(resArr);//[100,400,900,1600,2500,3600];
var resArr=arr.map(item =>{
    if(item >25)
    {
        return item *item
    }
})

console.log(resArr);//[ud,ud,900,1600,2500,3600]

var i;
console.log(i);//ud

var str1 = 'Festival brings joy and happiness';
console.log(str1);

var capString = str1 => str1.charAt(0).toUpperCase() + str1.slice(1).toLowerCase();

var wordsArr = str1.split(' ').map(capString);
/* 
first iteraion :
capString("Festival");//wordsArr[0]="Festival"
second iteration
capString("brings");//wordsArr[1]="Brings"
capString("joy");//wordsArr[2]="Joy"
*/
console.log(wordsArr);// array
var titleCase = wordsArr.join(' '); // single string by joining all the array elements 

console.log(titleCase);

// find,filter

// find -- iterate through the array and excute the predicate function on the each element
// On whichever element, the predicate function returns true, return that element;
// once for an element, the predicate function returns true, the rest of the array is not going to be iterated
// always return the first occurence of the element which satisfies the predicate function
arr=[10,20,30,40,50];
var output=arr.find(item => (item%3 ==0))
console.log(output);//30

arr=[10,20,30,40,50,60];
var output=arr.find(item => (item%3 ==0))
console.log(output);//30

arr=[10,20,30,40,50,60];
var output=arr.find(item => (item%7 ==0))
console.log(output);// ud

// filter -- all the occurences of the elements which satisfy the predicate function
// will always return an array
arr=[10,20,30,40,50,60];
var outputArr=arr.filter(item => (item%3 ==0))
console.log(outputArr);// [30,60]

arr=[10,20,30,40,50,60];
var outputArr=arr.filter(item => (item%7 ==0))
console.log(outputArr);//[] 


arr=[10,20,30,40,50,60];
var pos=arr.findIndex(item => (item%3 ==0))
console.log(pos);// 2

arr=[10,20,30,40,50,60];
var pos=arr.findIndex(item => (item%7 ==0))
console.log(pos);// -1

/*
arr=[10,20,30,40,50,60];
var pos=arr.filterIndex(item => (item%3 ==0))
console.log(pos);// [2,5]

arr=[10,20,30,40,50,60];
var pos=arr.filterIndex(item => (item%7 ==0))
console.log(pos);// []

*/

//Assignment 1: filterIndex
/*
Assignment 2: dom presentation
3: [{empId:101,empName:"Asha",salary:1001,deptId:"D1"},
{empId:102,empName:"Gaurav",salary:2000,deptId:"D1"},
{empId:103,empName:"Karan",salary:2000,deptId:"D2"},
{empId:104,empName:"Kishan",salary:3000,deptId:"D1"},
{empId:105,empName:"Keshav",salary:3500,deptId:"D2"},
{empId:106,empName:"Pran",salary:4000,deptId:"D3"},
{empId:107,empName:"Saurav",salary:3800,deptId:"D3"}]
3. Get an array of employeeIds
4. Find all the employees who have a salary greater than 3000
5. Create a html document. About yourself
Do the entire styling using js only


*/

let arr1=[10,20,30,40,50];

function filterIndex(f1)
{
    let posArr=[];
    for(let i=0;i<arr1.length;i++)
    {
        var result=f1(arr1[i]);
        if(result == true)
        {
            posArr.push(i);
        }
    }
    return posArr;
}

var resultArr=filterIndex(item => item % 3 ==0)
console.log(resultArr);

var resultArr=filterIndex(item => item % 7 ==0)
console.log(resultArr);

//https://codeshare.io/oQdvlp














