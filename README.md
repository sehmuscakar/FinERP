🧱 Proje Mimarisi
Proje, katmanlı mimari kullanılarak yapılandırılmıştır:

FinERP.Core
→ Temel altyapı, servis arayüzleri (IServiceRepository) ve ServiceRepositoryBase gibi soyutlamalar burada bulunur.

FinERP.Business
→ İş katmanıdır. Veri erişimle ilgili mantıksal operasyonlar burada yer alır.

FinERP.DataAccess
→ Veri erişim işlemleri Entity Framework ile burada yapılır.
İçeriği:

Abstract/ → Arayüzler

Concrete/EntityFramework/Context/FinERPContext.cs → EF DbContext

Migrations/ → Veritabanı geçişleri (migrations)

FinERP.Entities
→ Uygulamadaki veri modelleri ve DTO sınıfları burada yer alır.

FinERP.FrontAccounting
→ WPF ile geliştirilmiş kullanıcı arayüzüdür.

XAML sayfaları: Anasayfa, Faturalar, Musteriler, Stoklar, Urunler

NavigationService ve Relay gibi MVVM yardımcı sınıflar da burada yer alır.

⚙️ Öne Çıkan Özellikler
MVVM mimarisi ile yapılandırılmış modern WPF arayüz

Entity Framework ile SQL veritabanı bağlantısı

Katmanlı mimari sayesinde sürdürülebilirlik ve genişletilebilirlik

NavigationService ile sayfalar arası geçiş yönetimi

CRUD işlemleri: Ürün, Stok, Müşteri, Fatura modülleri

🛠️ Kullanılan Teknolojiler
.NET Framework / C#

WPF (XAML)

Entity Framework

MVVM Tasarım Deseni

SQL Server

