CREATE DATABASE EventDb;
USE EventDb;

CREATE TABLE UserInfo
(
    EmailId VARCHAR(100) PRIMARY KEY,

    UserName VARCHAR(50) NOT NULL
        CHECK (LEN(UserName) BETWEEN 1 AND 50),

    Role VARCHAR(20) NOT NULL
        CHECK (Role IN ('Admin','Participant')),

    Password VARCHAR(20) NOT NULL
        CHECK (LEN(Password) BETWEEN 6 AND 20)
);

CREATE TABLE EventDetails
(
    EventId INT PRIMARY KEY,

    EventName VARCHAR(50) NOT NULL
        CHECK (LEN(EventName) BETWEEN 1 AND 50),

    EventCategory VARCHAR(50) NOT NULL
        CHECK (LEN(EventCategory) BETWEEN 1 AND 50),

    EventDate DATETIME NOT NULL,

    Description VARCHAR(255) NULL,

    Status VARCHAR(10)
        CHECK (Status IN ('Active','In-Active'))
);

CREATE TABLE SpeakersDetails
(
    SpeakerId INT PRIMARY KEY,

    SpeakerName VARCHAR(50) NOT NULL
        CHECK (LEN(SpeakerName) BETWEEN 1 AND 50)
);

CREATE TABLE SessionInfo
(
    SessionId INT PRIMARY KEY,

    EventId INT NOT NULL,

    SessionTitle VARCHAR(50) NOT NULL
        CHECK (LEN(SessionTitle) BETWEEN 1 AND 50),

    SpeakerId INT NOT NULL,

    Description VARCHAR(255),

    SessionStart DATETIME NOT NULL,

    SessionEnd DATETIME NOT NULL,

    SessionUrl VARCHAR(255),

    CONSTRAINT FK_Event
        FOREIGN KEY (EventId)
        REFERENCES EventDetails(EventId),

    CONSTRAINT FK_Speaker
        FOREIGN KEY (SpeakerId)
        REFERENCES SpeakersDetails(SpeakerId)
);

CREATE TABLE ParticipantEventDetails
(
    Id INT PRIMARY KEY,

    ParticipantEmailId VARCHAR(100) NOT NULL,

    EventId INT NOT NULL,

    SessionId INT NOT NULL,

    IsAttended BIT
        CHECK (IsAttended IN (0,1)),

    CONSTRAINT FK_User
        FOREIGN KEY (ParticipantEmailId)
        REFERENCES UserInfo(EmailId),

    CONSTRAINT FK_EventDetails
        FOREIGN KEY (EventId)
        REFERENCES EventDetails(EventId),

    CONSTRAINT FK_Session
        FOREIGN KEY (SessionId)
        REFERENCES SessionInfo(SessionId)
);

INSERT INTO UserInfo VALUES
('admin@gmail.com','AdminUser','Admin','admin123'),
('user1@gmail.com','Rahul','Participant','rahul123'),
('user2@gmail.com','Amit','Participant','amit123');

INSERT INTO EventDetails VALUES
(1,'Tech Conference','Technology','2026-04-15','Annual Tech Event','Active'),
(2,'AI Summit','Artificial Intelligence','2026-05-10','AI Discussions','Active');

INSERT INTO SpeakersDetails VALUES
(1,'Dr. John'),
(2,'Mr. Smith');

INSERT INTO SessionInfo VALUES
(1,1,'Future of AI',1,'AI trends discussion','2026-04-15 10:00','2026-04-15 11:00','www.ai.com'),
(2,2,'Machine Learning Basics',2,'ML Introduction','2026-05-10 09:00','2026-05-10 10:00','www.ml.com');

INSERT INTO ParticipantEventDetails VALUES
(1,'user1@gmail.com',1,1,1),
(2,'user2@gmail.com',2,2,0);

SELECT * FROM UserInfo;

SELECT * FROM EventDetails;

SELECT
S.SessionTitle, E.EventName, S.SessionStart, S.SessionEnd
FROM SessionInfo S
JOIN EventDetails E
ON S.EventId = E.EventId;

SELECT U.UserName, E.EventName, S.SessionTitle, P.IsAttended
FROM ParticipantEventDetails P
JOIN UserInfo U
ON P.ParticipantEmailId = U.EmailId
JOIN EventDetails E
ON P.EventId = E.EventId
JOIN SessionInfo S
ON P.SessionId = S.SessionId;