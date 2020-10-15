/*insert into Users (username, password) values('gcox', 'p@ssw0rd');*/
/*select * from Users;*/

CREATE TABLE ServiceDetail(
   ID        INTEGER  NOT NULL PRIMARY KEY 
  ,FirstName VARCHAR(15) NOT NULL
  ,LastName  VARCHAR(20) NOT NULL
  ,Date      DATE  NOT NULL
  ,Duties    VARCHAR(20) NOT NULL
  ,Service   INT  NOT NULL
  ,UserID    VARCHAR(20) NOT NULL
);
INSERT INTO ServiceDetail(ID,FirstName,LastName,Date,Duties,Service,UserID) VALUES (1,'Roy','Lilly','1/1/2020','Head Usher',1,'rlilly');
INSERT INTO ServiceDetail(ID,FirstName,LastName,Date,Duties,Service,UserID) VALUES (2,'Sean','Dunbar','1/1/2020','Counting Deacon',1,'sdunbar');
INSERT INTO ServiceDetail(ID,FirstName,LastName,Date,Duties,Service,UserID) VALUES (3,'Garitt','Cox','1/1/2020','Counting Usher',1,'gcox');