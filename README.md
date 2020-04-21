
#### Основные предметно-значимые сущности:
1) Бронирование;
2) Клиент;
3) Номер;
4) Администратор.

#### Информационные потребности пользователей: 
1) авторизация в системе;
2) забронировать номер;
3) выбрать все забронированные номера на определённую дату;
4) изменить информацию о номере.

#### Основные предметно-значимые атрибуты сущностей:
##### 1) Бронирование:
*	расположение номера PK FK NOT NULL;
*	дата и время бронирования PK NOT NULL DATETIME;
*	дата и время заезда PK NOT NULL DATETIME;
*	серия и номер паспорта клиента FK NOT NULL;
*	дата и время отъезда NOT NULL DATETIME;
*	сумма заказа (включает аренду номера за весь забронированные период, возможны скидки) NOT NULL MONEY.
##### 2) Клиент:
* серия и номер паспорта клиента PK NOT NULL INT;
*	ФИО NOT NULL VARCHAR.
##### 3)	Номер (комната):
*	расположение номера (№) PK NOT NULL INT;
*	количество мест NOT NULL INT;
*	стоимость за сутки NOT NULL MONEY;
*	дополнительная информация VARCHAR.
##### *	логин PK NOT NULL VARCHAR;
*	пароль NOT NULL VARCHAR.

#### Ограничения целостности данных:
*	дата и время * – дата и время;
*	сумма заказа – в рублях;
*	серия и номер паспорта – целое десятизначное число;
*	расположение номера – целое число;
*	количество мест – целое число;
*	стоимость за сутки – в рублях;
*	дополнительная информация – строка;
*	логин – латинские буквы с цифрами или без, до 8 символов включительно;
*	пароль – латинские буквы с цифрами или без, от 8 до 16 символов.

#### Свойства связей:
1) Номер участвует в Бронирование – бинарная связь, один к одному NO NULLS;
2) Администратор заполняет Бронирование – бинарная связь, один ко многим NO NULLS;
3) Клиент заполняет Бронирование – бинарная связь, один ко многим NO NULLS.
