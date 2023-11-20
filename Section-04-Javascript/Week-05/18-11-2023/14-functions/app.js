"use strict";
// function selamVer() {
//     console.log("Merhaba, hoş geldiniz!");
// };

// selamVer(); //yazdırmak için fonksiyonu çağırıyoruz

// function selamVer2(message) {
//        console.log(message)
// };

// selamVer2("Merhaba, nasılsın?");

//w/o parameter
// function today() {
//     let result = new Date();
//     return result;
// }
// let bugün = today();
// console.log(bugün);

//with parameter

// function calculateAge(yearOfBirth){
//     // let today = new Date();
//     // let year = today.getFullYear();
//     // let result = year - yearOfBirth;
//     // return result;

//     return new Date().getFullYear() - yearOfBirth;
// }

// console.log(calculateAge(1975));

/*
    Kadınlar için emeklilik yaşı 60
    Erkekler için emeklilik yaşı 65'tir.
    Buna göre doğum yılı, cinsiyeti ve adı verilen bir kişinin emekli olmasına kaç yıl kaldığını şu örnekteki gibi bildiren function'ı hazırlayınız.
    Sayın 'Fettah Can', emekli olmanıza 7 yıl kalmıştır.
*/

// function calculateAge(yearOfBirth){
//     let today = new Date();
//     let year = today.getFullYear();
//     let result = year - yearOfBirth;
//     return result;
// }

// function calculatePension(yearOfBirth, gender, fullName) {
//     let age = calculateAge(yearOfBirth);
//     let diff = gender == "Kadın" ? 60 - age : 65-age;
//     // let result = "Sayın " + fullName + " emekli olmanıza" + diff + " yıl kalmıştır."
//     // let result = 'Sayın "' + fullName + '" emekli olmanıza' + diff + ' yıl kalmıştır.'
//     // let result = 'Sayın \'' + fullName + '\' emekli olmanıza' + diff + ' yıl kalmıştır.' //ters slash ile normalde kullanamayacağımız özel karakterleri kullanabiliyoruz.
//     let result = `Sayın '${fullName}' emekli olmanıza ${diff} yıl kalmıştır.`; //template literal kullanımı
//     return result;
// }
// console.log(calculatePension(1995, "Kadın", "Sezen Aksu"));
// console.log(calculateAge(1975, "Erkek", "Engin Niyazi Ergül"));

// Verilen bir dörtgenin kenar uzunluklarını alıp dörtgenin alanını ve çevresini hesaplayıp geri döndüren bir function.

// function calculate(short,long) {
//     let area = short * long;
//     let env = (short + long) *2;
//     let result = [area, env];
//     return result; //sadece sonuncuyu döndürür
// }
// console.log(calculate(4,6));

// SORU: Çalıştırıldığında bize "Yazı" ya da "Tura" şeklinde sonuç veren fonsiyonu hazırlayınız.

// function yaziTura(){
//     // let arr = ["Yazı", "Tura"];
//     // let result = arr[(Math.floor(Math.random() * 2))];

//     let random = math.random();
//     let result = random >= 0.5 ? "Yazı" : "Tura";
//     return result;
// }
// console.log(yaziTura());

//SORU: Kendisine gönderilen sayının 'TAM BÖLENLERİNİ' bulup döndüren fonsiyonu hazırlayınız.

// function tamBolenler(sayi) {
//     let arr = [];
//     for (let i = 1; i <= sayi; i++) {
//         if (sayi % i == 0) {
//             arr.push(i);
//         }
//     }
//     return arr;
// }
// console.log(tamBolenler(8));


//ÖDEV: 1-50 arasındaki asal sayıları bulup döndüren fonksiyonu yazınız.

function getPrimeNumbers() {
    let primeNumbers = [];
    for (let i = 2; i <= 50; i++) {
        for (let j = 2; j <= i; j++) {
            if (i % j == 0 & i != j) {
                break;
            } else if (i % j == 0 & i == j) {

                primeNumbers.push(i);
            }
        }
    }
    console.log(primeNumbers);
}
    getPrimeNumbers();

//Verilen min-max aralığında (min-max dahil) rasgele bir sayı bulma
// function randomInt(min, max) {
//     return Math.floor(Math.random() * (max - min + 1) + min);
// }
// console.log(randomInt(10, 15));
