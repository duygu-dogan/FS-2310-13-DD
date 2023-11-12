# Javascript Syntax(Söz Dizimi)
* Javascript'te komut oluşturabilmek için yazdığımız kod cümlelerine ifade(statement) denir.
* İfadeler birbirinden (;) işareti ile ayrılır.
* Ancak Js'te ifadelerin sonuna (;) işareti koymak ZORUNLU DEĞİLDİR!
* Her ne kadar zorunlu değilse de ifadelerin sonuna mutlaka (;) işareti koymaya dikkat edin!
* [ECMAScript Automatic Semicolumn Insertion detaylı bilgi](https://tc39.es/ecma262/multipage/ecmascript-language-lexical-grammar.html#sec-automatic-semicolon-insertion)
* Tanımlayıcıların İsimlendirilmesi ile İlgili Hususlar:
    * Tanımlayıcı(değişken, fonksiyon vb) adları _ , "$" ve harf ile başlayabilir. Yani _ ve $ hariç özel karakter ya da rakamla başlayamaz.
    * Tanımlayıcı adları küçük/BÜYÜK harf duyarlıdır!
    * İSİMLENDİRME YAPARKEN TÜRKÇE KARAKTER KULLANMAYIN!
    * Tanımlayıcı İsimlendirme Teknikleri:
        * Camel Case:
        En çok kullanılan isimlendirme tekniklerinden biridir. Sözcüklerin ilk harfi büyük, geri kalanlar küçük yazılır. İki kullanım şekli vardır:
            * Upper Camel Case: Pascal Case de denir. Bu yöntemde gerçekten de sözcüklerin ilk harfi büyük, geri kalanlar küçüktür. Ör: FirstName, DogumTarihi, GirisSarti, IseBaslamaTarihi
            * Lower Camel Case: Genellikler Camel Case dendiğinde, akla bu gelir. İlk sözcük tamamen küçük harflerle yazılır. Geri kalan sözcükler Upper Camel Case kuralı ile yazılır. firstName, dogumTarihi, girisSarti, iseBaslamaTarihi
        * Snake Case:
        Sözcüklerin birbirinden _ işareti ile ayrılarak yazıldığı tekniktir. Üç kullanım şekli vardır:
            * Upper Snake Case: FIRST_NAME, DOGUM_TARIHI, GIRIS_SAATI, ISE_BASLAMA_TARIHI
            * Lower Snake Case: first_name, dogum_tarihi, giris_saati, ise_baslama_tarihi
            * Screaming Snake Case: First_Name, Dogum_Tarihi, Giris_Saati, Ise_Baslama_Tarihi
    * Java Script'te İsimlendirme Teknikleri
        * Değişkenler:
            * Büyük küçük harf duyarlı
            * camelCase tekniği kullanılır
            * Değişken, içerdiği değeri tanımlayacak şekilde bir isme sahip olmalıdır.
            * Mantıksal(boolean) değişkenlere isim verirken is, has gibi ifadelerle başlamasına dikkat edilmelidir.
            * Mümkün olduğu kadar İngilizce kavramlarla isimlendirme yapılmalıdır.
        * Fonksiyonlar: 
            * Büyük küçük harf duyarlı
            * camelCase tekniği kullanılır.
            * Fonksiyonlara isim verirken get, make, apply gibi emir kipi içeren ifadelerle başlanmalıdır.

