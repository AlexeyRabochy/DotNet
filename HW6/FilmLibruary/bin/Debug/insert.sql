INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(1, '..\..\..\Pictures\1.jpg', '������� ����', '���', '1999', '����� ��������')

insert into Actor (Id, Name) values (1, '��� �����')
insert into Actor (Id, Name) values (2, '����� ����')
insert into Actor (Id, Name) values (3, '����� ����� ������')

insert into ActorToFilm (Id, ActorId, FilmId) values (1, 1, 1)
insert into ActorToFilm (Id, ActorId, FilmId) values (2, 2, 1)
insert into ActorToFilm (Id, ActorId, FilmId) values (3, 3, 1)


INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(2, '..\..\..\Pictures\2.jpg', '������ ��������', '���', '1993', '������ ��������')

insert into Actor (Id, Name) values (4, '���� �����')
insert into Actor (Id, Name) values (5, '��� �������')
insert into Actor (Id, Name) values (6, '���� �����')

insert into ActorToFilm (Id, ActorId, FilmId) values (4, 4, 2)
insert into ActorToFilm (Id, ActorId, FilmId) values (5, 5, 2)
insert into ActorToFilm (Id, ActorId, FilmId) values (6, 6, 2)

INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(3, '..\..\..\Pictures\3.jpg', '����� �� ��������', '���', '1994', '����� ��������')

insert into Actor (Id, Name) values (7, '��� �������')
insert into Actor (Id, Name) values (8, '������ ������')
insert into Actor (Id, Name) values (9, '��� ������')

insert into ActorToFilm (Id, ActorId, FilmId) values (7, 7, 3)
insert into ActorToFilm (Id, ActorId, FilmId) values (8, 8, 3)
insert into ActorToFilm (Id, ActorId, FilmId) values (9, 9, 3)
	
	
INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(4, '..\..\..\Pictures\4.jpg', '������� ����', '���', '1994', '������ �������')

insert into Actor (Id, Name) values (10, '����� ����')
insert into Actor (Id, Name) values (11, '���� �����')

insert into ActorToFilm (Id, ActorId, FilmId) values (10, 1, 4)
insert into ActorToFilm (Id, ActorId, FilmId) values (11, 10, 4)
insert into ActorToFilm (Id, ActorId, FilmId) values (12, 11, 4)
	
INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(5, '..\..\..\Pictures\5.jpg', '1+1', '�������', '2011', '������ �����, ���� ��������')

insert into Actor (Id, Name) values (12, '������� �����')
insert into Actor (Id, Name) values (13, '���� ��')
insert into Actor (Id, Name) values (14, '��� �� ��')

insert into ActorToFilm (Id, ActorId, FilmId) values (13, 12, 5)
insert into ActorToFilm (Id, ActorId, FilmId) values (14, 13, 5)
insert into ActorToFilm (Id, ActorId, FilmId) values (15, 14, 5)

INSERT INTO Films (Id, Picture, Name, Country, Year, Producer) values 
	(6, '..\..\..\Pictures\6.jpg', '�������� ������ �� ������ ��-�����', '�������', '1896', '����� ������, ��� ������')

	

