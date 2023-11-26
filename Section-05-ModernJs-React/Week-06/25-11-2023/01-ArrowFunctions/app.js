function selamVer(){
    console.log("Merhaba, bu klasik bir function");
};


const selamVer2 = () =>{
    console.log("Merhaba, burası bir arrow function");
};

const selamVer3 = (ad) => {
    console.log("Merhaba " + ad)
};

//bu kullanımda kullanıcıya iki sayı göndererek de fonk.u kullanma seçeneği sunuyoruz, num3 sayı 0 olarak tanımlanmazsa nan döner
//default değer verdiğimiz parametre, parametre listesinde sonlarda olmalı aksi halde hata alma ihtimalimiz artar
const sum = (num1, num2, num3=0) => {
    return num1 + num2 + num3;
}

//Tek parametreli bir func. ise parantez kullanmaya gerek yok
const selamVer4 = ad => {
    return console.log("Merhaba " + ad);
};

//Tek satırlık bir arrow func + return ise:
const sum2 = (sayi1, sayi2) => sayi1 + sayi2;

// selamVer();
// selamVer2();
// selamVer3("Duygu");
// console.log(sum(14));
// selamVer4("Duygu");
console.log(sum2(25,3));