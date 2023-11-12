// let a = 20;
// if (a > 10) {
//     console.log("Sayı büyük");
// };

// let a = 5;
// if (a > 10) {
//     console.log("Sayı büyük");
// }else{
//     console.log("Sayı büyük değil");
// };

// let a = 10;
// if (a > 10) {
//     console.log("Sayı büyük");
// } else if(a<10) {
//     console.log("Sayı küçük");
// }else{
//     console.log("Sayılar eşit");
// }

// let a = 5;
// if (a > 10) {
//     console.log("Büyük");
// };
// if (a < 10) {
//     console.log("Küçük");
// };
// if (a == 10) {
//     console.log("Eşit");
// }; //bu şekilde yaparsak gereksiz işlem yapar, üstteki daha ekonomik

// let age = 18;
/*
    0-16: Çocuk
    17-35: Genç
    36-50: Yaşlı
    51-70: Ölmüş ağlayanı yok
    71'den büyükse: No comment
*/

// if (age<=16) {
//     console.log("Çocuk");
// } else if(age<=35) {
//     console.log("Genç");
// } else if(age<=50){
// console.log("Yaşlı");
// } else if(age<=70){
//     console.log("Ölmüş ağlayanı yok");
// } else{
//     console.log("No comment");
// };

// if (age <= 16) {
//     console.log("Çocuk");
// };
// if (age <= 35) {
//     console.log("Genç");
// };
// if (age <= 50) {
//     console.log("Yaşlı");
// } ;
// if (age <= 70) {
//     console.log("Ölmüş ağlayanı yok");
// };
// if (age>70){
//     console.log("No comment");
// };

//Ternary if operator (Üçlü operatör)
// let message;
// let age = 10;

// if (age>=18) {
//     message = "girebilirsiniz.";
// } else{
//     message = "giremezsiniz.";
// };

// message = age >= 18 ? "girebilirsiniz." : "giremezsiniz";
// console.log("Yaşınız " + age + " olduğu için " + message);

/*
    0-16: Çocuk
    17-35: Genç
    36-50: Yaşlı
    51-70: Ölmüş ağlayanı yok
    71'den büyükse: No comment
*/
//Ternary if çözümü:

// let age = 55;
// let result;
// result = age<=16 ? "Çocuk" : 
//             age<=35 ? "Genç" : 
//                 age<=50 ? "Yaşlı" :
//                     age<=70 ? "Ölmüş ağlayanı yok" : "No comment";
// console.log(result);

// alert("Merhaba");
// let message = "Merhaba";
// alert(message);

//Prompt: değer girdirme
// let age;
// age = prompt("Kaç yaşındasınız?");
// console.log(age + " yaşındasınız.");
// console.log(typeof age); //prompt ne girilirse girilsin stringe dönüştürür

//Confirm: Tamam/iptal şeklinde pop-up
// result= confirm("Emin misiniz?");

/* SORU-1: 
let a = 40; 
let b = 60;
let result;   
if(a-b < 30){
    result = "Küçük";
}else{
    result = "Büyük";
};
Bu kodu ternary if ile yazın
// */
// CEVAP:
// let a = 40;
// let b = 60;
// result = a-b<30 ? "Küçük" : "Büyük";
// console.log(result);

/*
Kullanıcıya "JavaScript'in official is mi nedir?" şeklinde bir soru sorup gelen cevap "ECMAscript" ise "Tebrikler, bildiniz!" değil ise "Yanlış cevap! Yeniden deneyiniz!" şeklinde bir cevabın alert ile veren kodu;
a) if...else ile
b) ternary if ile yazınız
*/

let correctAnswer = "ECMAscript";
let userAnswer = prompt("JavaScript'in official is mi nedir?");
let result;
// a)
// if (userAnswer == correctAnswer) {
//     result = "Tebrikler, bildiniz!";
// } else {
//     result = "Yanlış cevap! Yeniden deneyiniz!";
// };
// b)
result = userAnswer == correctAnswer ? "Tebrikler, bildiniz!" : "Yanlış cevap! Yeniden deneyiniz!";

alert(result);
