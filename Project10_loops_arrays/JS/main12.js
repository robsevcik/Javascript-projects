function Hello_World_Function() {
    var A = document.getElementsByClassName("Click");
    A[0].innerHTML = "The text has changed!";
}


var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");

// red gradient//
var grd = ctx.createRadialGradient(75, 50, 5, 90, 60, 100);
grd.addColorStop(0, "red");
grd.addColorStop(1, "white");


ctx.fillStyle = grd;
ctx.fillRect(10, 10, 150, 80);


//black Gradient//
var d = document.getElementById("Gradient");
var ct = c.getContext("2d");

var grd = ctx.createLinearGradient(0, 0, 170, 0);
grd.addColorStop(0, "black");
grd.addColorStop(1, "white");

ct.fillStyle = grd;
ct.fillRect(20, 20, 150, 100);