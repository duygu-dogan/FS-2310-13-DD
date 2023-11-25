let array = [];

// const randomNumber = maxNumber => Math.floor(Math.random() * (maxNumber + 1));

export const getResult = () =>{
    let number;
    const allNumbers = [];
    const oddNumbers = [];
    const evenNumbers = [];
    for (let i = 0; i <= 10; i++) {
       number = Math.ceil(Math.random() * 100);
       allNumbers.push(number);
       if (number % 2 == 1){
        oddNumbers.push(number)
       }else {
        evenNumbers.push(number);
       };
    }
    let result = {
        all: allNumbers,
        odd: oddNumbers,
        even: evenNumbers
    }
    return result;
}




// export const arrFunc = () => {
//     // for (let i = 0; i <= 10; i++) {
//     //     array.push(randomNumber(100));
//     // }
//     for (let i = 1; i <= 10; i++) {
//         array.push(Math.ceil(Math.random()* 100));
//     }
//     return array;
// };

// export const oddNum = () => {
//     let oddNumArr = [];
//     // for (let i = 0; i < array.length; i++) {
//     //     if(array[i] % 2 == 1){
//     //         oddNumArr.push(array[i]);
//     //     }
//     // }
//     for (const i in array) {
//         if(array[i] % 2 == 1) oddNumArr.push(array[i]);
//     }
//     return oddNumArr;
// }

// export const evenNum = () => {
//     let evenNumArr = [];
//     // for (let i = 0; i < array.length; i++) {
//     //     if (array[i] % 2 == 0) {
//     //         evenNumArr.push(array[i]);
//     //     }
//     // }
//     for (const num of array) {
//         if(num % 2 == 0) evenNumArr.push(num)
//     }
//     return evenNumArr;
// }