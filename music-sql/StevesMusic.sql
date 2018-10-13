/*
select  a.Title,
a.AlbumLength,
a.Label AS AlbumLabel,
ar.ArtistName,
ar.YearEstablished,
g.Label
from Album a
join Artist ar on a.ArtistId = ar.ArtistId
join Genre g On a .Genreid = g.Genreid;

Select * 
from Song s
join Album al ON al.Albumid = s.Albumid
join Artist ar ON ar.Artistid = s.Artistid
join Genre g ON g.Genreid = s.Genreid;


/*
2
Using the INSERT statement, add one of your favorite artists to the Artist table.
insert into Artist
(ArtistName, YearEstablished)
Values("Henry Rollins Band", 1988);

update Artist
set ArtistName = "Rollins Band"
where Artistid = 28
*/
/*
3
Using the INSERT statement, add one, or more, albums by your artist to the Album table.
insert into Album
(Title, ReleaseDate, AlbumLength, Label, ArtistId, Genreid)
Values("Life Time", 1987, 6407, "Texas Hotel", 28, 3)
select * from Album
update Album
set Genreid = 9
where Albumid = 23;
*/

/*
4
Using the INSERT statement, add some songs that are on that album to the Song table.
insert into Song
(Title, SongLength, ReleaseDate, Genreid, Artistid, Albumid)
Values("What am I doing here?",  321, 1987, 9, 28, 23);

insert into Song
(Title, SongLength, ReleaseDate, Genreid, Artistid,Albumid)
Values("Burned Beyond Recognition",  256, 1987, 9, 28, 23);
*/
/*
5
Write a SELECT query that provides the song titles, album title, and artist name for all of the data 
you just entered in. Use the LEFT JOIN keyword sequence to connect the tables, and the 
WHERE keyword to filter the results to the album and artist you added.
select * from Album

select ar.ArtistName, al.Title as AlbumTitle, s.Title AS SongTitle
from Artist ar
left Join Album al on ar.ArtistId = al.ArtistId
join Song s on ar.ArtistId = s.ArtistId
where ar.ArtistName = "Rollins Band"
order by ar.ArtistName



/* Class examples:
SELECT a.Title, s.Title AS SongTitle FROM Album a LEFT JOIN Song s ON s.AlbumId = a.AlbumId;
SELECT a.Title, s.Title FROM Song s LEFT JOIN Album a ON s.AlbumId = a.AlbumId;

select  a.Title,
a.AlbumLength,
a.Label AS AlbumLabel,
ar.ArtistName,
ar.YearEstablished,
g.Label
from Album a
join Artist ar on a.ArtistId = ar.ArtistId
join Genre g On a.Genreid = g.Genreid;


select 
s.title,
a.title,
ar.name,
from Album a
Left join Song s on 


--which genre has the most albums assigned
Select g.Label, COUNT(al.AlbumId) AS AlbumCount
From Genre g
Join Album al ON al.GenreId = g.GenreId
Group by g.Label
Order by AlbumCount Desc
limit 1;
select * from Genre


select al.Title,
		Max(al.AlbumLength)
from Album al
*/

/* 6
Write a SELECT statement to display how many songs exist for each album. 
You'll need to use the COUNT() function and the GROUP BY keyword sequence.
*
select * from Album
select * from Song
select al.Title, Count(s.AlbumId) AS SongCount 
from Album al
Join Song s on al.AlbumId = s.AlbumId
Group by al.Title
*/
/* 7
Write a SELECT statement to display how many songs exist for each artist. 
You'll need to use the COUNT() function and the GROUP BY keyword sequence.

select * from Artist
select * from Song
select ar.ArtistName, Count(s.ArtistId) AS SongCount 
from Artist ar
Join Song s on ar.ArtistId = s.ArtistId
Group by ar.ArtistName
*/
/*
8
Write a SELECT statement to display how many songs exist for each genre. 
You'll need to use the COUNT() function and the GROUP BY keyword sequence.

select * from Genre
select * from Song
select g.Label,  g.GenreId, Count(s.GenreId) AS SongCount 
from Genre g
Join Song s on g.GenreId = s.GenreId
Group by g.GenreId
*/
/*
9
Using MAX() function, write a select statement to find the album with the longest duration. 
The result should display the album title and the duration.

select * from Album
select al.Title,
Max(al.AlbumLength)
from Album al
*/
/*
10
Using MAX() function, write a select statement to find the song with the longest duration. 
The result should display the song title and the duration.

select * from Song
select s.Title, al.Title,
Max(s.SongLength)
from Song s
join Album al on s.AlbumId = al.AlbumId
*/
/* 
11
Modify the previous query to also display the title of the album.
see above
*/

