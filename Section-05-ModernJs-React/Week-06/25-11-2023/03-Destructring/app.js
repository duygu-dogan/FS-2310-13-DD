// let fullName = ["Duygu", "Doğan"];
// let firstName = fullName[0];
// let lastName = fullName[1];

//Yukarıdakinin kısa yazımı
// let [firstName, lastName, city] = fullName;
// console.log(fullName, lastName);

// let fullName = "Vladimir İlyiç Lenin";
// let [name1, name2, name3] = fullName.split(" ");
// console.log(name1);
// console.log(name2);
// console.log(name3);

// let userInfo = ["duygudgn", "Duygu", "Doğan", 29, "İstanbul", "Turkey"];
// let [userName, firstName, lastName, age, ...address] = userInfo;
// console.log(userName);
// console.log(firstName);
// console.log(lastName);
// console.log(age);
// console.log(address.join("/"));

let product = {
    productName: "Adidas",
    price: 2750,
    model: "Runner2023",
    color: "White"
};

// let { productName, price, model, color, size} = product;
// console.log(productName);
// console.log(price);
// console.log(model);
// console.log(color);
// console.log(size);

product.price = 4000;
console.log(product.price);
product.color = "blue"; 
console.log(product.color);
product.size= "XL";
console.log(product.size); //Hata vermez, tam anlamıyla oop olmadığı için sorun çıkarmıyor
