# Game Simulator Project

![content](https://user-images.githubusercontent.com/33182036/108071387-bb8d8d00-7076-11eb-9392-c869ceb355c8.jpg)

- Bu projede oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule edeceğiz.

- Oyun satışı yapılabilecek satış ortamını simule edeceğiz.(Yapılan satışlar oyuncu ile ilişkilendirilecektir. Oyuncu parametre olarak metotta yer alacaktır.)

- Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule edeceğiz.
 
- Satışlarda kampanya entegrasyonunu simule edeceğiz. 

## Dosyalar
 
> Projede düzeni sağlamak amacıyla üç klasör yer almaktadır.

_**Abstract :** Bu klasörde soyut class'lar yer almaktadır. Yani interface'ler. Interface’lerin yazım amacı, bir projenin bir class’ındaki kullanılması gereken metotları bize söyleyen ve onları otomatik oluşturan bir yapıdır._

:open_file_folder: Abstract
   - :page_facing_up: [ICampaignService.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Abstract/ICampaignService.cs)
   - :page_facing_up: [IEntity.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Abstract/IEntity.cs)
   - :page_facing_up: [IGamerService.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Abstract/IGamerService.cs)
   - :page_facing_up: [ISalesService.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Abstract/ISalesService.cs)
   - :page_facing_up: [IUserValidationService.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Abstract/IUserValidationService.cs)


_**Concrete :** Bu klasörde somut class'lar yer almaktadır._ 

:open_file_folder: Concrete
   - :page_facing_up: [CampaignManager.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Concrete/CampaignManager.cs)
   - :page_facing_up: [GamerManager.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Concrete/GamerManager.cs)
   - :page_facing_up: [NewEStateUserValidationManager.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Concrete/NewEStateUserValidationManager.cs)
   - :page_facing_up: [SalesManager.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Concrete/SalesManager.cs)
   - :page_facing_up: [UserValidationManager.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Concrete/UserValidationManager.cs)


_**Entities :** Bu klasörde projede yer alan varlıklar yer almaktadır._

:open_file_folder: Entities
   - :page_facing_up: [Campaign.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Entities/Campaign.cs)
   - :page_facing_up: [Game.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Entities/Game.cs)
   - :page_facing_up: [Gamer.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Entities/Gamer.cs)
   - :page_facing_up: [Sales.cs](https://github.com/fatmacafri/GameSimulator/blob/master/GameSimulator/Entities/Sales.cs)

## Output

![output](https://user-images.githubusercontent.com/33182036/108097923-d15d7b00-7093-11eb-956a-a8f8d180baf2.png)

## Yapılacak Güncellemeler

- [ ] Proje geliştirilerek müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapılacaktır.
 
