Merhabalar,
Öncelikle projemi okumaya zaman ayırdığınız için teşekkürler...
Proje konusu basit olduğu için, projeme Dependency Injection kavramını ekleyerek farklılık yaratmak istedim. Bu text dosyasında da adım adım neler yaptığımı açıklamak istedim..

Case'in konusu olan Josephus Problemi adını MS 66-70 yılları arasında Romalılara karşı yapılan Yahudi isyanına katılan ve bunu tarihlendiren tarihçi Flavius ​​Josephus’tan almıştır.

* Metot isimlerinde PascalCase, parametrelerimde ise camelCase kullanmayı tercih ettim.
* SOLID prensiplerinin de değindiği bir konu olan Dependency Injection kavramı, bağımlılığı azaltır. Böylece, bu API'yi başka projeye taşımak veya bu API üzerine yeni eklemeler yapmak bize  daha basit ve esnek bir durum sağlayacak. * Dependency Injection kavramına eklediğim servis klasöründen ve Program.cs içerisinden inceleyebilirsiniz. *** Service'imi Scoped olarak eklemek istedim çünkü AddScoped kullanıldığında;
- Yapılan her request’te nesne tekrar oluşur ve bir request içerisinde sadece bir tane nesne kullanılır.
Projemin tamamını ingilizce yaparak isimlendirmeye önem verdim.
DİP NOT : Controller'ımın Constructor'unda servisimizi tanımlamadan önce oluşturduğumuz client 'static' olmalı !

1) Web API projemi güncel bir teknoloji olan .NET 7 ile oluşturdum.
2) Default Controller'ımı ve onun implemente olduğu sınıfı sildim. Yeni kullanacağım Controller'ım ve Servis klasörü oluşturup, interface ile kodların yer aldığı sınıflarımı klasörüme ekledim.
3) Verilen Case'in çözümünü metotumun içine ekledim ve string mesajı döndürmek istedim. İnterface ile sınıfımı Program.cs içerisinde AddScoped ile ekledim. Kullanacağım controller'ıma Constructor içerisinde bu kodlara erişimimi oluşturdum.
*** Grup sayısı 0 veya negatif değerler verilmesi durumunda uyarı mesajı ekledim.
4) Swagger ile kodlarımı test ettim ve ekran görüntülerini projeme ekledim. Projemi GitHUB'a yüklemeden ve ZIP klasörüne eklemeden önce Debug yerine Release moduna aldım...

Sağlıklı günler, iyi çalışmalar...


Çağlar Hekimci
