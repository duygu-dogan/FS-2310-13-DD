// Döngü: While ve For

//WHILE

// let a=1;
// while (a <= 10) {
//     console.log(a);
//     a++;
// };

//1-10 arasındaki çift sayıları console'a yazdır

// let i = 1;
// while (i <= 10) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }
//     i++;
// };

//SORU:
//1-50 arasındaki 4'ün katı olan sayıların adedini bulup konsola yazdırın

let i = 1;
let counter = 0;
while (i <= 50) {
    if (i % 4 == 0) {
        counter++;
    }
    i++;
};
console.log(counter);