# DiscordBot
Дискорд бот для Path of exile выводящий сведения о текущей цене предмета

Команда:
<b>!price {Item name}</b> - где <b>ItemName</b> название предмета, цену которого необходимо узнать


Для получения информации используется Poe.Ninja API


## Начало работы
Чтобы начать работать с ботом откройте терминал в удобной папке и пропишите
```c#
git clone https://github.com/C0Rs1K/DiscordBot
```
Далее вам нужно добавить токен бота (создать можно [тут](https://discord.com/developers/applications))
используя user-secrets
```c#
dotnet user-secrets set "discordtoken" "ваштокен"
```
Или используя appsettings.json, заменив My token на ваш токен.

После чего запустите приложение командой 
```c#
dotnet run
```
