// console.log("Hello, Node.Js");

// let num1 = 50;
// let num2 = 40;
// let num3 = 60;
// let result = (num1 / 2) + num2 - num3;
// console.log(`Sayıların toplamı: ${result}`);

const products = [
    {id:1, name: "IPhone15", price: 89000},
    {id:2, name: "Samsung22", price: 55000},
    {id:3, name: "Xiaomi19", price: 34000},
    {id:4, name: "Nothing 1", price: 21000}
];
let sumCart = 0;
products.forEach(item => {
    sumCart += item.price
});
console.log(`Toplam: ${sumCart}`);