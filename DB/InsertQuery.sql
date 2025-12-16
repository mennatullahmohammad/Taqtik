USE Taqtik;
GO
INSERT INTO EventType (name) VALUES
('Goal'),
('Assist'),
('Offside'),
('Yellow Card'),
('Red Card'),
('Shot'),
('Shot on Target'),
('Pass'),
('Key Pass'),
('Tackle'),
('Interception'),
('Clearance'),
('Foul'),
('Penalty Awarded'),
('Penalty Missed'),
('Player In'),
('Player Out'),
('Possession Start'),
('Possession End'),
('Corner'),
('Free Kick');
USE Taqtik;
GO

INSERT INTO Competition (name, country)
VALUES ('English Premier League', 'England');
INSERT INTO Season (year)
VALUES (2024);
INSERT INTO CompetitionInstance (
    season_id, competition_id,
    promotion_spots, relegation_spots, number_of_teams
)
VALUES (1, 1, NULL, 3, 20);
INSERT INTO Team (name, country, year_founded) VALUES
('Manchester City','England',1880),
('Arsenal','England',1886),
('Liverpool','England',1892),
('Chelsea','England',1905),
('Manchester United','England',1878),
('Tottenham Hotspur','England',1882),
('Newcastle United','England',1892),
('Aston Villa','England',1874),
('West Ham United','England',1895),
('Brighton','England',1901),
('Brentford','England',1889),
('Fulham','England',1879),
('Crystal Palace','England',1905),
('Wolves','England',1877),
('Everton','England',1878),
('Nottingham Forest','England',1865),
('Bournemouth','England',1899),
('Sheffield United','England',1889),
('Burnley','England',1882),
('Luton Town','England',1885);
INSERT INTO TeamSeason (team_id, season_competition_id)
SELECT team_id, 1 FROM Team;
INSERT INTO Player (name, age, position) VALUES
('Ederson',30,'GK'),
('Kyle Walker',33,'RB'),
('Ruben Dias',26,'CB'),
('John Stones',29,'CB'),
('Nathan Ake',28,'LB'),
('Rodri',27,'CDM'),
('Kevin De Bruyne',32,'CM'),
('Bernardo Silva',29,'CM'),
('Phil Foden',23,'LW'),
('Jack Grealish',28,'LW'),
('Erling Haaland',23,'ST'),
('Julian Alvarez',24,'ST'),
('Matheus Nunes',25,'CM'),
('Josko Gvardiol',22,'CB'),
('Manuel Akanji',28,'CB'),
('Mateo Kovacic',30,'CM'),
('Oscar Bobb',20,'RW'),
('Stefan Ortega',31,'GK');
INSERT INTO Player (name, age, position) VALUES
('David Raya',28,'GK'),
('Ben White',26,'RB'),
('William Saliba',22,'CB'),
('Gabriel Magalhaes',26,'CB'),
('Oleksandr Zinchenko',27,'LB'),
('Declan Rice',25,'CDM'),
('Martin Odegaard',25,'CAM'),
('Kai Havertz',24,'CM'),
('Bukayo Saka',22,'RW'),
('Gabriel Martinelli',22,'LW'),
('Gabriel Jesus',27,'ST'),
('Leandro Trossard',29,'LW'),
('Thomas Partey',30,'CM'),
('Jurrien Timber',22,'RB'),
('Takehiro Tomiyasu',25,'RB'),
('Fabio Vieira',23,'CAM'),
('Eddie Nketiah',24,'ST'),
('Aaron Ramsdale',25,'GK');
INSERT INTO Player (name, age, position) VALUES
('Alisson',31,'GK'),
('Trent Alexander-Arnold',25,'RB'),
('Virgil van Dijk',32,'CB'),
('Ibrahima Konate',24,'CB'),
('Andy Robertson',29,'LB'),
('Alexis Mac Allister',25,'CM'),
('Dominik Szoboszlai',23,'CM'),
('Curtis Jones',22,'CM'),
('Mohamed Salah',31,'RW'),
('Luis Diaz',27,'LW'),
('Darwin Nunez',24,'ST'),
('Diogo Jota',27,'ST'),
('Wataru Endo',30,'CDM'),
('Ryan Gravenberch',21,'CM'),
('Joe Gomez',26,'CB'),
('Harvey Elliott',20,'RW'),
('Cody Gakpo',24,'ST'),
('Caoimhin Kelleher',25,'GK');
INSERT INTO PlayerTeamSeason (player_id, team_season_id)
SELECT
    p.player_id,
    ts.team_season_id
FROM Player p
JOIN TeamSeason ts
ON ts.team_season_id =
    CEILING(CAST(p.player_id AS FLOAT) / 18.0);
INSERT INTO EventType (name) VALUES
('Goal'),
('Assist'),
('Offside'),
('Yellow Card'),
('Red Card'),
('Shot'),
('Shot on Target'),
('Pass'),
('Key Pass'),
('Tackle'),
('Interception'),
('Clearance'),
('Foul'),
('Penalty Awarded'),
('Penalty Missed'),
('Player In'),
('Player Out'),
('Possession Start'),
('Possession End'),
('Corner'),
('Free Kick');
INSERT INTO Users (name, password_hash, role)
VALUES ('system_admin','hashed_pw','admin');
INSERT INTO Referee (name,country,age) VALUES
('Michael Oliver','England',38),
('Anthony Taylor','England',45),
('Paul Tierney','England',43);
INSERT INTO GameWeek (gameweek_id, season_competition_id)
VALUES (1,1),(2,1),(3,1);
INSERT INTO Match
(gameweek_id, season_competition_id, referee_id, Venue, match_date)
VALUES
(1,1,1,'Etihad Stadium','2024-08-10'),
(1,1,2,'Emirates Stadium','2024-08-11'),
(1,1,3,'Anfield','2024-08-12'),
(2,1,1,'Old Trafford','2024-08-17'),
(2,1,2,'Tottenham Stadium','2024-08-18'),
(3,1,3,'Stamford Bridge','2024-08-24');
INSERT INTO MatchTeams VALUES
(1,1,1),(1,3,0),
(2,2,1),(2,6,0),
(3,3,1),(3,4,0),
(4,5,1),(4,1,0),
(5,6,1),(5,2,0),
(6,4,1),(6,7,0);
USe Taqtik;
go
INSERT INTO Event
(match_id, event_type_id, player_id, minute, second, entered_by)
VALUES
-- Match 1
(1, 1, 11, 12, 30, 1), -- Haaland Goal
(1, 2,  8, 12, 35, 1), -- Bernardo Assist
(1, 4,  9, 44, 10, 1), -- Foden Yellow Card

-- Match 2
(2, 1, 22, 55, 15, 1), -- Saka Goal

-- Match 3
(3, 3, 33, 66, 20, 1), -- Offside

-- Match 4
(4, 1, 45, 78, 40, 1), -- Goal

-- Match 5
(5, 4, 50, 70,  0, 1), -- Yellow Card

-- Match 6
(6, 1, 54, 25, 50, 1); -- Goal

INSERT INTO Users (name, password_hash, role)
VALUES
('admin1', 'admin123', 'Admin'),
('admin2', 'admin123', 'Admin'),
('analyst1', 'analyst123', 'Analyst'),
('analyst2', 'analyst123', 'Analyst'),
('entry1', 'entry123', 'DataEntry'),
('entry2', 'entry123', 'DataEntry'),
('entry3', 'entry123', 'DataEntry');

GO