### Описание

Небольшое веб-приложение для создания заказов

Имеющиеся функции:
* Создание заказа
* Просмотр деталей заказа
* Просмотр списка всех заказов

Интерфейс приложения:

![image](https://github.com/kkkuus/DeliveryApp/assets/89841362/be71b5f2-3e3c-4d45-b9f9-24b2e9f509e5)


---

### Запуск проекта

1. Склонировать репозиторий
2. (при необходимости) Восстановить пакеты NuGet:
```
nuget restore versta_test.sln
```
3. (при необходимости) Обновить подключение к БД:
   
   * в файле `appsettings.json` заменить `"ConnectionStrings"`.`"DefaultConnection"` на собственную строку подключения к БД

   * применение миграций `dotnet ef database update`

4. Запустить приложение

---

### Используемые технологии

* ASP.NET Core 8.0
* ASP.NET Core MVC
* Entity Framework
* Microsoft SQL Server


