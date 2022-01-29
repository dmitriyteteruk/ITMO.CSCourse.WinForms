## Приложение Windows Forms для работы с БД
Для запуска приложения по работе с БД на ПК должна быть устновлена MS SQL Server и SQL Server Management Studio. 
Вам необходимо предварительно выполнить следующие действия:
1. Скопировать код приложения.
- Для этого скачайте [Zip-архив по ссылке](https://download-directory.github.io/?url=https%3A%2F%2Fgithub.com%2Fdmitriyteteruk%2FITMO.CSCourse.WinForms%2Ftree%2Fmaster%2FITMO.CSCourse.WF-SQL%2F). 
- Разархивируйте его в любой папке на вашем ПК. 
- В Visual Studio откройте корневую папку приложения **ITMO.CSCourse.WF-SQL**. 
2. В приложении SQL Server Management Studio выполнить скрипт [**CreateDB Gifts, Add Table Gifts, Add Values.sql**](https://github.com/dmitriyteteruk/ITMO.CSCourse.WinForms/blob/master/ITMO.CSCourse.WF-SQL/CreateDB%20Gifts%2C%20Add%20Table%20Gifts%2C%20Add%20Values.sql). Он также доступен в разархивированной папке.
Скрипт создает базу данных Gifts, добавляет в нее таблицу Gifts, добавляет несколько строк данных в таблицу.
3. В Solution Explorer открыть файл **ITMO.CSCourse.WF-SQL.csproj** и в меню Build выбрать пункт **Build ITMO.CSCourse.WF-SQL.csproj**. После удачной компиляции нажмите F5 для запуска.

В результате работе работы приложения вы должны увидеть следующее окно. 
Для добавления данных заполните поля и нажмите кнопку "Добавить".
Для удаления данных выделите строку целиком и нажмите кнопку "Удалить".
Для обновления данных выделите строку целиком, затем измените данные в поле слева и нажмите кнопку "Обновить".

![image](https://user-images.githubusercontent.com/34028526/151665988-91e80322-b615-4bf4-97c0-23ec681b6a00.png)
