"use strict";
// function Student (){
//     firstName = "";
//     lastname= "";
//     age = 0;
// };

// let student1 = new Student();
// student1.firstName = "Duygu";
// student1.lastname ="Doğan";
// student1.age = 29;
// console.log(student1);

function Product(productName, productPrice){
    this.productName = productName;
    this.productPrice = productPrice;
}

let p1 = new Product("iPhone 13", 42500);
console.log(p1);
let p2 = new Product("Samsung S22", 32000);
console.log(p2);
let p3 = p1;
console.log(p3);