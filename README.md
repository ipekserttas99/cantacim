# Çantacım e-Ticaret Sitesi (Mezuniyet Projesi)

ASP.NET kullanarak çanta satışı gerçekleşen bir e-ticaret sitesi yapıldı. Bu e-ticaret sitesinde kullanıcı üyelik bilgilerini, ürün kategorilerini ve ürün bilgilerini tutan SQLite veritabanı kullanıldı. Ürün kategorilerini, bilgilerini düzenleyip silebilecek, yeni kategori ve ürün eklenmesini sağlayacak, kullanıcı ve admin rollerinin listesini görüntülenmesini sağlayacak yani kısacası e-ticaret sitesinin işleyişinden sorumlu Admin eklendi. Giriş, Üye ol, Şifremi unuttum, kullanıcı hesabının onaylanması, kullanıcı oturumunu kapama, onay mailinin gönderilmesi kısımları eklenerek üyelik işlemleri tanımlandı. Dinamik kategori menüsü, ürün detay sayfası, ürün filtrelemesi ve araması eklendi. Sipariş süreci ve kredi kartı entegrasyonu kısımları eklendi. Satın alım sonrası sipariş listesi kısmı eklendi. Tasarımı ile de kullanıcı dostu bir e-ticaret sitesi kuruldu.

## 1. SİTENİN KULLANIMI
### Sitenin navbar- header kısmı;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/giri%C5%9F.png)

### Aşağı kaydırdığımızda home kısmında gösterilen çantalar ve kategoriler geliyor. Sitenin görünümü bu şekilde;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/anasayfa.png)

### Navbar’daki ÜRÜNLER linkine tıklarsak tüm çantalar sayfa başına 3 adet düşecek şekilde gösterilir. Aşağıdaki kontrollerle sayfalar arası geçiş yapılır;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/%C3%BCr%C3%BCnler%20sekmesi.png)

### Kategoriler kısmında herhangi bir kategoriye tıklarsak çantalar filtrelenir ve gösterilir;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/kategoriler.png)

### Herhangi bir çantayı incele dediğimizde ürün detay sayfasına giderek çantanın özelliklerini gösteriyor;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/%C3%BCr%C3%BCn%20detay%20sayfas%C4%B1.png)

### Ürün detay sayfasındayken sepete ekle kısmına tıklarsak giriş yapmadığımız için giriş yap sayfasına yönlendirir;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/giri%C5%9F%20yap%20sayfas%C4%B1.png)

### Üye ol sayfası;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/giri%C5%9F%20yap%20sayfas%C4%B1.png)

### Her üye kaydı bir veritabanına kaydolur ve saklanır. Üye olduktan sonra e-posta kutunuza onay gitmektedir. E-posta kutunuza gelen linke tıklarsanız üyelik işleminiz tamamlanacaktır. Giriş yap ve üye ol kısımlarındaki doldurulması gereken alanları boş geçersek hata verecektir;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/giri%C5%9F%20yap%20validasyonlar.png)
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/%C3%BCye%20ol%20validasonlar.png)

### Giriş yapıldıktan sonra navbar değişecek ve ürünler, siparişlerim kısımları gelecektir. Ayrıca giriş olduğunda kullanıcı adı yazılacak ve çıkış yap butonu gelecektir. Alışverişe devam et tıklanırsa sepettekiler silinmeden siteyi gezmeye devam edilir. Checkout butonuna tıklanırsa ödeme ve kart bilgileri isteyen sayfaya yönlendirilir. Sepetim sayfası;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/sepet.png)

### Ödeme ve Teslimat sayfası;
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/%C3%B6deme%20ve%20teslimat.png)

### Ödeme ve teslimat bilgilerini doldurup kaydet butonuna basıldığında işlemin başarılı olduğunu belirten bir sayfa döner. Siparişlerim sayfasına gidersek aşağıdaki gibi aldığımız ürün bilgilerini, toplam fiyat bilgisini, sipariş durumunu ve ödeme şeklini görürüz.
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/sipari%C5%9Flerim.png)

## 2. ADMİN ROLÜ
### Bu e-ticaret sayfasının üstte anlatıldığı kullanıcı rolü olduğu gibi bir de admin rolü vardır. Admin rolü olarak eklenen kişi sayfada ne değişiklikler yapabilir? 

#### Rol listesinden başka bir admin daha ekleyebilir. Rolleri düzenleyip silebilir. 
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/rol%20listesi.png)
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/rol%20d%C3%BCzenle.png)


#### Veritabanındaki kullanıcıların listesini görüntüleyebilir, kullanıcıyı silebilir, herhangi bir kullanıcıya admin yetkisi verebilir, mailini onayladı olarak değiştirebilir.
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/kullan%C4%B1c%C4%B1%20listesi.png)
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/kullan%C4%B1c%C4%B1%20d%C3%BCzenle.png)

#### Ürün listesini görüntüleyebilir. Ürün ekleyebilir. Var olan ürünü silebilir. İsmini, link kısmında gözüken url’sini, açıklamasını, fiyatını, resmini değiştirebilir. Kategorisini seçebilir. Ana sayfada olup olmamasına izin verebilir. Onay verip, onayı kaldırabilir.
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/admin%20%C3%BCr%C3%BCnleri.png)
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/%C3%BCr%C3%BCn%20d%C3%BCzenle.png)

#### Kategori ekleyip silebilir. Var olan kategorileri düzenleyebilir.
![alt text](https://github.com/ipekserttas99/cantacim/blob/main/%C3%A7antac%C4%B1m/images/kategori%20d%C3%BCzenle.png)



