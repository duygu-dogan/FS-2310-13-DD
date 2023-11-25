import { arrASC, getArray, arrDESC } from './myModules/sort-array.js';

const randomNumbers = getArray(5);

console.log(randomNumbers);
console.log(arrASC(randomNumbers));
console.log(arrDESC(randomNumbers));

// let stringArray = ["Ece", "Cağdaş", "Melisa", "Furkan", "Baransel"];
// console.log(arrASC(stringArray));
