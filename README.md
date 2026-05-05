#  Modbus TCP Test ve Kontrol Arayüzü (WinForms)

Bu depo, endüstriyel haberleşme cihazlarını (PLC, Simülatör vb.) test etmek amacıyla C# Windows Forms kullanılarak geliştirilmiş asenkron bir kontrol arayüzüdür. Geliştiricilerin sahadaki Modbus cihazlarına hızlıca paket gönderip yanıtları analiz etmesi için tasarlanmıştır.

>  **BAĞIMLILIK UYARISI:**
> Bu arayüzün haberleşme altyapısı, özel olarak geliştirilmiş **Modbus TCP Çekirdek Kütüphanesi** üzerinde çalışmaktadır. Arayüzü derleyebilmek için lütfen aşağıdaki kütüphaneyi indirip projenize referans (`.dll`) olarak ekleyiniz.
>  **[Modbus TCP Core Library Reposuna Git](https://github.com/Abdullah-Tunahan-Karakus/ModbusTcpLibrary)**

---

##  Ekran Görüntüsü

![WinForms Test Ekranı]<img width="845" height="406" alt="formekrantesttcp" src="https://github.com/user-attachments/assets/a0b28f3a-aff5-49bc-bcdc-cb502e649b01" />

![Simülasyon Uygulaması Test Ekranı]<img width="406" height="551" alt="SımulasyonTcptestForm" src="https://github.com/user-attachments/assets/98543197-ba58-4691-906a-32da945f0482" />



---

##  Özellikler
* **Asenkron Mimari (`async/await`):** Okuma/yazma işlemleri sırasında arayüz donmaz.
* **Canlı Veri Okuma (FC 03):** Belirtilen adreslerden anlık register değerlerini çeker.
* **Tekli Yazma (FC 06):** Cihazdaki spesifik bir adrese tekil değer ataması yapar.
* **Toplu Veri Gönderimi (FC 16):** Virgülle ayrılmış birden fazla değeri (Örn: `500, 150, 5`) tek bir Modbus paketiyle ardışık adreslere yazar.
* **Sistem Logları:** Tüm ağ trafiğini ve hataları takip etmeyi sağlayan entegre konsol ekranı.

---

##  Geliştirici
**Abdullah Tunahan Karakuş**  
*Bilgisayar Mühendisi* | *Endüstriyel Haberleşme & Yazılım Mimarileri*
