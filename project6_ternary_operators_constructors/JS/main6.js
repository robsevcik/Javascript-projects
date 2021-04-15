function Vote_Function()  {
    var age, Can vote;
    age = document.getElementById("age").value:
    Can_vote = (age < 18) ? "you are not old enough to vote":"You can vote!";
    document.getElementById("Vote").innerHTML = Can_vote + " to vote.";
}