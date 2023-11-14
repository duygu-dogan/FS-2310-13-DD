// Döngü: While ve For

//WHILE

// let a=1;
// while (a <= 10) {
//     console.log(a);
//     a++;
// };

//1-10 arasındaki çift sayıları console'a yazdır

// let i = 1;
// while (i <= 10) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }
//     i++;
// };

//SORU:
//1-50 arasındaki 4'ün katı olan sayıların adedini bulup konsola yazdırın

// let i = 1;
// let counter = 0;
// while (i <= 50) {
//     if (i % 4 == 0) {
//         counter++;
//     }
//     i++;
// };
// console.log("1'le 50 arasındaki sayı adedi: " + counter);

//Girilecek 3 adet sayıyı toplayıp console'a yazıdırın.

// let i = 1;
// let num;
// let total = 0;
// while (i <= 3) {
//     num = Number(prompt("Lütfen sayıyı giriniz:"))
//     total += num;
//     i++;
// }
// console.log(total);

// Kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp console'a yazan kodu yazınız. Not: Kullanıcı Exit yazarsa uygulama sona ersin.

// let i = 1;
// let num;
// let total = 0;
// while (true) {
//     num = (prompt("Lütfen " + i + ". sayıyı giriniz: (Çıkmak için 'Exit'!)"));
//     if (num.toLocaleLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
//     i++;
// }

// console.log("Girdiğiniz " + (i - 1) + " adet sayının toplamı: " + total);
//'exit' yazıldığında i artırıldığı için, console'a 1 fazlasını yazdırır. Çözümler; i'yi en başta 0 tanımlamak & prompt'u i+1 yapmak; döngüden çıkınca i--; yukarıdaki gibi yazdırırken 1 eksiğini yazdırmak

//for döngüsü
// let count = Number(prompt("Lütfen bir sayı gir: "))
// for (let i = 0; i <= count; i++) {
//     console.log(i);
// }

//1-10 arasındaki çift sayılar
// for (let i = 1; i <= 10; i++) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }
// }

//10'a kadar çift sayılar / başka bir yöntem
// for (let i = 0; i <= 10; i += 2) {
//     console.log(i);
// }

//1-10 arası tek sayılar-continue ile yapış;
// for (let i = 1; i <= 10; i++) {
//      if (i % 2 == 0) {
//         continue;
//      }
//      console.log(i);
// }

// Kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp console'a yazan kodu yazınız. Not: Kullanıcı Exit yazarsa uygulama sona ersin. Not-2: For kullanın.

// let num;
// let total = 0;
// for (let i = 0; i == 0;) {
//     num = prompt("Lütfen sayı giriniz: ");
//     if (num.toLocaleLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
// }
// console.log(total);

/*1-20 arasındaki sayıları şu şekilde yazdıran kodu hazırlayınız: 
1) tek sayı
2) çift sayı
...
*/

for (let i = 1; i <= 20; i++) {
    if (i % 2 == 1) {
        console.log("Tek Sayı: " + i);
    } else {
        console.log("Çift Sayı: " + i);
    }
}
