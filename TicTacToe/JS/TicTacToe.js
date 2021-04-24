//This variable keeps track of whose turn it is
let activePlayer = 'X';
//This array stores an array of moves.We use this to determin win conditions.
let selectedSquares = [];
//This function is for placing an x or o in a square
function placeXOrO(squareNumber)  {
    //This condition ensures a square hasn't been selected already
    //The .some() method is used to check each element of selectedsquare array
    //to see if it contains the square number clicked on
if (!selectedSquares.some(element => element.includes(squareNumber))) {
    //This variable retrieves the html element id that was clicked
    let select = document.getElementById(squareNumber);
    //This condition checks who's turn it is.
    if (activePlayer === 'X')  {
        //if active player is equal to X, the x.png is placed in HTML.
        select.style.backgroundImage = 'url("images/x.png")';
        //Active playermay only be 'X' or 'O' so, if not 'X' it must be 'O'
    } else {
        //If active player is equal to 'O', the o.png is placed in html
        select.style.backgroundImage = 'url("images/o.png")';
    }
    //squareNumber and activePlayer are concatenated together and added to array.
    selectedSquares.push(squareNumber + activePlayer);
    //This calls a function to check for any win conditions.
    checkWinConditions();
    //This condition is for changing active player.
    if (activePlayer === 'X')  {
        //If active player is x change it to "o"
        activePlayer = 'O';
        //If active player is anything other than "X"
    } else {
        //change the active player to "X"
        activePlayer = 'X';
    }

    // this function plays placement sound
    audio('./media/place.mp3');
    //This condition checks to see if its computer's turn
    if(activePlayer === 'O')  {
        //This function disablers clicking for computers choice
        disableClick();
        //This function waits 1 second before computer places image and enables click
        setTimeout(function () { computersTurn(); }, 1000)
    }
    //Returning true is needed for our computers turn function to work
    return true;
}
//This function results in a random square being selected
    function computersTurn() {
    //this boolean is needed for our while loop.
        let success = false;
        //this varable stores a random number 0-8
        let pickASquare;
        //this condition alloiws our while loop to keep trying if a square is selected already
        while(!success) {
            //A random number between 0 and 8 is selected
            pickASquare = String(Math.floor(Math.random() * 9));
            //if random number evaluatedreturns true, the square hasnt been slected yet
            if (placeXOrO(pickASquare)) {
            //This line calls the function
            placeXOrO(pickASquare);
            //this changes our boolean and ends the loop
            success = true;
            };
        }
    }
}

//This function parses the selectSquares array to nsearch for win conditions.
//drawWinLine function is called to draw line if condition is met.
function checkWinConditions() {
    //  X, O, 1, 2 condition
    if   (arrayIncludes('OX', '1X', '2X'))  { drawWinLine(50, 100, 558, 100)}
    //X 3, 4, 5 condition
    else if (arrayIncludes('3X', '4X', '5X'))  { drawWinLine(50, 304, 558, 304)}
    else if (arrayIncludes('6X', '7X', '8X'))  {drawWinLine(50, 508, 558, 508)}
    else if (arrayIncludes( '0X', '3X', '6X')) { drawWinLine(100, 50, 100, 558)}
    else if (arrayIncludes('1X', '4X', '7X'))  { drawWinLine(304, 50, 304, 558)}
    else if (arrayIncludes('2X', '5X', '8X'))  { drawWinLine(508, 50, 508, 558)}
    else if (arrayIncludes('6X', '4X', '2X'))  { drawWinLine(100, 508, 510, 90)}
    else if (arrayIncludes('0X', '4X', '8X'))  { drawWinLine(100, 100, 520, 520)}
    else if (arrayIncludes('0O', '1O', '2O'))  { drawWinLine(50, 100, 558, 100)}
    else if (arrayIncludes('3O', '4O', '5O'))  { drawWinLine(50, 304, 558, 304)}
    else if (arrayIncludes('6O', '7O', '8O'))  { drawWinLine(50, 508, 558, 508)}
    else if (arrayIncludes('0O', '3O', '6O'))  { drawWinLine(100, 50, 100, 558)}
    else if (arrayIncludes('1O', '4O', '7O'))  { drawWinLine(304, 50, 304, 558)}
    else if (arrayIncludes('2O', '5O', '8O'))  { drawWinLine(508, 50, 508, 558)}
    else if (arrayIncludes('6O', '4O', '2O'))  { drawWinLine(100, 508, 510, 90)}
    else if (arrayIncludes('0O', '4O', '8O'))  { drawWinLine(100, 100, 520, 520)}
    //This condition checks for tie.If none of the above conditions register and 9
    //squares are selected the code executes.
    else if (selectedSquares.length >= 9) {
        //This function plays the tie game sound
        audio('./media/tie.mp3');
        //this function sets a .3 second timer before the resetGame is called.
            setTimeout(function () { resetGame(); }, 1000);       
    }

    //this function resets the gamein the event of a tie or a win
    function resetGame() {
        //This for loop iterates through each HTML square element
        for(let i = 0; i< 9; i++) {
            //This variable gets the HTML element of 1.
            let square = document.getElementsById(String(i))
            //This removes our elements background image
            square.style.backgroundImage = ''
        }
        //This resets our array so it is empty and we can start over
        selectedSquares = [];
    }
    //This function checks if an array includes 3 strings. It is used to check for
    //each win condition
    function arrayIncludes(squareA, squareB, squareC) {
        //These variables will be used to check for 3 in a row
        const a = selectedSquares.includes(squareA)
        const b = selectedSquares.includes(squareB)
        const c = selectedSquares.includes(squareC)
        //If the 3 variables we pass are all included in our array true is
        //returned and our else if condition execxutes the drawLine function
        if (a === true && b === true && c === true)  {return true}
    }
}
//This function makes our body element temporarily unclickable
function disableClick() {
    //This makes our body unclickable
    body.style.pointerEvents = 'none';
    //This makes our body clickable again after 1 second
    setTimeout(function() {body.style.pointerEvents = 'auto';}, 1000);
}
//This function takes a string parameter of the path you set earlier for
//placement sound
function audio(audioURL) {
    //play method plays our audio sound
    let audio = new Audio(audioURL);
    audio.play();
}
//This function utilizes html canvas to draw win lines
function drawWinLine(coordX1, coordY1, coordX2, coordY2)  {
    //This line accesses our html canvas element
    const canvas = document.getElementById('win-lines')
    //This line gives us access to methods and properties to use on canvas
    const c = canvas.getContext('2d');
    //This line indicates where the start of lines x axis is
    let x1 = coordX1,
    //This line indicates where the start of a lines y axix is
    y1 = coordY1,
    x2 = coordX2,
    y2 = coordY2,
    x = x1,
    y = y1;

//This function interacts with the canvas
function animateLineDrawing() {
    //This variable creates a loop
    const animationLoop = requestAnimationFrame(animateLineDrawing);
    //This method clears content from the lasst loop iteration
    c.clearRect(0, 0, 608, 608)
    //this method starts a new path
    c.beginPath();
    //This method moves us to a starting point for our line
    c.moveTo(x1, y1)
    //this method indicates the end point in our line
    c.lineTo(x, y)
    //this method sets the width of our line
    c.lineWidth = 10;
    //this method sets the color of our line
    c.strokeStyle = 'rgba(70, 255, 33, .8)';
    //this method draws everything laid out above
    c.stroke();
    //This condition checks if we have reached the endpoint
    if (x1 <= x2 && y1 <= y2) {
        //this condition adds 10 to the previous end xpoint
        if (x < x2) { x += 10;}
        if (y < y2) { y += 10;}
        //this condition cancels our annimation loop
        //if we've reached our endpoints
        if (x >= x2 && y >= y2) { cancelAnimationFrame(animationLoop);}
    }
    //This condition is similar to the one above
    //This is necessary for the 6,4,2 win condition
    if (x1 <= x2 && y1 >= y2) {
        if (x < x2) { x += 10;}
        if (y > y2) { x -= 10;}
        if (x >= x2 && y <= y2) { cancelAnimationFrame(animationLoop);}
    }
}


//This function clears our canvas after our win line is drawn
function clear() {
    //this line starts our animation loop
    const animationLoop = requestAnimationFrame(clear);
    //This line clears our canvas
    c.clearRect(0, 0, 608, 608);
    //This line stops our animation loop
    cancelAnimationFrame(animationLoop);
}

//This line diallows clicking while the win sound is playing
disableClick();
//This line plays wind sound
audio ('./media/winGame.mp3');
//This line calls our main animation loop
animateLineDrawing();
//This line waits 1 second. Then clears canvas, resets game, and allows clicking again
setTimeout(function () { clear(); resetGame(); }, 1000);
}