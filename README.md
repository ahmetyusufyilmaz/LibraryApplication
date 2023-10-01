# LibraryApplication

Projede .Net Core MVC, EF ve MS SQL kullanışmıştır. Proje dosyalarında Migration'lar mevcuttur.  `update-database` komutu ile local veritabanınıza ilgili veritabanını ve tabloları ekleyebilirsiniz.

`"ConnectionStrings": {
    "LibraryDbContext": "Server=.;Database=LibraryDb;Trusted_Connection=true;TrustServerCertificate=True"
  },`

Veritabanı tablo yapısı: </br>

![sql](https://github.com/ahmetyusufyilmaz/LibraryApplication/raw/master/wwwroot/images/9.PNG)

Üst menü her sayfada sabittir ve 3 tane buton bulunmaktadır. Kişiler butonuyla kayıtlı kişiler listesine, Kitaplar butonuyla kayıtlı kitaplar listesinde, ödünç alınanlar butonuyla ise bir kişiye ödünç verilmiş kitapların olduğu listenin sayfasına gidilmektedir.

![Menü](https://github.com/ahmetyusufyilmaz/LibraryApplication/raw/master/wwwroot/images/0.PNG)
</br>


Örnek: Kitaplar sayfası</br>

Kitap Adı, Yazarı, Kapak resmi ve o an kütüphanede olup olmadığını gösteren uygunluk checkbox'ı bulunmaktadır. Eğer ödünç verme işlemi yapıldıysa kutu boş, eğer kitap uygun durumdaysa tik atılmış şekilde görünmektedir. </br>
Yeni bir ödünç verme işlemi yapılacağı zaman, ödünç alacak kişi sistemde zaten kayırlı mı yoksa ilk defa mı kitap alacağı sorulur. Eğer kayıtlıysa "kayıtlı kişiye ödünç ver" butonuyla ilgili sayfaya gidilir. Eğer ilk defa kitap alacaksa "yeni kişiye ödünç ver"
butonuyla önce kişi ekleme sayfasına yönlendirilir, kişi bilgileri girilip kaydedildikten sonra sonra otomatik olarak ödünç verme sayfasına yönlendirilir ve işlemi kaydedilir.
</br>
</br>
![Kitaplar Sayfası](https://github.com/ahmetyusufyilmaz/LibraryApplication/raw/master/wwwroot/images/1.PNG)

</br>
Örnek- Ödünç verme işlemlerinin tutulduğu tablo </br>

![borrowedbooks](https://github.com/ahmetyusufyilmaz/LibraryApplication/raw/master/wwwroot/images/8.PNG)
</br>


Örnek: Ödünç Verilenler sayfası</br>

![Ödünç Sayfası](https://github.com/ahmetyusufyilmaz/LibraryApplication/raw/master/wwwroot/images/7.PNG)

Teslim alındı butonuna tıklandığında kitaplar sayfasındaki listede ilgili kitabın checkbox'ı tekrar tik atılmış olarak güncellenir.


Her sayfanın kendi yeni kişi/kitap/işlem oluşturma butonu mevcuttur. Bu butona tıkalndığında yeni oluşturma sayfası açılmaktadır.

Örnek: Yeni Kitap Oluşturma formu </br>
![Yeni kitap Sayfası](https://github.com/ahmetyusufyilmaz/LibraryApplication/raw/master/wwwroot/images/2.PNG)

</br>
Örnek: Yeni Ödünç İşlemi Oluşturma formu 

![Yeni ödünç işlemi Sayfası](https://github.com/ahmetyusufyilmaz/LibraryApplication/raw/master/wwwroot/images/4.PNG)
</br>
Ödünç verilecek kişi ve kitap dropdown listten seçilir. Tarih otomatik olarak o anki tarih ve saat olarak atanır. Sadece geri getireleceği tarihi seçilir.


