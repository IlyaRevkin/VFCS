USE try1VFCS;
GO

--Promotion

CREATE TABLE Active_Promotions(
	id_promotion int IDENTITY PRIMARY KEY NOT NULL,
	name_promotion varchar(25) NOT NULL,
  short_description_promotion varchar(110) NOT NULL,
	description_promotion varchar(5000) NOT NULL,
	photo_name varchar(100) NULL,
	active_status bit NOT NULL
);
GO
INSERT INTO [dbo].[Active_Promotions] 
VALUES 
('testPromo1','test', 'test',null,1),
('testPromo2','test', 'test',null,1),
('testPromo3','test', 'test',null,1),
('testPromo4','test', 'test',null,0),
('testPromo5','test', 'test',null,1),
('testPromo6','test', 'test',null,1),
('testPromo7','test', 'test',null,0),
('testPromo8','test', 'test',null,0),
('Счастливые часы!','Клиенту, сдавшему авто в сервис с пн по чт с 15:00 до 17:00, предоставляется скидка 10% на все виды работы.','test','PromoHappyHoursLogo',1),
('0123456789012345678901234','01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789','test',null,1)
GO



-- Model_Conf

CREATE TABLE Model(
	id_model int IDENTITY PRIMARY KEY NOT NULL,
	model_name varchar(30)
);
GO
INSERT INTO Model 
VALUES 
('Volvo S60'),
('Volvo V60 Cross Country'),
('Volvo S90'),
('Volvo V90 Cross Country'),
('Volvo XC40'),
('Volvo XC60'),
('Volvo XC90')
GO

CREATE TABLE Conf(
	id_conf int IDENTITY PRIMARY KEY NOT NULL,
	ICE_name char(5),
	ICE_horsepower float,
	ICE_capacity float,
	ICE_type varchar(15),
	type_WD varchar(3),
	transmission char(4)
);
GO
INSERT INTO Conf 
VALUES 
('T3', 150.0, 1.5, 'Бензин','FWD','АКПП'),--xc40
('T4', 190.0, 2.0, 'Бензин','AWD','АКПП'),--xc40
('B4', 190.0, 2.0, 'Дизель','AWD','АКПП'),--xc60 v90
('B5', 190.0, 2.0, 'Бензин','FWD','АКПП'),--s90 s60
('B5', 249.0, 2.0, 'Бензин','AWD','АКПП'),--xc90 xc60 s60 v60 v90 s90 --xc40
('B5', 235.0, 2.0, 'Дизель','AWD','АКПП');--xc90 s90
--INSERT INTO ICE VALUES ('T4', 150.0, 2.0, 'Дизель','AWD')--xc40
--INSERT INTO ICE VALUES ('T4', 150.0, 2.0, 'Дизель','FWD')--xc40
GO

CREATE TABLE Conf_Model(
	id_model int IDENTITY NOT NULL,
	id_conf int IDENTITY NOT NULL,
	PRIMARY KEY (id_model, id_conf)
);
GO
INSERT INTO Conf_Model 
VALUES 
(5, 1),
(5, 2),
(6, 3),
(4, 3),
(1, 4),
(3, 4),
(1, 5),
(2, 5),
(3, 5),
(4, 5),
(6, 5),
(7, 5),
(3, 6),
(7, 6)
--(5, 5);
GO



-- Stoke

CREATE TABLE Product(
	id_product int IDENTITY PRIMARY KEY NOT NULL,
	product_name varchar(250) NOT NULL,
	measure varchar(25) NOT NULL
	--id_conf||id_model??
);
GO

CREATE TABLE Stoke(
	id_cell int IDENTITY PRIMARY KEY NOT NULL,
	id_product int FOREIGN KEY (id_product) REFERENCES Product(id_product) NOT NULL,
	product_count smallint NOT NULL
);
GO

-- заказ делает работние сто или кладовщик
-- заказ на склад или 
-- !!!!со склада
CREATE TABLE Stock_Order(
	id_stoke_order int IDENTITY PRIMARY KEY NOT NULL,
	id_product int FOREIGN KEY (id_product) REFERENCES Product(id_product) NOT NULL,
	product_count tinyint NOT NULL,
	active_status bit NOT NULL
);
GO

CREATE TABLE Spare_Part_Order(
	id_order int IDENTITY PRIMARY KEY NOT NULL,
	order_description varchar(250) NOT NULL,
	order_date date,
	id_express_status int FOREIGN KEY (id_express_status) REFERENCES Express_Status(id_express_status) NOT NULL,
	active_status bit NOT NULL
);
GO



-- Employee - Position - Login

--Требования должности
CREATE TABLE Req_Position(
	id_req_position int IDENTITY PRIMARY KEY NOT NULL,
	position_id int FOREIGN KEY (position_id) REFERENCES Position(id_position) NOT NULL,
	num_of_position int NOT NULL,
	min_experience tinyint NOT NULL,
	id_working_rate int FOREIGN KEY (id_working_rate) REFERENCES Working_Rate(id_working_rate) NOT NULL
);
GO
INSERT INTO Req_Position 
VALUES 
(1, 1, 0, 3),
(1, 3, 1, 3),
(2, 4, 2,3),
(3, 10, 1,3),
(4, 8, 4,3)
GO

CREATE TABLE Employees(
	id_employee int IDENTITY PRIMARY KEY NOT NULL,
	firstname_employee varchar(50) NOT NULL,
	lastname_employee varchar(50) NOT NULL,
	patronymic_employee varchar(50) NULL,
	id_position int FOREIGN KEY (id_position) REFERENCES Position(id_position) NOT NULL,
	employee_SNILS char(14) NOT NULL,
	employee_serial_number_passport int NOT NULL,
	employee_date_of_employment date NOT NULL,
	id_gender char(1) FOREIGN KEY (id_gender) REFERENCES Gender(id_gender) NOT NULL,
	active_status bit NOT NULL
);
GO

CREATE TABLE Position_Employee(
	id_employee int,
	id_position int,
	PRIMARY KEY(id_employee, id_position)
);
GO

CREATE TABLE UserLogin(
	id_login int IDENTITY PRIMARY KEY NOT NULL,
	[login] varchar(100) NOT NULL,
	[password] varchar(max) NOT NULL,
	employee_id char(3) FOREIGN KEY (employee_id) REFERENCES Employee(id_employee)
);
GO
INSERT INTO UserLogin 
VALUES 
('admin','admin',id_employee),
('promo','promo',id_employee)
GO