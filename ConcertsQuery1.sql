CREATE TABLE Concert (
	concertId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	artist varchar(255) NOT NULL,
	venue varchar(255) NOT NULL,
	city varchar(255) NOT NULL,
	concert_date datetime NOT NULL,
	attended bit NULL,
	rating int check (rating between 1 and 5) NULL
)

INSERT INTO Concert (artist, venue, city, concert_date, attended, rating)
VALUES 
('Laundry Day', 'The Garage', 'London', '2026-05-14', 1, 5),
('Renee Rapp', 'OVO Arena', 'London', '2026-03-19', 1, 5),
('Conan Gray', 'O2 Arena', 'London', '2026-05-12', 1, 5),
('Ruel', 'Electric Brixton', 'London', '2026-10-10', 0, null),
('SZA', 'Madison Square Garden', 'New York', '2026-05-10', 0, null);

DROP TABLE Concert;

Select * FROM Concert;
WHERE attended = 0;

