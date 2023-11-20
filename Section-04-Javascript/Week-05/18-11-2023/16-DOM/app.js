/*
    DOM: Document Object Model
*/

//1) Single Element (element with ID)
// let result;

//getElementById

// result = document.getElementById("task-list");
// result = document.getElementById("title");
// result.style.backgroundColor="red";
// result.style.color = "white";
// result.style.padding = "10px";
// // result.innerText= "Full Stack Programlama";
// result.innerHTML="<span style = 'color:yellow'>Full Stack</span> Programlama";

//querySelector
//Not: querySelector, dokümanın en üstünden başlyarak ilk karşılaştığı elemanı bulup getirir.

// result = document.querySelector("#title");
// result = document.querySelector(".card-title"); //aynı isimli iki class varsa sadece ilkini döndürür
// result = document.querySelector("li");
// console.log(result);

// 2) Multi Elements

// getElementsByClassName

// let result;
// result = document.getElementsByClassName("card-title");
// result = document.querySelector("li"); //Birazdan tümünü seçecek querySelectorAll'ı öğreneceğiz.
// result = document.getElementsByClassName("task"); //class name içinde 'task'barından tüm elementler

//getElementsByTagName
// result = document.getElementsByTagName("li"); 

//querySelectorAll
// result = document.querySelectorAll(".task"); //getElementsByClassName ile aynı sonucu verir ama collection name'i farklıdır.

// result = document.querySelectorAll("#task-list-2 .task") //id'si task olan ul'nin içindeki task class'ına sahip li'leri döndürür.

// console.log(result);

//Araştırma Ödevi: HTMLCollection ile NodeList arasındaki fark ve benzerlikleri araştırın.

// 3) Traversing Elements

let result;
// let taskList = document.getElementById("task-list");
// result = taskList.children;

// let body = document.querySelector("body");
// console.log(body);
// result = body.children;
// result = body.children[3];
// result = body.firstElementChild;
// result = body.lastElementChild;

// result = document.getElementById("title");
// result = result.parentElement.parentElement.parentElement; //html'i verir. Bir üst element olmadığı için bir daha parentElement dersek null verir. böyle bir durumda if == null ise şöyle yap diye kontrol mekanizması kurabiliriz.

result = document.getElementById("task-list");
result = result.firstElementChild;
result = result.nextElementSibling.nextElementSibling//Görev3
result = result.previousElementSibling; //Görev2
result = result.previousElementSibling.previousElementSibling; //Görev1


console.log(result);