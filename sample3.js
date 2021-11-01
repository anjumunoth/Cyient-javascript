var str1="malayalam";
// Number of occurences of a particular string
//numberOfOccurences(str1,"a");//4; for loop ; optimised code

function numberOfOccurences(str1,searchString)
{
    var myPattern =new RegExp(searchString,"g")
    return ((str1.match(myPattern)||[]).length)
}

var result=numberOfOccurences("malayalam","a");
console.log(`Occurence of a in malayalam is ${result}`)

var s1="To be or not To be is the question"
var s2="To be"
var result=numberOfOccurences(s1,s2);
console.log(`Occurence of ${s2} in ${s1} is ${result}`)

function numberOfOccurences(str1,searchString)
{
    var count=0;
    var pos=str1.indexOf(searchString);//1
    while(pos !=-1)
    {
        count++;// 1; 2; 3; 4
        pos=str1.indexOf(searchString,pos+1);
        //start searching from 2; pos =3;
        // start searching from 4; pos =5
        // start searching from 6; pos =7
        // start searching from 8; pos= -1
    }
    return count;
}
var result=numberOfOccurences(s1,s2);
console.log(`Occurence of ${s2} in ${s1} is ${result}`)

// split


// match


/* Regular expressions:
/regexp/modifier

str1="Today is the beautiful day"
str2="good morning";

/o/ -- search for the presence of the single char
/^g/ -- start with g ; str2 
/y$/ -- end with y ; str1

/[ABCT]/ -- any one of the characters; str1

/[A-Z]/ -- any of the uppercase characters

/[A-Z,a-z]/ -- any of the character

/[A-Z,a-z,0-9]/ -- any alpha numeric character

/day/ -- match three characters together

/day[0-9]/ ;//"day5"; "today3";"Today is day3 of the training"
//will not match "day 3"; "Today is the beautiful day"; 

wild card characters

? -- 0 or 1 character 
* -- 0 or more character
+ -- 1 or more characters

/go?d/
gd; god

/go+d/
god; good; gooood

/go*d/
gd; god; good; gooooooooood


/[0-9]/ -- can have a single number

/[0-9]{10}/ -- it should have 10 numbers
9841042592;
will not match: "4567gvhbjn65789"; 

var emailId="anjumunoth@gmail.com"
/[A-Z,a-z,0-9,$,&," "]*@[A-z,a-z]*.[A-z,a-z]{2}/

"asha@gmail.i" ;// will not match
"asha#@gmail.com";//will not match  
"asha@g5.com";//will not match 

modifiers: 
g -- global search
i -- ignore the case 

/go*d/i

"Good" -- match

var str2="Apple can be a fruit or apple can be a watch"
str2.replace(/apple/i,"orange");//orange can be a fruit or apple can be a watch"
str2.replace(/apple/ig,"orange");//orange can be a fruit or orange can be a watch"




*/
// Date date type
var today=new Date();// calling the constructor of the Date class
console.log(today);

var randomDate=new Date(1000);// 1000 millisecs after the epoch date : Jan 1 1970
console.log(randomDate)

var lavanyaBdayThisYear=new Date("11/8/2021");
console.log(lavanyaBdayThisYear);

var sandeepBday=new Date(2021,10,25);
console.log(sandeepBday);
 
var sushmaBday=new Date(2021,11);
console.log(sushmaBday);

var dikshaBday=new Date(2021,7,17,12,32,0,34);
console.log(dikshaBday);

var randomBday1=new Date(2021,7,17,16,32);
console.log(randomBday1);

var randomBday1=new Date(2021,14,17,16,32);
console.log(randomBday1);//17th march 2022 4:32 pm 










/*
Assignments:
1. Convert a string to title case :
Input :"hello world"
output: "Hello World"

2. Convert a string seperated by hyphens to camel case :
Input :"javascript_first_project"
output: "javascriptFirstProject"

3. Calculate how many days to ur birthday

4. List the array functions -- min 10 



*/


