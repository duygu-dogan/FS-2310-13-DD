//JSON: js object notation
"use strict";

// let student1 = ["Zeynep Nur", "Ay", 28, "Kadın"];
// let student2 = ["Çağdaş", "Taş", 28, "Erkek"];
// let student3 = ["Furkan", "Gültekin", 20, "Erkek"];

// let students = [student1, student2, student3];
// console.log(students);

// for (let i = 0; i < students.length; i++) {
//     console.log(students[i][0] + " " + students[i][2]);
// }

// let student1 = {
//     firstName:"Zeynep Nur", //property-value
//     lastName:"Ay",
//     age:28,
//     gender:"Kadın"
// };
// //yukarıdaki student1 değişkeni bir OBJECT'tir. firstName, lastName, age ve gender ise bu objenin özellikleri/property'sidir.

// console.log(student1.firstName);
// console.log(student1.gender + " " + student1.age);

// let student2 = {
//     firstName: "Mehmet Emir",
//     lastName: "Sürmeli",
//     age: 21,
//     gender: "Erkek"
// };

// let student3 = {
//     firstName: "Didier",
//     lastName: "Drogba",
//     age: 45,
//     gender: "Erkek"
// };

// let students = [student1, student2, student3];
// let totalAge = 0;
// let studentCount = students.length;
// for (let i = 0; i < studentCount; i++) {
//     console.log(students[i].firstName + "-" + students[i].gender);
//     totalAge += students[i].age;
// };
// let average = totalAge / studentCount;
// console.log("sınıfın yaş ortalaması: " + average.toFixed(2));

/* İçerisinde Ahmet, Mehmet, Yeşim değerlerinin olduğu bir dizi tanımlayın. Ayrıca yine içerisinde İnşaat Mühendisliği, Yazılım Mühendisliği ve Mimarlık değerlerinin olduğu bir başka dizi daha tanımlayın. Sonra içinde name ve department bilgilerinin yer aldığı 3 adet student object'i şu şekilde oluşturun: 
Üç öğrenciye rastgele bölüm atansın ve örnek olarak şu şekilde nesneler oluşsun:
{
    name: "Ahmet",
    department: "Yazılım Mühendisliği"
}
*/

let studentNames = ["Ahmet", "Mehmet", "Yeşim"];
let departments = ["İnşaat Mühendisliği", "Yazılım Mühendisliği", "Mimarlık"];
let students = [];
var arr = [];
while (arr.length < 3) {
    console.log("test");
    let n = Math.floor(Math.random() * departments.length);
    if (arr.indexOf(n) == -1) arr.push(n);
}
for (let i = 0; i < studentNames.length; i++) {
    let student = { name: studentNames[i], department: departments[arr[i]] };
    students.push(student);
}
console.log(students);










