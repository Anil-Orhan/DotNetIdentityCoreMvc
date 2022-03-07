# CoreMvc Hesap Makinesi Projesi
#### Bu bir .Net Core Mvc Projesidir(Eğitim)

## Frontend 
- Bootstrap 3
- JQuery
- JS
## Database
- MSSQL SERVER

## Versiyon ve Paketler
- .Net Core 3.1


![image](https://user-images.githubusercontent.com/61164526/156928892-211ccc0a-ec87-4c18-baf1-1f365e8d42a7.png)


## Kurulum

#### Connection String Tanımlaması 

TomyaTask>appsettings.json

![image](https://user-images.githubusercontent.com/61164526/156929141-dc329407-4c46-43fb-bb9e-027a0a46a33c.png)

ilgili Connection String'in server kısmını kendi MSSQL server adresiniz ile değiştirmeniz yeterlidir.


#### Migration Kurulumu
- Proje çalıştırıladan önce veri tabanı update edilmelidir.
- Projenin içinde bulunan TomyaTask>Migration klasöründe ilgili migration dosyaları mevcuttur.

![image](https://user-images.githubusercontent.com/61164526/156928980-c3e26c9e-bd93-42d4-8208-16812af4cb8d.png)


Package Manager Console üzerinde görselde gösterildiği gibi

```
update-database -Context TomyaDb
```
"update-database -Context TomyaDb" komutu çalıştırıldığında gerekli kurulum sağlanacaktır.





## Kayıt Onaylama

Üye olma işlemini gerçekleştirdikten sonra aşağıdaki görselde görünen onaylama sayfasına yönlendirme sağlanır.
Buradan "Click here to confirm your account" linkine tıklayarak hesabınızı onaylamanız gerekmektedir.
Aksi takdirde giriş yapma yetkisi elde edemezsiniz.

![image](https://user-images.githubusercontent.com/61164526/156929410-31d3ec7f-2a23-4c05-bb89-f3386d6af712.png)


