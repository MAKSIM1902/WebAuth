# WebAuth

Небольшое MVC приложение с аутентификацией и авторизацией
Аутентифицированные пользователи видят таблицу (таблица с идентификатором, именем, мылом, датой регистрации, датой последнего логина, статусом) с пользователями. 
Таблица  содержит чек-боксы для множественного выделения, в заголовке колонки чек-бокс "выделить все/снять выделение". 
Над таблицей *тулбар* с действиями: Block (кнопка с текстом), Unblock (иконка), Delete (иконка). 
Пользователь может удалить или заблокировать себя — при этом сразу должен быть разлогинен. 
Если кто-то другой блокирует или удаляет пользователя, 
то при любом следующем действии пользователь переправляется на страницу логина.