use SchoolDB;

drop table if exists teaches;
drop table if exists teacher;
drop table if exists student;
drop table if exists class;
drop table if exists school;


create table school (
	id int identity(1,1) primary key,
	description varchar(40)
);

create table class (
	id int identity(1,1),
	description varchar(40),
	schoolid int references school,
	primary key(id, schoolid)
);

create table student (
	id int identity(1,1),
	description varchar(40),
	schoolid int,
	classid int,
	foreign key (classid, schoolid) references class(id, schoolid),
	primary key(id, schoolid, classid)
);

create table teacher (
	id int identity(1,1),
	description varchar(40),
	schoolid int references school,
	primary key (id, schoolid)
);

create table teaches (
	classid int,
	cschoolid int,
	teacherid int,
	tschoolid int,
	foreign key(teacherid, tschoolid) references teacher(id, schoolid),
	foreign key (classid, cschoolid) references class (id, schoolid)
);