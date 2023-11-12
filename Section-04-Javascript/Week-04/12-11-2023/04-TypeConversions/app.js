// 1) toString
let isActive = true;
// alert(typeof isActive);
console.log(isActive, typeof isActive);
let isActiveString = String(isActive);
console.log(isActiveString, typeof isActiveString);
console.log(isActiveString.toUpperCase());

// let price = 37500;
// console.log(price, typeof price);
// let priceString = String(price);
// console.log(priceString, typeof priceString);

let firstName = "Didier";
let lastName = "Drogba";
let fullName = firstName + " " + lastName;
console.log(fullName);

console.log("Ali" + "Veli");
console.log(4 + 9);
console.log("Ali" + 9);
console.log(9 + "Ali");
console.log("10" + 9);
console.log((20+5) + "9");
console.log(20 + 5 + "9");
console.log(20 + "5" + 9);

// 2) Number

console.log("6" / "3");
console.log(Number("65"));
console.log(Number("Bright")); //NaN: not a number
console.log(Number("    756     ")); //görünmeyen karakterler: whitespace
let value1 = null;
let value2 = undefined;
let value3 = true;
let value4 = false;
console.log(Number(value1)); //0
console.log(Number(value2)); //NaN
console.log(Number(value3)); //1
console.log(Number(value4)); //0

// 3) Boolean

console.log(Boolean(1)); //true
console.log(Boolean(0)); //false
console.log(Boolean(-3.3)); //true
console.log(Boolean("Engin")); //true
console.log(Boolean("")); //false
console.log(Boolean(" ")); //true- içinde değer olduğunda herhangi bir ifadeyi true veriyor
console.log(Boolean(null)); //false
console.log(Boolean(undefined)); //false
console.log(Boolean(NaN)); //false
console.log(Boolean("0")); //true
console.log(Boolean(Number("0"))); //false


