"use strict";

//Bir function scope'u içinde let ile tanımlanan değişken, sadece o functionda geçerlidir.

// function print(){
//     let name = "Zeynep Nur Ay";
//     console.log(name);
// }

// if (true) {
//     let price = 45;
//     console.log(price);
// }

// print();

// console.log(price); 

//ES5 öncesinde JS'de değişken tanımlamak için var ve const keywordleri vardı. ES5 ile birlikte let eklendi. 

function print(){
    console.log(name);
    var name = "Zeynep Nur Ay";
}
if (true) {
    var price = 56;
}
print();
console.log(name);
console.log(price); //var ile değişken tanımlandığında let'den farklı olarak, aşağı doğru o kodun tamamında kullanılabilir. Ama şu anda var tercih edilen bir değişken tipi değil