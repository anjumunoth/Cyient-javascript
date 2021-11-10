function changeBackground()
{
    var myColor=prompt("Enter the colour u want the background to change to","pink");
    document.body.style.backgroundColor=myColor;
}
function changeFontColour()
{
    document.getElementById("h1Element").style.color="blue";
}
function validateName()
{
    var firstName=document.getElementById("txtBox1").value;
    alert("U have entered "+ firstName);
    var result=confirm("Are u sure this is the final name");
    if(result== true)
    {
        document.getElementById("txtBox1").value=""   
    }
    else
    {
        alert("Enter the new name");
    }
}

function changeToYellowBg(event)
{
    //document.getElementById("txtBox1").style.backgroundColor="yellow";
    event.target.style.backgroundColor="yellow";// faster
}

function changeToDefaultBg(event)
{
    event.target.style.backgroundColor=null;// faster
}

function onMouseOverEventHandler(event)
{
    event.target.style.backgroundColor="cyan";
    event.target.style.color="blue";
    event.target.style.fontSize="48px";
}
function onMouseOutEventHandler(event)
{
    event.target.style.backgroundColor="green";
    event.target.style.color="yellow";
    event.target.style.fontSize="24px";
}

function addBorder(event)
{
    setTimeout(()=>{
        event.target.style.border="5px double red";
    },3000)
    colorArr=["red","green","yellow","cyan","beige"];
    ctr=0;
    setInterval(()=>{
        event.target.style.backgroundColor=colorArr[ctr];
        ctr++;
        if(ctr==5)
        {
            ctr=0;
        }
    },3000)
    
}

var img1Element=document.getElementById("img1");
img1Element.onmouseenter=function(event){
    event.target.style.border="5px solid blue";
    event.target.style.borderRadius="50%";
}

img1Element.addEventListener("mouseleave",(event)=>{
    event.target.style.border="5px dashed red";
    
    event.target.style.borderRadius="25%";
})
img1Element.addEventListener("mouseleave",(event)=>{
    event.target.style.backgroundColor="cyan";
    event.target.style.padding="20px";
    event.target.style.position="relative";
    event.target.style.top="50px";
    event.target.style.left="50px";
})

function keyPressEventHandler(event)
{
    console.log("key pressed",event.charCode);
    event.target.value=event.target.value.toUpperCase();

}
var str="hello";

function keyDownEventHandler(event)
{
    console.log(event.target.value);
    console.log(Number.isInteger(parseInt(event.target.value)))   
    if (!Number.isInteger(parseInt(event.target.value)))
    {
        event.target.value="";
    }
    else
    {
        console.log("U entered the correct data");
    }
}
var s=5*+-5;
window.onerror=function(event,source,lineno)
{
    console.log("Error occurred at lineno"+lineno);
}
var imgElement=document.getElementById("img11");
imgElement.addEventListener("error",function(event){
    imgElement.setAttribute("src","C:\\Users\\anjum\\OneDrive\\Desktop\\dishes\\flower.jpg")
    console.log("Replacement image loaded");
})

function validateFormDetails()
{
    alert("U clicked on the submit button")
}

/*
Assignments on DOM Manipulation:

1. Add a ul and li elements. Whenever the user clicks on a specilfic li, its background should change 
2. Add an image. So when the user hovers over the image, increase the width and height of the image by 20px;
3. Add 2 buttons. Add 2 bars of div with background color red and green. Buttons: Move left, move right
4. Create a traffic signal. 
*/
