
var text = "";
var i = 0;
while (i < 10) {
  text += "<br>The number is " + i;
  i++;
}
document.getElementById("demo").innerHTML =text;

var instruments = ["Guitar", "Drums", "Bass", "Violin", "Trumpet", "Flute"];
var Content = "";
var Y;
function for_Loop() {
  for (Y = 0; Y < Instruments.length; Y++) {
    Content += Instruments [Y] + "<br>";
  }
  document.getElementById("List_of_Instruments").innerHTML = Content;
}

function myFunction() {
  var str = "Hello World!";
  var n = str.length;
  document.getElementById("demo").innerHTML = n;
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


function constant_function() {
  const Musical_Instrument = {type:"guitar", brand:"Fender", color:"black"}
  Musical_Instrument.color = "blue";
  Musical_Instrument.price = "$900";
  document.getElementById("Constant").innerHTML = "The cost of the " +
    Musical_Instrument.type + " was " + Musical_Instrument.price;
}