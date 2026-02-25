const marks = [78, 85, 62, 90, 55];

// calculate total using reduce
const calculateTotal = (marksArray) =>
    marksArray.reduce((sum, mark) => sum + mark, 0);

// calculate average
const calculateAverage = (marksArray) =>
    calculateTotal(marksArray) / marksArray.length;

// determine result
const getResult = (average) =>
    average >= 40 ? "PASS" : "FAIL";

// execution
const total = calculateTotal(marks);
const average = calculateAverage(marks);
const result = getResult(average);

console.log(`
Student Marks Analysis
----------------------
Marks   : ${marks.join(", ")}
Total   : ${total}
Average : ${average.toFixed(2)}
Result  : ${result}
`);