// function randomNumOld(maxNum0){
//     Math.floor(Math.random() * (maxNum0 + 1)) + 1;
//     return;
// }

//0-maxNum arası rastgele sayı üretir
const randomNumber = maxNumber => Math.floor(Math.random() * (maxNumber + 1)) ;

//küçükten büyüğe: ascending
export const arrASC = array => {
    // return array.sort(compareNumericASC);
    return array.sort((a,b) => a -b);
}

// const compareNumericASC = (a, b) => {
//     if (a > b) return 1;
//     if (a == b) return 0;
//     return -1;
// }

export const arrDESC = array => {
    // let result = arrASC(array);
    // return result.reverse();
    return array.sort((a, b) => b-a);
}

export const getArray = count =>{
    const resultArray = [];
    for (let i = 0; i < count; i++) {
        resultArray.push(randomNumber(100));  
    }
    return resultArray;
}

