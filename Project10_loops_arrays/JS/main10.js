

//for loop//
var instruments = ["Guitar", "Drums", "Bass", "Violin", "Trumpet", "Flute"];
var Content = "";
var Y;
function for_Loop() {
  for (Y = 0; Y < instruments.length; Y++) {
    Content += instruments[Y] + "<br>";
  }
  document.getElementById("List_of_Instruments").innerHTML = Content;
}
//string//
function myFunction() {
  var str = "Hello World!";
  var n = str.length;
  document.getElementById("demo4").innerHTML = n;
}

function cat_pics() {
  var Cat_Picture = [];
  Cat_Picture[0] = "sleeping";
  Cat_Picture[1] = "playing";
  Cat_Picture[2] = "eating";
  Cat_Picture[3] = "purring";
  document.getElementById("Cat").innerHTML = "In this picture, the cat is";
    Cat_Picture[2] + ".";
}

//array//
function constant_function() {
  const Musical_Instrument = {type:"guitar", brand:"Fender", color:"black"}
  Musical_Instrument.color = "blue";
  Musical_Instrument.price = "$900";
  document.getElementById("Constant").innerHTML = "The cost of the " +
    Musical_Instrument.type + " was " + Musical_Instrument.price;
}

function myFunction2(name) {
  return "Hello " + name;
}
function callName() {
  document.getElementById("demo6").innerHTML = myFunction2("Mark");
}
//let keyword//
var  x = 10;
// Here x is 10
{  
  let x = 2;
  // Here x is 2
}
// Here x is 10
document.getElementById("demo5").innerHTML = x;



//break//
var cars = ["BMW", "Volvo", "Saab", "Ford"];
var text = "";

list: {
  text += cars[0] + "<br>"; 
  text += cars[1] + "<br>"; 
  break list;
  text += cars[2] + "<br>"; 
  text += cars[3] + "<br>"; 
}

document.getElementById("demo2").innerHTML = text;
