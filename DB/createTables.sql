USE Taqtik;
GO

CREATE TABLE Competition (
    competition_id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    country NVARCHAR(50) NOT NULL
);
CREATE TABLE Season (
    season_id INT IDENTITY PRIMARY KEY,
    year INT NOT NULL,
);
CREATE TABLE Team (
    team_id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    country NVARCHAR(50),
    year_founded INT
);
CREATE TABLE CompetitionInstance (
    season_competition_id INT IDENTITY PRIMARY KEY,
    season_id INT NOT NULL,
    competition_id INT NOT NULL,
    promotion_spots INT ,
    relegation_spots INT NOT NULL,
    number_of_teams INT NOT NULL,
    FOREIGN KEY (competition_id) REFERENCES Competition(competition_id),
    FOREIGN KEY (season_id) REFERENCES Season(season_id)

);

CREATE TABLE TeamSeason (
    team_season_id INT IDENTITY PRIMARY KEY,
    team_id INT NOT NULL,
    season_competition_id INT NOT NULL,
    UNIQUE (team_id, season_competition_id),
    FOREIGN KEY (team_id) REFERENCES Team(team_id),
    FOREIGN KEY (season_competition_id) REFERENCES CompetitionInstance(season_competition_id)
);
CREATE TABLE Player (
    player_id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    age INT,
    position NVARCHAR(50)
);
CREATE TABLE PlayerTeamSeason (
    player_team_season_id INT IDENTITY PRIMARY KEY,
    player_id INT NOT NULL,
    team_season_id INT NOT NULL,
    UNIQUE (player_id, team_season_id),
    FOREIGN KEY (player_id) REFERENCES Player(player_id),
    FOREIGN KEY (team_season_id) REFERENCES TeamSeason(team_season_id)
);
CREATE TABLE Referee (
    referee_id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    country NVARCHAR(50),
    age INT
);
CREATE TABLE GameWeek (
    gameweek_id INT NOT NULL,
    season_competition_id INT NOT NULL,
    PRIMARY KEY(gameweek_id,season_competition_id),
    FOREIGN KEY (season_competition_id) REFERENCES CompetitionInstance(season_competition_id)
);
CREATE TABLE Match (
    match_id INT IDENTITY PRIMARY KEY,
    gameweek_id INT NOT NULL,
    season_competition_id INT NOT NULL,
    referee_id INT NOT NULL,
    Venue Varchar(50) ,
    match_date DATETIME NOT NULL,
    FOREIGN KEY (gameweek_id,season_competition_id) REFERENCES GameWeek(gameweek_id,season_competition_id),
    FOREIGN KEY (referee_id) REFERENCES Referee(referee_id)
);
CREATE TABLE MatchTeams (
    match_id INT NOT NULL,
    team_id INT NOT NULL,
    is_home BIT NOT NULL,
    PRIMARY KEY (match_id, team_id),
    FOREIGN KEY (match_id) REFERENCES Match(match_id),
    FOREIGN KEY (team_id) REFERENCES Team(team_id)
);
CREATE TABLE EventType (
    event_type_id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(50) NOT NULL
);
CREATE TABLE Users (
    user_id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    password_hash NVARCHAR(255) NOT NULL,
    role NVARCHAR(20) NOT NULL,
);
CREATE TABLE UserTeamAccess (
    user_id INT NOT NULL,
    team_id INT NOT NULL,
    PRIMARY KEY (user_id, team_id),
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (team_id) REFERENCES Team(team_id)
);
CREATE TABLE Event (
    event_id INT IDENTITY PRIMARY KEY,
    match_id INT NOT NULL,
    event_type_id INT NOT NULL,
    player_id INT NOT NULL,
    minute INT NOT NULL,
    second INT NOT NULL,
    entered_by INT NOT NULL,

    FOREIGN KEY (match_id) REFERENCES Match(match_id),
    FOREIGN KEY (event_type_id) REFERENCES EventType(event_type_id),
    FOREIGN KEY (player_id) REFERENCES Player(player_id),
    FOREIGN KEY (entered_by) REFERENCES Users(user_id)
);