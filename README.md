# FaceBookAPI Restful WEB API 

Для сборки потребуется Visual Studio 2019  
После открытия проекта надо поменять APP url на http://localhost:5000/  
FaceBookAPI -> Properties -> Debug -> Profile -> FaceBookApi  
Перед запуском переключить с IIS Express на FaceBookAPI  

# Тестирование с помощью POSTMAN  

Примеры реквестов  

POST  
http://localhost:5000/users/register  
{
  "firstname": "ftest1",
  "lastname": "ltest1",
  "username": "test1",
  "password": "Qwerty123"
}

POST  
http://localhost:5000/users/authenticate  
{
	"username": "test1",
	"password": "Qwerty123"
}

GET  
http://localhost:5000/users/getall  
