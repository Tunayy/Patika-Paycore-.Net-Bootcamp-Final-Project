# Patika-Paycore-.Net-Bootcamp-Final-Project

Bu proje .Net Core 5 ile oluşturulmuş bir WebApi projesidir.
Projede bir e ticaret altyapısı kurgulanmış olup senaryoları swagger yardımı ile test edilmiştir
Kullanıcının ilk önce bir account yaratması ardından o accountu ile login olması gerekmektedir ve bu login işlemi sonucunda bir Jwt token üretilmiş olacaktır
Kullanıcı bu tokeni swagger üzerindeki Authorize kısmına kopyalayıp yapıştırıp authorize olması gerekmektedir aksi taktirde methodlara ulaşamaz 
Kullanıcı login olduktan sonra Account adı altında teklif verdiği ürünlerin durumunu görebilir ve diğer detaylarını veya kendi ürünlerine gelen teklifleri ve kimin verdiğini ya da ürünlerine gelen teklifleri kabul edebilir veya reddedebilir
Kullanıcı login olduktan sonra Category adı altında tüm kategorileri listeleyebilir veya yeni bir kategori ekleyebilir aynı zamanda var olan bir kategoriyi düzenleyebilir
Kullanıcı login olduktan sonra Product adı altında seçtiği kategoriye göre ürünleri listeleyebilir ya da yeni bir ürün ekleyebilir, bir ürünü direkt satın alabilir ya da bir ürün için teklif verebilir

(Kullanıcı login olup token ile authorize olduktan sonra authorize olan kişinin gerekli bilgileri auth db'sinde saklanmaktadır gerektiği yerlerde kullanılmak adına)



Databse

![Account Table](https://user-images.githubusercontent.com/56853506/191697939-f4745763-875c-4ad3-935f-b971ea143272.PNG)
![Category Table](https://user-images.githubusercontent.com/56853506/191697942-3c4adf99-2bad-4f7d-a6df-c66fc45feba5.PNG)
![Product Table](https://user-images.githubusercontent.com/56853506/191697944-a1bf2b70-52d1-4b54-81db-b3a1caf9ccbb.PNG)


Methods
![Account Methods](https://user-images.githubusercontent.com/56853506/191698118-944aab73-e088-42e6-bf1a-80d0d424d275.PNG)
![Category Methods](https://user-images.githubusercontent.com/56853506/191698123-7c28c301-8733-46bd-aaae-1808be173061.PNG)
![Product Methods](https://user-images.githubusercontent.com/56853506/191698127-49faef0d-31c9-48ca-9f67-92b5b55d316a.PNG)
