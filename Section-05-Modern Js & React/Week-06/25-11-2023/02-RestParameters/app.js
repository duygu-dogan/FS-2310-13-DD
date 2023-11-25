const calculatCircleArea = (r, pi =3) =>{
    return "Circle area: " + r * r * pi;
};

// console.log(calculatCircleArea(5, 3.14));
// console.log(calculatCircleArea(5));
// console.log(calculatCircleArea(5, 3.145683));

//Bu şekildeki fonk. parametre olarak ne gönderilirse gönderilsin onu alır
const calculatCircleArea2 = (...parameters) =>{
    let array = [...parameters];
    let r = array[0];
    let pi = array[1] == undefined ? 3 : array[1];
    return "Circle area: " + r * r* pi;
};
// console.log(calculatCircleArea2(5, 3.14));

//Soru: İçerisine gönderilen sayıları toplayıp sonucu ekrana yazan arrow func.ı hazırlayalım
const getTotal = (...numbers) => {
    let numArr = [...numbers];
    let total =0;
    for (let i = 0; i < numArr.length; i++) {
        total += numArr[i];        
    }
    return total;
}
const basketItemPrices = [135, 500, 900, 250];
// console.log(getTotal(5,6, 55, 66, 44, 22));
console.log(getTotal(...basketItemPrices));