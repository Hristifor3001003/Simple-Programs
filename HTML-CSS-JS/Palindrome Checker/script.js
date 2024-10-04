const checkButton = document.getElementById("check-btn");
const textInput = document.getElementById("text-input");
const resultDiv = document.getElementById("result");

checkButton.addEventListener("click", response);

function checkWord(word) {

    word = word.replace(/[^0-9a-zA-Z]/g, "").toLowerCase();

    for(let index = 0; index <= Math.floor((word.length - 1) / 2); index++) {
        if(word[index] !== word[word.length - (index + 1)]) {
            return false;
        }
    }

    return true;
}

function response() {
    let word = textInput.value;

    if(word === null || word.length === 0) {
        alert("Please input a value");
    }

    if(checkWord(word)) {
        resultDiv.innerHTML = `<span style="font-weight: bold;">${word}</span> is a palindrome.`;
    }
    else {
        resultDiv.innerHTML = `<span style="font-weight: bold;">${word}</span> is not a palindrome.`;
    }

    textInput.value = "";
}