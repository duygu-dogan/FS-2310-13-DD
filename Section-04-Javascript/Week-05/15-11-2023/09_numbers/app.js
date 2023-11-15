let result;

result = parseInt(10.3); //tamsayıya çevirir -yuvarlamaz!
result = parseInt("10.8agb") //string de versek noktadan sonrasına farklı değer de versek ondalık kısmı siliyor
result = parseFloat("101.56aa"); //101.56, ondalıklı sayıya çevirir

let num = 10.37853;
result = parseFloat(num.toFixed(4)); // toFixed: ondalık kısımda kaç basamak olacağını belirler ancak string sonuç verir
result = num.toFixed(3); //Yuvarlayarak getirdiği için: 10.379
result = num.toPrecision(4); //toplam basamak sayısı (ondalık öncesi + sonrası)

result = Math.round(2.5); //round fonk. için Math sınıfını kullanıyoruz, tam sayı kalana kadar yuvarlar --> 3
result = Math.ceil(2.1); //yukarı yuvarlar --> 3
result = Math.floor(2.9); //aşağı yuvarlar --> 2

result = Math.pow(5, 2); //üs alma işlemi, ilk parametre taban, ikinci üs
result = Math.sqrt(25); //karekök alma

result = Math.abs(-10); //mutlak değer
result = Math.min(12, 48, 79, 5); // min. bulur --> 5
result = Math.max(12, 48, 79, 5); //--> 79

result = Math.random(); //0-1 arası ondalık sayısı yüksek rastgele sayı
result = parseInt(Math.random() * 100); //1-100 arası rastgele tam sayı üretmek için



console.log(result);