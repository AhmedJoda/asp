create database company
create table manager(
	id int primary key,
	username varchar(30),
	password varchar(30)
);
create table supervisor(
	id int primary key identity,
	username varchar(30) unique,
	password varchar(30),
	salary float
);
create table employees(
	id int primary key identity,
	username varchar(30) unique,
	salary float
);
create table customers(
	id int primary key identity,
	username varchar(30) unique,
	address varchar(30)
);
create table reports(
	id int primary key identity,
	msg varchar(500)
);

insert into manager values(1,'mado','123');
insert into supervisor (username,password,salary) values('omar','123',3000);
insert into reports (msg) values(' i will work hard manager');
insert into employees (username,salary) values('omar',3000);
insert into employees (username,salary) values('aly',2000);