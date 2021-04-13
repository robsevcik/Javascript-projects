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