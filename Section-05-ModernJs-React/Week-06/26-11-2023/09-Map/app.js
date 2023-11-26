// let numbers = [4, 9, 14, 20, 19];
// let evenNumbers = numbers.map(nextNum =>{
//    if(nextNum % 2 == 0) return nextNum;
// });
// console.log(numbers);
// console.log(evenNumbers);

let prices = [40, 50, 100, 200, 250];
let newPrices = prices.map(nextPrice => {
    return nextPrice * 1.2
});
console.log(prices);
console.log(newPrices);
