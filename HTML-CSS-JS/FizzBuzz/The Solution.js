for(let index = 1; index <= 100; index++) {
    if(index % 3 !== 0 && index % 5 !== 0) {
        console.log(index);
    }
    else if(index % 3 !== 0 && index % 5 === 0) {
        console.log("Buzz");
    }
    else if(index % 3 === 0 && index % 5 !== 0) {
        console.log("Fizz");
    }
    else {
        console.log("FizzBuzz");
    }
}