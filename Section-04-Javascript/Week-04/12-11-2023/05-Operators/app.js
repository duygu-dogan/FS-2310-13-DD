// +,-,*,/
// + ayrıca metin birleştirme için kullanılır
// = -> atama operatörü

let x;
// x = 45;

// let sayi1 = 10;
// let sayi2 = 3;

// let sonuc;

// sonuc = sayi1 / sayi2;

// sonuc = sayi1 % sayi2; // % operatörü mod almak için kullanılır

// console.log(sonuc);

// console.log(2**2); //4 // çift * üs alma
// console.log(2**5);
// console.log(25**2);
// console.log(16 ** (1/2)); //karekök için özel bir operatör yok

// let counter = 0;
// console.log("Counter: " + counter);
// counter = counter + 1;
// console.log("Counter: " + counter);
// counter++;
// console.log("Counter: " + counter);
// counter--;
// console.log("Counter: " + counter);

// let counter = 10;
// // console.log(counter++); //10 (counter'ı console'a yazdır, sonra değerini 1 artır, iki işlem var)

// // console.log(counter); //11 (değeri artırılan değişken yazıldı)

// // console.log(++counter); //12 (öne yazılırsa ekrana yazdırmadan işlemi yapar)

// console.log(counter++ + counter-- + ++counter + --counter); // 10 + 11 + 11 + 10 = 42

// let sayi1 = 20;
// let sayi2 = 30;

// console.log(sayi1 > sayi2); // karşılaştırma operatörleri logic bir işlem, doğruysa true, değilse false --> false
// console.log(sayi1 >= sayi2);
// console.log(sayi1 == sayi2);
// console.log(sayi1 != sayi2);


console.log("a" > "z"); // false
console.log("a" < "z"); // true
console.log("ilkbahar" > "İlkakşam"); // true --> sözlük sırasına göre - ASCII tablosuna bakıyor
console.log("a" > "Z"); //true

console.log("Ali" == 23); //false
console.log("33" == 33); //true
console.log("33" === 33); //false --> tipleri de karşılaştırmak için üç eşittir/sıkı eşitlik kontrolü

// let value1 = 0;
// console.log(Boolean(value1)); // false

// let value2 = "0";
// console.log(Boolean(value2)); //true

let value2 = "0";
console.log(Boolean(Number(value2))); //false

console.log(value1 == value2); // true











