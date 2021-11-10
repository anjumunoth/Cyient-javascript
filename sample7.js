function changeNameEventHandler(event)
{
    console.log("Change event triggered "+event.target.value)
}
function inputNameEventHandler(event)
{
    console.log("Input event triggered "+event.target.value)
    var spanElement=document.getElementById("span1");
    spanElement.innerHTML=event.target.value;
}