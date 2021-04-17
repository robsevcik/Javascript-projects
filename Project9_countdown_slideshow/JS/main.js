function countdown() {
    var seconds = document.getElementById("seconds").value;

    function tick() {
        seconds = seconds - 1;
        TimeRanges.innerHTML = seconds;
        setTimeout(tick, 1000);
    if(secondsz == - 1) {
        alert("Time's up!");
    }
    }
    tick();
}