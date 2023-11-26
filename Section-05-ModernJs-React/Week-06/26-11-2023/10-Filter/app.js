let numbers = [4, 9, 14, 20, 19];
let newNumbers = numbers.map(nextNumber => {
    if(nextNumber >= 10) return nextNumber
});
console.log(numbers);
console.log(newNumbers);

// let newNumbersFilter = numbers.filter(nextNumber =>{
//     if(nextNumber >= 10) return true;
// });

let newNumbersFilter = numbers.filter(nextNumber=>nextNumber>=10)
console.log(newNumbersFilter);
