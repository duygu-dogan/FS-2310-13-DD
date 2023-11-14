//string functions

let courseName = "          Fullstack Web Developer Eğitimi             ";
let result;

result = courseName.toLowerCase();
result = courseName.toLocaleLowerCase(); //türkçe karakter problemini çözüyor
result = courseName.toUpperCase();
result = courseName.toLocaleUpperCase(); //büyük harfte türkçe harf problemini çözemedi, başka bir fonk. ile çözüyoruz

result = courseName.length; //karakter uzunluğu, (fonk. değil, property)
result = courseName[0]; //array içindeki []. karakteri getirir

result = courseName.slice(14,23); //verdiğimiz aralıktaki karakterleri döndürür --> "Developer"; iki parametre verilmesi gerekir

result = courseName.replace("Eğitimi", "Kursu"); //ilk ifadeyi verdiğimiz ifade ile değiştirir
result = courseName.trim(); //baştaki ve sondaki gereksiz boşlukları kaldırır
result = courseName.trimStart();
result = courseName.trimEnd();

result = courseName.indexOf("F", 3); //case sensitive, olmayan bir değer verirsek -1 sonucunu verir, bir ifadenin bulunup bulunmadığını öğrenmek için de kullanılabilir. İkinci verilen değer başlangıç noktası-position --> şuradan itibaren bak





console.log(result);