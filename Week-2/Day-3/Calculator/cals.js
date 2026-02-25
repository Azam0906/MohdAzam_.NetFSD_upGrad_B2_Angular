let display = document.getElementById("display");
let numbers = document.querySelectorAll(".number");

numbers.forEach(button => {
    button.addEventListener("click", () => {
        display.value += button.innerText;
    });
});

// Operations
let sum = document.getElementById("sum");
let subtract = document.getElementById("subtract");
let multiply = document.getElementById("multiply");
let divide = document.getElementById("divide");

sum.addEventListener("click", () =>  {
    display.value += "+";
});

subtract.addEventListener("click", () => {
    display.value += "-";
});

multiply.addEventListener("click", () => {
    display.value += "*";
});

/* Clear */
document.getElementById("clear").addEventListener("click", () => {
    display.value = "";
});

/* Delete last digit */
document.getElementById("deleteElement").addEventListener("click", () => {
    display.value = display.value.slice(0, -1);
});

/* Result (using eval) */
document.getElementById("result").addEventListener("click", () => {
    try {
        display.value = eval(display.value);
    } catch {
        display.value = "Error";
    }
});


