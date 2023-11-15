let result;
let now;
now = new Date();
result = now;
result = now.getDate(); //günü verir
result = now.getDay(); //day of the week

let newDate = new Date(2023,5,11); //Sun Jun 11 2023 tarihini verir
// console.log(newDate);
result = newDate.getDate(); //pazar günü, ay ve günde 0'dan başladığı için 0 sonucunu verir

result = now.getFullYear(); // bulunduğumuz yılı verir
result = now.getHours();
result = now.getMinutes();
result = now.getMilliseconds();

result = now.getTime();//tarihin (yıl, ay, gün,.. milisaniye) sayısal karşılığını verir.

result = new Date(1900, 0, 1); //tipi 'object', new diyerek oluşturduğumuz her şey object
let year = result.getFullYear() + 1; //1901
let month = result.getMonth();
let day = result.getDate();
result = new Date(year, month, day); // Jan 01 1901



// console.log(result);

// Kaç gün yaşadığımızı bulan kod

let bday = new Date(1994, 1, 16);
let milisecond = now - bday; //çıkan sonuç ms cinsinden geçen süre
let second = milisecond / 1000; //yaşanan sürenin saniye cinsinden karşılığı
let minute = second / 60;
let hour = minute / 60;
let dayCount = hour / 24; 
console.log(dayCount);
console.error(dayCount); //hata şeklinde gösteren komut, hata yapıldığında göstermek için bu şekilde yazdırılabilir
console.warn(dayCount);

//Araştırma ödevi: getTime()'ı 0 olan tarih nedir?