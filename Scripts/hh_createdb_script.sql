CREATE TABLE Person (
    id int,
	firstName varchar(255),
    lastName varchar(255),
    phone varchar(9),
	email varchar(255),
	PRIMARY KEY (id)
);

CREATE TABLE Employee (
	id int,
    personId int,
	hourlyRate decimal(3,2),
	PRIMARY KEY (id),
	FOREIGN KEY (personId) REFERENCES Person(id)
);

CREATE TABLE Customer (
    personId int,
	company varchar(255),
	status boolean,
	PRIMARY KEY (id),
	FOREIGN KEY (personId) REFERENCES Person(id)
);

CREATE TABLE Property (
    id int,
	customerId int,
	address1 varchar(255),
	address2 varchar(255),
	city varchar(75),
	state varchar(50),
	zip varchar(5),
	sqrft int,
	PRIMARY KEY (id),
	FOREIGN KEY (customerId) REFERENCES Customer(id)
);

CREATE TABLE Appointment (
    id int,
	customerId int,
	employeeId int,
	propertyId int,
	appointmentType varchar(255),
	propertyType varchar(255),
	appointmentDate date,
	appointmentTime time,
	price decimal(5,2),
	timespent decimal(3,2),
	notes text,
	rating int,
	PRIMARY KEY (id),
	FOREIGN KEY (customerId) REFERENCES Customer(id),
	FOREIGN KEY (employeeId) REFERENCES Employee(id),
	FOREIGN KEY (propertyId) REFERENCES Property(id)
);
