

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