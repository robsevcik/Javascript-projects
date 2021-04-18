
var text = "";
var i = 0;
while (i < 10) {
  text += "<br>The number is " + i;
  i++;
}
document.getElementById("demo3").innerHTML =text;
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

function myFunction(name) {
  return "Hello " + "You";
  document.getElementById("demo").innerHTML = myFunction("John");
}
//let keyword//
let car = {
  make: "Dodge",
  model: "Viper ",
  year: "2021",
  color: "red",
  description : function() {
    return "The car is a " + this.year + this.color + this.make + this.model;

  }
};
document.getElementById("Car_Object").innerHTML = car.description();

var text = "";
var i;
for (i = 0; i < 10; i++) {
  if (i === 3) { break; }
  text += "The number is " + i + "<br>";
}
document.getElementById("demo2").innerHTML = text;
