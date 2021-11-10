// entire html document is presented as a tree structure

var h2Element=document.getElementById("heading2");
h2Element.style.backgroundColor="pink";
h2Element.style.border="10px dashed blue";
h2Element.textContent="Today is a rainy day"
h2Element.style.fontStyle="italic"

h2Element.innerHTML="<i>Today is a beautiful day </i>"

var anchorElement=document.getElementById("anchor1");
anchorElement.href="https://www.cyient.com/";
//anchorElement.setAttribute("href","https://www.cyient.com/");

var imgElement=document.getElementById("img1");
img1.src="C:\\Users\\anjum\\OneDrive\\Desktop\\dishes\\thanks.jpg";

// access all the html elements which are images
var elementArr=document.getElementsByTagName("img");
console.log(typeof elementArr);
console.log(elementArr);
for(let i=0;i< elementArr.length;i++)
{
    elementArr[i].style.border="10px double maroon";
}

// access all the html elements based on the class name
var classElementsArr=document.getElementsByClassName("c1");
for(let i=0;i< classElementsArr.length;i++)
{
    classElementsArr[i].style.backgroundColor="green";
}

//querySelectorAll

var trInTbodyElements=document.querySelectorAll("table tbody tr") ;
console.log(trInTbodyElements)
var sum1=0;
for(let i=0;i<trInTbodyElements.length;i++)
{
    var childrenSalary=trInTbodyElements[i].children[2].innerHTML;
    console.log(childrenSalary);
    sum1+=parseInt(childrenSalary);
}
console.log(sum1);

// append a html element
var tableElement=document.getElementById("table1");
var newTrElement=document.createElement("tr");
var td1=document.createElement("td");
td1.innerHTML="Sum of Salary";
var td2=document.createElement("td");
td2.innerHTML="";
var td3=document.createElement("td");
td3.innerHTML=sum1;
newTrElement.appendChild(td1);
newTrElement.appendChild(td2);
newTrElement.appendChild(td3);

//tableElement.appendChild(newTrElement);

var t2Element=document.getElementById("t2");
var parentElement=document.getElementById("t2").parentElement;// tbody
parentElement.insertBefore(newTrElement,t2Element);


var ulElement=document.getElementById("ul1");
var liElement=document.createElement("li");
liElement.textContent="Europe";
var li2=document.getElementById("li2");

//ulElement.insertBefore(liElement,li2);

//ulElement.removeChild(li2);
ulElement.replaceChild(liElement,li2);


