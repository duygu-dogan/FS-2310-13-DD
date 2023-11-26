/* 
- rastgele üretilecek 1-100 arasındaki 10 adet sayıyı kullanarak bir dizi oluşturun.
- oluşturulan dizi içerisindeki tek sayıları tespit edip döndüren bir func.
- oluşturulan dizi içerisindeki çift sayıları tespit edip döndüren bir func.
İçeren bir modul dosyası hazırlayıp app.js içinde kullanın.
*/
import { getResult } from "./myModule.js";

// const array = arrFunc();
// console.log(array);
// console.log(oddNum(array));
// console.log(evenNum(array));

let result = getResult();
console.log("Orijinal hali: " + result.all);
console.log("Tek sayılar: " + result.odd);
console.log("Çift sayılar: " + result.even);