create table Project
(
PID int NOT NULL,
title varchar(144) NOT NULL,
startdate date NOT NULL,
enddate date,
status varchar(30) NOT NULL,
budget varchar(10) NOT NULL,
description varchar(144) NOT NULL,
c_username varchar(30) NOT NULL,
m_username varchar(30) NOT NULL,
primary key (PID, c_username, m_username),
foreign key (m_username) references Manager,
foreign key (c_username) references Customer,
CONSTRAINT check_status
CHECK(status IN('Development', 'Testing', 'Live', 'Complete', 'Shutdown'))
)

insert into Project values(1, 'Attention: Database', '2021-01-01', NULL, 'development', '$10,000',	'Video game', 'Bob', 'swu')
insert into Project values(2, 'Essential Database Smartphone App', '2021-01-02', NULL,	'development',	'$200,000',	'All in one application', 'Anna', 'swu')
insert into Project values(3,	'Database Adventures', '2020-02-06', '2021-04-15', 'live', '$5,200', 'VRMMO', 'Bob', 'nilesh')
insert into Project values(4,	'Database Expert Interview', '2019-04-10',	'2020-06-06',	'complete',	'$30',	'Interview with university students',	'Dave',	'swu')
insert into Project values(4,	'Database Expert Interview',	'2019-04-10',	'2020-06-06',	'complete',	'$30',	'Interview with university students',	'Dave',	'nilesh')
insert into Project values(5,	'COMPX223 Project',	'2020-03-01',	NULL, 'development', '$0',	'What youre doing now',	'cpilbrow',	'swu')
insert into Project values(6,	'Database Iphone App',	'2019-04-25',	'2020-08-24',	'complete',	'$123,000',	'The essential database app ported to iPhone', 'Anna',	'swu')
insert into Project values(6,	'Database Iphone App',	'2019-04-25',	'2020-08-24',	'complete',	'$123,000',	'The essential database app ported to iPhone', 'Anna', 'nilesh')
insert into Project values(7,	'Database May Not Exist!',	'2020-06-01', NULL, 'testing',	'$999,999',	'Unknown',	'Clint', 'nilesh')
insert into Project values(8,	'The Philosophy Of Database',	'2019-09-26',	'2020-12-27',	'testing',	'$1,000,000',	'We have no idea what this is but the client is paying heaps for it',	'Emma',	'nilesh')
insert into Project values(9,	'Warning: Database',	'2018-12-25',	'2019-01-04',	'shutdown',	'$100',	'Video game',	'Bob',	'swu')

create table Customer
(
c_username varchar(30) NOT NULL,
password varchar(10) NOT NULL,
name varchar(30) NOT NULL,
email varchar(30) NOT NULL,
phone varchar(144),
address varchar(144),
bankaccount bigint,
primary key (c_username)
)

insert into Customer values('cpilbrow',	'Q!e3R$5tY^',	'Colin Pilbrow',	'cpilbrow@waikato.ac.nz', NULL,	'220 Seddul Bahr Road, Akatarawa, Upper Hutt',	8588268673)
insert into Customer values('anna',	'password',	'Anna Smith',	'annasmith@gmail.com',	'755-2099',	'42 Ngaio Street, Macandrew Bay, Dunedin',	8524546400912)
insert into Customer values('bob',	'123456',	'Bob Johnson',	'bobby@gmail.com',	'634-5789', NULL, 10266563210016)
insert into Customer values('clint',	'picture1',	'Clint Brown',	'browner@hotmail.com',	'867-5309',	'131 Forres Street, Aramoho, Wanganui',	684915015503483)
insert into Customer values('dave',	'qwerty',	'Dave Jones',	'dj123@students.waikato.ac.nz',	'0118 999 881 99 9119 7253',	NULL,	419534544)
insert into Customer values('emma',	'abc123',	'Emma Miller',	'emabc123@yahoo.com',	'273-9164',	'168 Seddon Road, Waikato Hospital, Hamilton',	329906149290)

create table Manager
(
m_username varchar(30) NOT NULL,
password varchar(10) NOT NULL,
name varchar(30) NOT NULL,
dob date,
salary varchar(10),
phone varchar(10),
address varchar(144),
primary key (m_username)
)

insert into Manager values('swu',	'uws',	'Shaoqun Wu',	NULL,	NULL,	'052-4782',	'The University of Waikato, Te Whare Wananga o Waikato, Gate 1, Knighton Road')
insert into Manager values('nilesh',	'million2',	'Nilesh Kanji', NULL, NULL,		'053-5047',	'The University of Waikato, Te Whare Wananga o Waikato, Gate 1, Knighton Road')
insert into Manager values('admin',	'admin',	'Admin Admin', NULL, NULL,	'051-3096',	'1 Admin Road, Admin, Admin')

create table Programmer
(
p_username varchar(30) NOT NULL,
password varchar(10) NOT NULL,
name varchar(30) NOT NULL,
dob date,
salary varchar(10),
phone varchar(10),
address varchar(144),
primary key (p_username)
)

insert into programmer values('ElisesPieces',	'abc123',	'Elise Barlow',	'2001-01-24',	'$58,000',	'035-5879',	'50  Everton Terrace, Wilton,  Wellington')
insert into programmer values('Simba',	'123abc',	'Sam Lee',	'2003-06-24',	'$59,000',	'036-2354',	'102  Redoubt Street, Acacia Bay, Taupo')
insert into programmer values('Shacks',	'nimda',	'Jakob Millen',	'2000-09-03',	'$1,000,000',	'037-5402',	'134  Beauzami Crescent, Papakowhai, Porirua')

create table Task
(
TaskID int NOT NULL,
description varchar(30) NOT NULL,
priority varchar(10) NOT NULL,
startdate date NOT NULL,
completion varchar(10) NOT NULL,
PID int NOT NULL,
primary key (TaskID),
CONSTRAINT check_priority
CHECK(priority IN('High', 'Normal', 'Low')),
CONSTRAINT check_completion
CHECK(completion IN('Complete', 'Incomplete'))
)

insert into task values(1,	'Weapons',	'Low',	'2021-03-05',	'Incomplete', 1)
insert into task values(2,	'Movement',	'Low',	'2021-03-05',	'Incomplete', 1)
insert into task values(3,	'Format',	'Normal',	'2019-10-09',	'Complete',	2)
insert into task values(4,	'Updates',	'Normal',	'2020-02-06',	'Complete',	3)
insert into task values(5,	'Questions',	'High',	'2020-06-06',	'Complete',	4)
insert into task values(6,	'Finalisation',	'High',	'2020-08-18',	'Complete',	5)
insert into task values(7,	'Patches',	'High',	'2020-06-24',	'Complete',	6)
insert into task values(8,	'Information',	'Low',	'2020-06-01',	'Complete',	7)
insert into task values(9,	'Game Balance',	'Normal',	'2020-11-14',	'Incomplete',	8)
insert into task values(10,	'interactions',	'Low',	'2019-12-29',	'Complete',	9)

create table Progress
(
ProgressID int NOT NULL,
description varchar(30) NOT NULL,
reportDate date NOT NULL,
TaskID int NOT NULL,
primary key (ProgressID, TaskID),
foreign key (TaskID) references Task,
)

insert into Progress values(1, 'Testing', '2020-02-23', 6)
insert into Progress values(2, 'New Map', '2019-12-18', 4)
insert into Progress values(3, 'RayGun', '2021-04-11', 1)
insert into Progress values(4, 'Sprinting', '2021-05-12', 2)
insert into Progress values(5, 'Damage tweak', '2021-04-24', 3)
insert into Progress values(6, 'Loading Fix', '2021-01-24', 5)
insert into Progress values(7, 'Patch 5', '2020-08-22', 7)
insert into Progress values(8, 'Pick up', '2021-04-24', 10)
insert into Progress values(9, 'Weapons balanced', '2021-04-24', 9)
insert into Progress values(10, 'Research', '2020-12-05', 8)



create table Issue
(
IssueID int NOT NULL,
description varchar(30) NOT NULL,
reportDate date NOT NULL,
priority varchar(10) NOT NULL,
status varchar(20) NOT NULL,
taskID int NOT NULL,
primary key (IssueID),
foreign key (TaskID) references Task,
CONSTRAINT check_IssuePriority
CHECK(priority IN('High', 'Normal', 'Low')),
CONSTRAINT check_IssueStatus
CHECK(status IN('Resolved', 'Unresolved'))
)

insert into Issue values(1, 'Damage', '2021-04-01', 'High', 'Unresolved', 1)
insert into Issue values(2, 'Download error', '2019-08-12', 'Normal', 'Resolved', 3)
insert into Issue values(3, 'Download error', '2019-08-12', 'Normal', 'Resolved', 3)
insert into Issue values(4, 'Loading error', '2018-04-17', 'Normal', 'Resolved', 4)
insert into Issue values(5, 'Download error', '2019-08-12', 'Normal', 'Resolved', 3)
insert into Issue values(6, 'Incorrect values', '2019-01-04', 'Low', 'Resolved', 6)
insert into Issue values(7, 'Download error', '2019-08-12', 'Normal', 'Resolved', 3)
insert into Issue values(8, 'Ak-47 OP', '2021-02-14', 'High', 'Unresolved', 8)

create table WorksOn
(
TaskID int NOT NULL,
p_username varchar(30) NOT NULL,
primary key (TaskID, p_username),
foreign key (TaskID) references Task,
foreign key (p_username) references Programmer
)

insert into WorksOn values(1, 'Simba')
insert into WorksOn values(2, 'ElisesPieces')
insert into WorksOn values(3, 'Shacks')
insert into WorksOn values(4, 'ElisesPieces')
insert into WorksOn values(4, 'Shacks')
insert into WorksOn values(5,'Shacks')
insert into WorksOn values(6, 'ElisesPieces')
insert into WorksOn values(6, 'Simba')
insert into WorksOn values(7, 'Shacks')
insert into WorksOn values(8, 'ElisesPieces')
insert into WorksOn values(8, 'Shacks')
insert into WorksOn values(9, 'Simba')
insert into WorksOn values(10, 'Shacks')

select * from Project
select * from Customer
select * from Manager
select * from Programmer
select * from Task
select * from Progress
select * from Issue
select * from WorksOn

