--CREATE DATABASE try1VFCS;
--GO
USE try1VFCS;
GO

--Directory

CREATE TABLE Express_Status(
	id_express_status int IDENTITY PRIMARY KEY NOT NULL,
	express_status_name varchar(25) NOT NULL,
	delivery_time tinyint NOT NULL
);
GO
INSERT INTO Express_Status 
VALUES
('Обычная', 60),
('Ускоренная', 30),
('Быстрая', 15),
('Срочная', 3)
GO

CREATE TABLE Gender(
	id_gender char(1) PRIMARY KEY NOT NULL,
	gender varchar(20)
);
GO
INSERT INTO Gender 
VALUES 
('М','Мужской'),
('Ж','Женский'),
('Д','Другой')
GO

CREATE TABLE UserRole(
id_role char(3) PRIMARY KEY NOT NULL,
name_role varchar(50) NOT NULL
);
GO
INSERT INTO UserRole 
VALUES 
('adm','Admin'),
('prm','Promotion')
GO

CREATE TABLE Working_Rate(
	id_working_rate int IDENTITY PRIMARY KEY NOT NULL,
	working_rate char(10) NOT NULL,
	hours_a_day tinyint NOT NULL
)
GO
INSERT INTO Working_Rate 
VALUES 
('5/2', 8),
('2/2', 12),
('3/3', 12),
('1/3', 24)
GO

--Должности
CREATE TABLE Position(
	id_position int IDENTITY PRIMARY KEY NOT NULL,
	name_position varchar(50) NOT NULL,
	id_role char(3) FOREIGN KEY (id_role) REFERENCES UserRole(id_role),
	active_status bit NOT NULL
);
GO