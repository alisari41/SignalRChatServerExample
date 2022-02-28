
# SignalR ile Chat Örneği
Bu projede clientlar  arasında gerçek zamanlı mesajlaşma işlemleri yapılabilir. Bir client tüm clientlere mesaj gönderebilir. Grup ekleyebilir. Ekelenen gruba diğer clientlar subsc. olabilir. Gruptakiler arasında mesajlaşma işlemleri gerçekleştirilebilir. 
## Demo

- Önce boş daha hub'a giriş yapmamış iki Client gösterelim
![image](https://user-images.githubusercontent.com/81421228/155906361-d10ce2b0-1def-4bb8-883b-ca44d185dfed.png)

- Bir kullanıcı hub'a subsc. işlemi gerçekleştirdikten sonra diğer clientlere haber gider. İşaretlediğim yer gibi
![image](https://user-images.githubusercontent.com/81421228/155906561-2a063e47-53b1-49a8-b600-f776b3ebf8e5.png)

- Client giriş yaptıktan sonra Oda ekleyebilir. Eğer client oda eklerse kendi direk o odaya otomatik dahil olur. Diğer Clientler eklenen odayı anlık olarak görebilir.
![image](https://user-images.githubusercontent.com/81421228/155906711-4fef09f3-3a44-4ab8-a7d7-cfce4e4e3048.png)

- Hangi odada hangi clientler var onları görebiliriz.
![image](https://user-images.githubusercontent.com/81421228/155906858-78f65575-322c-485b-803d-744e4ecda6dc.png)

- Diğer client'ler istediği odaya subsc. işlemi yapabalir. Example: Fatih kullanıcısını sonradan Yeşil odaya kayıt ettim.
![image](https://user-images.githubusercontent.com/81421228/155906974-e9353aa3-d571-47c7-95e7-fb3ca327253f.png)

- Clientlar arası bire bir mesajlaşma yapılabilir.
![image](https://user-images.githubusercontent.com/81421228/155907044-70ea2c78-1a10-40f9-8720-83cd89cf7ede.png)

- Bir Client tüm clientlere mesaj gönderebilir.
![image](https://user-images.githubusercontent.com/81421228/155907314-97d3e87f-1c27-47a0-88e9-639d1a04acf1.png)

- Grup mesajlaşma sistemi vardır.
![image](https://user-images.githubusercontent.com/81421228/155907382-60d7ba42-de06-4431-b147-6f4c5e7f1cca.png)



  
