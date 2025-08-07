# 🧾 MvcSiparisApi

Bu proje, modern ASP.NET Core teknolojisiyle geliştirilmiş bir **Sipariş Yönetim Sistemi**'dir.  
Ayrıca, .NET Framework ile hazırlanmış bir entegrasyon projesiyle birlikte çalışabilir yapıdadır.

---

## 🏗️ Proje Yapısı

Solution içeriği iki temel projeden oluşur:

### 1️⃣ **Web (ASP.NET Core MVC)**  
> Siparişlerin listelenmesini ve kullanıcı dostu bir arayüzden eklenmesini sağlar.

- 🧍‍♂️ Sipariş formu (yeni sipariş ekleme)
- 📋 Sipariş listeleme ekranı
- 🔁 Web API ile haberleşme (`HttpClient`)

### 2️⃣ **Api (ASP.NET Core Web API)**  
> Sipariş verilerini dış sistemlerle paylaşmak için kullanılır.

- `GET /api/tumSiparisler` → Tüm siparişleri listeler  
- `POST /api/siparisEkle` → Yeni sipariş ekler

---

## 🔌 Entegrasyon Projesi: [SiparisEntegrasyonu](https://github.com/muratanrisever/SiparisEntegrasyonu)

> Ayrı bir repository'de barındırılan bu proje, `MvcSiparisApi` projesiyle entegre çalışır.

- .NET Framework 4.8 ile yazılmış bir **Console App**’tir.
- Saatte bir çalışacak şekilde **Windows Task Scheduler** ile yapılandırılır.
- `MvcSiparisApi` içindeki API'den verileri çekerek lokal veritabanına işler.
- Tarih bilgisi değiştirilmeden sadece yeni gelen siparişler eklenir.
- Bu sayede 'Siparisler' tablosu sürekli güncel tutulur.

---

## 🧪 Kullanılan Teknolojiler

| Katman | Teknoloji |
|--------|-----------|
| Backend API | ASP.NET Core Web API |
| Web UI | ASP.NET Core MVC |
| Database | SQL Server (EF Core) |
| Entegrasyon | .NET Framework 4.8 Console App |
| Görev Zamanlayıcı | Windows Task Scheduler |

---

## ⚙️ Kurulum Talimatları

### Gereksinimler:
- Visual Studio (2022+)
- .NET 6 SDK
- SQL Server (2019+)
- .NET Framework 4.8 (Console App için)

### Adımlar:
1. `MvcSiparisApi` solution'ını açın.
2. `Web` ve `Api` projelerini **Multiple Startup Projects** olarak ayarlayın.
3. `Package Manager Console` üzerinden `update-database` komutunu çalıştırarak veritabanını oluşturun.
4. Web arayüzünden sipariş ekleyin veya Postman ile API’yi test edin.(Swagger da aktif şekilde çalışıyor.)
5. Entegrasyon projesini (console app) ilgili zamanlayıcı ile yapılandırın.(Destek için iletişime geçebilirsiniz.)

---

## 📸 Ekran Görüntüleri

- ✔️ Sipariş giriş formu
  
  <img width="1700" height="459" alt="siparisEkle" src="https://github.com/user-attachments/assets/c94ac8fb-7e5d-47d7-833c-deb778cf467c" />
- 📄 Sipariş listesi ekranı
  
  <img width="1612" height="437" alt="liste" src="https://github.com/user-attachments/assets/eda82a4d-a237-4fb7-b274-5d07e1744cb6" />

- 🖥️ Entegrasyon log ekranı
  
<img width="979" height="77" alt="entegrasyon" src="https://github.com/user-attachments/assets/452e2a13-31a8-4651-bc3d-7617da6d8b17" />

---

## 📌 Yol Haritası

- [x] API ile sipariş CRUD işlemleri
- [x] MVC arayüz
- [x] Entegrasyon Console App (link yukarıda)
- [ ] JWT auth sistemi (planlanıyor)
- [ ] Frontend güncellemesi (React/Angular)

---

## 🤝 Katkı

Bu proje bireysel bir geliştirme çalışmasıdır.  
Pull request'ler ve katkılar memnuniyetle karşılanır. 🎯

---

## 📬 İletişim

**Geliştirici:** Murat Tanrısever  
📧 info@murattanrisever.com  
🌐 [www.murattanrisever.com](https://www.murattanrisever.com)

---

## 🔗 Diğer Projelerim

- 🔌 **[SiparisEntegrasyonu](https://github.com/muratanrisever/SiparisEntegrasyonu)** – .NET Framework Console App ile API'den sipariş entegrasyonu

---

## 🧠 Lisans

Bu proje [MIT Lisansı](LICENSE) ile lisanslanmıştır.

---
