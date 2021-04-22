//This variable keeps track of whose turn it is
let activePlayer = 'X';
//This array stores an array of moves.We use this to determin win conditions.
let selectiveSquares = [];
//This function is for placing an x or o in a square
function placeXOrO(squareNumber)  {
    //This condition ensures a square hasn't been selected already
    //The .some() method is used to check each element of selectedsquare array
    //to see if it contains the square number clicked on
If (!selectedSquares.some(element => element.includes(squareNumber))) {
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
    Audio('./media/place.mp3');
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
        if (placeXOrO(pickASuare);
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
    if   (arrayincudes('OX, '1X', '2X'))  { drawWinLine(50, 100, 558, 100)}
    //X 3, 4, 5 condition
    else if (arrayIncludes('3X', '4X, '5X'))  { drawWinLine(50, 304, 558, 304)}
    else if (arrayIncludes('6X', '7X, '8X'))  {drawWinLine(50, 508, 558, 508)}
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
        Audio('./media/tie.mp3');
        //this function sets a .3 second timer before the resetGame is called.
        setTimeout(function () { resetGame(); ), 1000);       
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
