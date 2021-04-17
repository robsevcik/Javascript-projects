function full_Sentence() {
    var part_1 = "I have ";
    var part_2 = "made this ";
    var part_3 = "into a complete ";
    var part_4 = "sentence.";
    var whole_sentence = part_1.concat(part_2, part_3, part_4);
    document.getElementById("Concatenate").innerHTML = whole_sentence;
}
//slice//

function slice_Method() {
    var Sentence = "All work and no play makes Jack a dull boy.";
    var Section = Sentence.slice(27,33);
    var str = "Hello World!";
    var res = str.toUpperCase();
    document.getElementById("Slice").innerHTML = Section;
}
//uppercase//
function upper_Case_Method() {
    var str = "Hello World!";
    var res = str.toUpperCase();
    document.getElementById("Upper").innerHTML = str;
}
//search//
function search_Method() {
    var str = "Mr. Blue has a blue house";
    var n = str.search("blue");
    document.getElementById("Search").innerHTML = str;
}

//numbers to string//
function string_Method()  {
    var X =182;
    document.getElementById("Numbers_to_string").innerHTML = X.toString();

}

//pprecision method//
function precision_Method()  {
    var X = 12938.3012987375112;
    document.getElementById("Precision").innerHTML = X.toPrecision(10);
}

function fixed_Method() {
    var num = 5.56789;
    var n = num.toFixed(2);
    document.getElementById("Fixed").innerHTML = str;
}


    function value_Method() {
        var str = "Hello World!";
        var res = str.valueOf();
        document.getElementById("Value").innerHTML = str;
    }