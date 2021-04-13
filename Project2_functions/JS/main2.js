
document.write("test");


function My_First_Function() {
    var str = "this text is green!";
    var result = str.fontcolor("green");// changing font color//
    document.getElementById("Green_Text").innerHTML = result;

}

function myFunction() { //naming the function here//
    var sentence = "Iam learning";// one of two variables//
    sentence += "a lot from this book!";// second variable//
    document.getElementById("Concatenate").innerHTML = sentence;

}
   
function myFunction(p1, p2) {
    var p1=5;
    var p2=6;
    return p1 * p2;   // The function returns the product of p1 and p2
  }