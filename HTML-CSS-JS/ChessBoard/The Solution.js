
/**
 * The main function.
 * The function gets the desired number of rows and columns of the grid, 
 * performs a validation on them, and then generates the grid.
 * 
 * @author Hristifor Sotirovski
 */
function func() {

    /*
        Taking the number of rows and columns. m = rows, n = columns, 
        and performing a validation on them. Must be natural numbers.
    */
    let goodInput = false;                                                                      
    let m, n;
    while(!goodInput) {
        m = prompt("Enter the number of rows");
        const regex = /^[1-9]\d*$/; // Regular expression for positive integer. i.e a natural number.
        if(regex.test(m)) {
            m = parseInt(m);
            goodInput = true;
        }
        else {
            goodInput = false;
            const msg = "You should enter a positive integer.\n OK - to continue, Cancel - to exit?";
            let toContinue = confirm(msg);                                                                              
            if(!toContinue) {
                return;
            }
        }                       
    }

    goodInput = false;
    while(!goodInput) {
        n = prompt("Enter the number of columns");
        const regex = /^[1-9]\d*$/;
        if(regex.test(n)) {
            n = parseInt(n);
            goodInput = true;
        }
        else {
            goodInput = false;
            const msg = "You should enter a positive integer.\n OK - to continue, Cancel - to exit?";
            let toContinue = confirm(msg);
            if(!toContinue) {
                return;
            }
        }
    }

    // Generating the grid
    let c = "_";
    let grid = "";
    for(let i = 1; i <= m; i++) {
        for(let j = 1; j <= n; j++) {
            grid += c;
            c = change(c);
        }
        if(n % 2 == 0) {
            c = change(c);
        }
        grid += "\n";
    }

    console.log(grid);
    alert("The result is in developer console.");
    return;


}


/**
 * Changing the character: if the current is "#" returns "_", and vice-versa.
 * 
 * @param {character} c - The character in which makes the grid ("_", or "#")
 *  
 * @returns {character} - if c === "_" then the returned is "#", and vice-versa.
 * 
 * @author Hristifor Sotirovski 
 */
function change(c) {
    if(c === "_") {
        return "#";
    }
    if(c === "#") {
        return "_";
    }
}


func();