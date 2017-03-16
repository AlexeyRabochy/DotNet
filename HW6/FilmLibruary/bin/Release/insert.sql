INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(1, '..\..\..\Pictures\1.jpg', 'Зеленая миля', 'США', '1999', 'Фрэнк Дарабонт')

insert into Actor (Id, Name) values (1, 'Том Хэнкс')
insert into Actor (Id, Name) values (2, 'Дэвид Морс')
insert into Actor (Id, Name) values (3, 'Майкл Кларк Дункан')

insert into ActorToFilm (Id, ActorId, FilmId) values (1, 1, 1)
insert into ActorToFilm (Id, ActorId, FilmId) values (2, 2, 1)
insert into ActorToFilm (Id, ActorId, FilmId) values (3, 3, 1)


INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(2, '..\..\..\Pictures\2.jpg', 'Список Шиндлера', 'США', '1993', 'Стивен Спилберг')

insert into Actor (Id, Name) values (4, 'Лиам Нисон')
insert into Actor (Id, Name) values (5, 'Бен Кингсли')
insert into Actor (Id, Name) values (6, 'Рэйф Файнс')

insert into ActorToFilm (Id, ActorId, FilmId) values (4, 4, 2)
insert into ActorToFilm (Id, ActorId, FilmId) values (5, 5, 2)
insert into ActorToFilm (Id, ActorId, FilmId) values (6, 6, 2)

INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(3, '..\..\..\Pictures\3.jpg', 'Побег из Шоушенка', 'США', '1994', 'Фрэнк Дарабонт')

insert into Actor (Id, Name) values (7, 'Тим Роббинс')
insert into Actor (Id, Name) values (8, 'Морган Фриман')
insert into Actor (Id, Name) values (9, 'Боб Гантон')

insert into ActorToFilm (Id, ActorId, FilmId) values (7, 7, 3)
insert into ActorToFilm (Id, ActorId, FilmId) values (8, 8, 3)
insert into ActorToFilm (Id, ActorId, FilmId) values (9, 9, 3)
	
	
INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(4, '..\..\..\Pictures\4.jpg', 'Форрест Гамп', 'США', '1994', 'Роберт Земекис')

insert into Actor (Id, Name) values (10, 'Робин Райт')
insert into Actor (Id, Name) values (11, 'Гэри Синиз')

insert into ActorToFilm (Id, ActorId, FilmId) values (10, 1, 4)
insert into ActorToFilm (Id, ActorId, FilmId) values (11, 10, 4)
insert into ActorToFilm (Id, ActorId, FilmId) values (12, 11, 4)
	
INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(5, '..\..\..\Pictures\5.jpg', '1+1', 'Франция', '2011', 'Оливье Накаш, Эрик Толедано')

insert into Actor (Id, Name) values (12, 'Франсуа Клюзе')
insert into Actor (Id, Name) values (13, 'Омар Си')
insert into Actor (Id, Name) values (14, 'Анн Ле Ни')

insert into ActorToFilm (Id, ActorId, FilmId) values (13, 12, 5)
insert into ActorToFilm (Id, ActorId, FilmId) values (14, 13, 5)
insert into ActorToFilm (Id, ActorId, FilmId) values (15, 14, 5)

INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(6, '..\..\..\Pictures\6.jpg', 'Прибытие поезда на вокзал Ла-Сьота', 'Франция', '1896', 'Огюст Люмьер, Луи Люмьер')

	

