function Vote_Function()  {
    var age, Can_vote;
    age = document.getElementById("age").value;
    Can_vote = (age < 18) ? "you are not old enough":"You are old enough";
    document.getElementById("vote").innerHTML = Can_vote + " to vote.";

}

//ternary//
function Vehicle(Make, Model, Year, Color) {
    this.Vehicle_Make = Make;
    this.Vehicle_Model = Model;
    this.Vehicle_Year = Year;
    this.Vehicle_Color = Color;
}
var Jack = new Vehicle("Dodge","Viper", 2020, "Red");
var Emily = new Vehicle("Jeep", "Trail Hawk", 2019, "White and Black");
var Erik = new Vehicle("Ford", "Pinto", 1971, "Mustard");
function myFunction() {
    document.getElementById("Keywords_and_Constructors").innerHTML = 
    "Erik drives a " + Erik.Vehicle_Color + "-colored " + Erik.Vehicle_Model +
    " manufactured in " + Erik.Vehicle_Year;
}
//using new and this//
function firstfunction() {
    document.getElementById("New_and_This").innerHTML = (20 > 10);
}

//constructor function//
function Person(first, last, age, eye) {
    this.firstName = first;
    this.lastName = last;
    this.age = age;
    this.eyeColor = eye;
}
var myFather = new Person("John", "Doe", 50, "blue");

//nested function//
function count_Function() {
    document.getElementById("Counting").innerHTML = Count();
    function Count() {
        var starting_point = 9;
        function Plus_one() {Starting_point += 1;}
        Plus_one();
        return Starting_point;
    }
}